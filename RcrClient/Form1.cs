using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RcrClient
{
    public partial class Form1 : Form
    {
        List<Server> servers = new List<Server>();

        public Form1()
        {
            InitializeComponent();

            var serverIps = File.ReadAllLines("servers.txt")
                .Where(p => !string.IsNullOrEmpty(p));

            foreach (string ip in serverIps)
            {
                if (IPAddress.TryParse(ip, out var address))
                {
                    servers.Add(new Server{
                        Ip = address
                    });
                }
            }

            InitListWithServers();

            Test();
        }

        private void InitListWithServers()
        {
            clbServers.DataSource = servers;
        }

        private async void Test()
        {
            tableLayoutPanel1.Enabled = false;

            List<Task> testTasks = new List<Task>();
            foreach (var server in servers)
            {
                testTasks.Add(CallEndpoint(server.Ip, "test").ContinueWith(task =>
                {
                    server.Enabled = task.Result == HttpStatusCode.OK;
                }));
            }

            await Task.WhenAll(testTasks.ToArray());

            foreach (var server in servers)
            {
                clbServers.SetItemCheckState(clbServers.Items.IndexOf(server), 
                    server.Enabled ? CheckState.Checked : CheckState.Indeterminate);
            }
            
            tableLayoutPanel1.Enabled = true;
        }

        private Task<HttpStatusCode> CallEndpoint(IPAddress ip, string endpoint)
        {
            HttpClient client = new HttpClient();

            return client.GetAsync($"{ip}:8888/rcr/{endpoint}")
                    .ContinueWith(task => task.Result.StatusCode);
        }

        private void btnTestuj_Click(object sender, EventArgs e)
        {
            Test();
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Enabled = false;

            var runTasks = new List<(IPAddress, Task<HttpStatusCode>)>();
            foreach (Server selectedServer in clbServers.CheckedItems)
            {
                runTasks.Add((selectedServer.Ip, CallEndpoint(selectedServer.Ip, "run")));
            }

            await Task.WhenAll(runTasks.Select(task => task.Item2).ToArray());

            var failedTasks = runTasks
                .Where(p => p.Item2.Result != HttpStatusCode.OK)
                .ToArray();

            if (failedTasks.Length == 0)
            {
                MessageBox.Show("Pomyślnie uruchomiono skrypty na wszystkich serwerach.", "Rezultat",
                    MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Uruchamianie skryptu na niektórych serwerach zakończyło się błędem:" + 
                                string.Join(Environment.NewLine, failedTasks.Select(p => p.Item1.ToString()).ToArray()), 
                    "Rezultat", MessageBoxButtons.OK);
            }

            tableLayoutPanel1.Enabled = true;
        }
    }
}
