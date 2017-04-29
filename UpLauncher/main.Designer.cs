using System.Windows.Forms;

namespace UpLauncher
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.infos = new System.Windows.Forms.Label();
            this.b_close = new System.Windows.Forms.PictureBox();
            this.b_min = new System.Windows.Forms.PictureBox();
            this.bubble = new System.Windows.Forms.NotifyIcon(this.components);
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.files = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.rst = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.b_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // infos
            // 
            this.infos.AutoSize = true;
            this.infos.BackColor = System.Drawing.Color.Transparent;
            this.infos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infos.ForeColor = System.Drawing.Color.White;
            this.infos.Location = new System.Drawing.Point(244, 165);
            this.infos.Name = "infos";
            this.infos.Size = new System.Drawing.Size(206, 13);
            this.infos.TabIndex = 0;
            this.infos.Text = "Téléchargement des informations...";
            // 
            // b_close
            // 
            this.b_close.BackColor = System.Drawing.Color.Transparent;
            this.b_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_close.Location = new System.Drawing.Point(664, 8);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(21, 26);
            this.b_close.TabIndex = 1;
            this.b_close.TabStop = false;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // b_min
            // 
            this.b_min.BackColor = System.Drawing.Color.Transparent;
            this.b_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_min.Location = new System.Drawing.Point(639, 8);
            this.b_min.Name = "b_min";
            this.b_min.Size = new System.Drawing.Size(21, 26);
            this.b_min.TabIndex = 2;
            this.b_min.TabStop = false;
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // bubble
            // 
            this.bubble.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.bubble.BalloonTipTitle = "UpLauncher";
            this.bubble.Icon = ((System.Drawing.Icon)(resources.GetObject("bubble.Icon")));
            this.bubble.Text = "UpLauncher";
            this.bubble.Visible = true;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.BackgroundImage = global::UpLauncher.Properties.Resources.pb;
            this.pb1.Location = new System.Drawing.Point(3, 186);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(689, 10);
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            // 
            // files
            // 
            this.files.AutoSize = true;
            this.files.BackColor = System.Drawing.Color.Transparent;
            this.files.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.files.ForeColor = System.Drawing.Color.White;
            this.files.Location = new System.Drawing.Point(12, 165);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(41, 13);
            this.files.TabIndex = 4;
            this.files.Text = "label1";
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.BackgroundImage = global::UpLauncher.Properties.Resources.pb;
            this.pb2.Location = new System.Drawing.Point(3, 202);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(689, 10);
            this.pb2.TabIndex = 5;
            this.pb2.TabStop = false;
            // 
            // rst
            // 
            this.rst.AutoSize = true;
            this.rst.BackColor = System.Drawing.Color.Transparent;
            this.rst.LinkColor = System.Drawing.Color.DarkGray;
            this.rst.Location = new System.Drawing.Point(5, 4);
            this.rst.Name = "rst";
            this.rst.Size = new System.Drawing.Size(35, 13);
            this.rst.TabIndex = 6;
            this.rst.TabStop = true;
            this.rst.Text = "Reset";
            this.rst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.rst_LinkClicked);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 215);
            this.Controls.Add(this.rst);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.files);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.b_min);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.infos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(695, 215);
            this.MinimumSize = new System.Drawing.Size(695, 215);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpLauncher";
            this.TransparencyKey = System.Drawing.Color.DeepPink;
            this.Load += new System.EventHandler(this.loading);
            ((System.ComponentModel.ISupportInitialize)(this.b_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infos;
        private PictureBox b_close;
        private PictureBox b_min;
        private NotifyIcon bubble;
        private PictureBox pb1;
        private Label files;
        private PictureBox pb2;
        private LinkLabel rst;
    }
}

