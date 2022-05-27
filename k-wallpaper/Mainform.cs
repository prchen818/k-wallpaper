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

namespace k_wallpaper
{
    public partial class Mainform : UIForm
    {
        public Mainform()
        {
            InitializeComponent();
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
            selfdesign sd = new selfdesign();
            this.Hide();
            sd.Show();
        }
    }
}
