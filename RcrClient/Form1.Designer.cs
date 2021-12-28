
namespace RcrClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTestuj = new System.Windows.Forms.Button();
            this.clbServers = new System.Windows.Forms.CheckedListBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnTestuj, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clbServers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRun, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnTestuj
            // 
            this.btnTestuj.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTestuj.Location = new System.Drawing.Point(358, 3);
            this.btnTestuj.Name = "btnTestuj";
            this.btnTestuj.Size = new System.Drawing.Size(98, 50);
            this.btnTestuj.TabIndex = 0;
            this.btnTestuj.Text = "Testuj";
            this.btnTestuj.UseVisualStyleBackColor = true;
            this.btnTestuj.Click += new System.EventHandler(this.btnTestuj_Click);
            // 
            // clbServers
            // 
            this.clbServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbServers.FormattingEnabled = true;
            this.clbServers.Location = new System.Drawing.Point(3, 59);
            this.clbServers.Name = "clbServers";
            this.clbServers.Size = new System.Drawing.Size(453, 345);
            this.clbServers.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRun.Location = new System.Drawing.Point(358, 410);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(98, 48);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Uruchom";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTestuj;
        private System.Windows.Forms.CheckedListBox clbServers;
        private System.Windows.Forms.Button btnRun;
    }
}

