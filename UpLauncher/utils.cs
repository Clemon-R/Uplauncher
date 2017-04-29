using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace UpLauncher
{
    class utils
    {
        public static void set_text(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke((MethodInvoker)delegate () { ctrl.Text = text; });
            }
            else
            {
                ctrl.Text = text;
            }
        }

        public static void set_location(Control ctrl, Point p)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke((MethodInvoker)delegate () { ctrl.Location = p; });
            }
            else
            {
                ctrl.Location = p;
            }
        }

        public static void set_width(Control ctrl, int w)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke((MethodInvoker)delegate () { ctrl.Size = new Size(w, ctrl.Size.Height); });
            }
            else
            {
                ctrl.Size = new Size(w, ctrl.Size.Height);
            }
        }

        public static string CrypteFile_md5(string fileName)
        {
            byte[] hash = MD5.Create().ComputeHash(File.OpenRead(fileName));
            StringBuilder result = new StringBuilder();
            foreach (byte value in hash)
                result.AppendFormat("{0:X2}", value);
            return (result.ToString().ToLower());
        }

        public static void center_text(Control obj, int center)
        {
            set_location(obj, new Point((center - obj.Size.Width) / 2, obj.Location.Y));
        }

        private static Point mouse_offset;
        public static void mouse_down(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        public static void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                main.ActiveForm.Location = mousePos;
            }
        }
    }
}
