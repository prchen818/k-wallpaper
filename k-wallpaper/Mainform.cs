using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using System.Diagnostics;
using k_wallpaper.Properties;

namespace k_wallpaper
{
    public partial class Mainform : UIForm
    {
        public Mainform()
        {
            InitializeComponent();
            this.loadNotifyIcon();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            instruction frm = new instruction();
            frm.ShowDialog();
        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("iexplore.exe", "https://gitee.com/joey-van/k-wallpaper.git");
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            WallpaperLib sd = new WallpaperLib();
            this.Hide();
            sd.Show();
        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {
            details sd = new details();
            this.Hide();
            sd.Show();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
            }
        }

        private void loadNotifyIcon()
        {
            notifyIcon.Icon = Resources.favicon;
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason==CloseReason.UserClosing)
            {
                e.Cancel = true;

                WindowState = FormWindowState.Minimized;
                notifyIcon.Visible = true;
                this.Hide();
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
