using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Reflection;

namespace UpLauncher
{
    public partial class main : Form
    {
        private Thread scan;
        private WebClient client = new WebClient();
        private bool locked = false;

        public main()
        {
            InitializeComponent();
        }

        private void loading(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(utils.mouse_down);
            this.MouseMove += new MouseEventHandler(utils.mouse_move);
            this.FormClosing += new FormClosingEventHandler(this.closing);
            this.SizeChanged += new EventHandler(this.resize);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(this.download_finish);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.download_progress);
            bubble.DoubleClick += new EventHandler(this.open_upl);
            scan = new Thread(new ThreadStart(scanning));
            scan.Start(); //Thread pour pas bloquer l'uplauncher sur la maj
        }

        private void open_upl(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void download_progress(object sender, DownloadProgressChangedEventArgs e)
        {
            utils.set_width(this.pb2, (int)((double)e.ProgressPercentage / (double)100 * 689));
        }

        private void download_finish(object sender, AsyncCompletedEventArgs e)
        {
            locked = false;
        }

        private void closing(object sender, EventArgs e)
        {
            bubble.Dispose();
            Process p = Process.GetCurrentProcess();
            p.Kill();
        }

        private void scanning()
        {
            try
            {
                utils.set_width(this.pb1, 0);
                utils.set_width(this.pb2, 0);
                utils.set_text(this.files, "");
                utils.set_text(this.infos, "Téléchargement des informations...");
                utils.center_text(this.infos, this.Size.Width);
                string args = client.DownloadString(config.download_url + "files.php").Replace("client/", "").Replace('/', '\\');
                utils.set_text(this.infos, "Vérification du/des fichier(s)...");
                utils.center_text(this.infos, this.Size.Width);
                string[] web = args.Split(';');
                int index = 0;
                double percent = 689 / (double)web.Length;
                foreach (string value in web)
                {
                    index++;
                    string[] arg = value.Split(',');
                    if (!(File.Exists(arg[0]) && utils.CrypteFile_md5(arg[0]).Equals(arg[1])))
                    {
                        utils.set_text(this.infos, "Téléchargement du fichier : " + arg[0]);
                        utils.center_text(this.infos, this.Size.Width);
                        locked = true;
                        if (arg[0].Contains('\\'))
                        {
                            string dir = arg[0].Substring(0, arg[0].LastIndexOf('\\'));
                            if (!Directory.Exists(dir))
                                Directory.CreateDirectory(dir);
                        }
                        client.DownloadFileAsync(new Uri(config.download_url + "client/" + arg[0].Replace('\\', '/')), arg[0]);
                        while (locked)
                            Thread.Sleep(10);
                    }
                    utils.set_text(this.files, "Fichier(s) : " + index + "/" + web.Length);
                    utils.set_width(this.pb1, (int)(percent * index));
                }
                utils.set_text(this.infos, "Vous pouvez maintenant jouer.");
                utils.center_text(this.infos, this.Size.Width);
                Process.Start("Dofus.exe");
                if (this.WindowState == FormWindowState.Minimized)
                {
                    bubble.BalloonTipText = "Vous pouvez maintenant jouer.";
                    bubble.ShowBalloonTip(2500);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                bubble.BalloonTipText = "L'uplauncher est toujours ouvert.";
                bubble.ShowBalloonTip(2500);
            }
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (scan != null && scan.IsAlive)
                scan.Suspend();
            scan = new Thread(new ThreadStart(scanning));
            scan.Start();
        }
    }
}
