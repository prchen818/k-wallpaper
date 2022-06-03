using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace k_wallpaper
{
    public partial class details : UIForm
    {
        public details()
        {
            InitializeComponent();
        }


        public details(string path)
        {
            InitializeComponent();
            picbox.ImageLocation = path;
            picName.Text = Path.GetFileNameWithoutExtension(path);
        }

        private void Btn2PS_Click(object sender, EventArgs e)
        {
            
            PSFunctionForm ps = new PSFunctionForm(picbox.ImageLocation);
            ps.Show();
        }

        private void setwallpaper_Click(object sender, EventArgs e)
        {
            wallpaper kw = new wallpaper();
            kw.SetWallpaper(picbox.ImageLocation);
            wallpapercore.GetWallpaperCore(kw);
        }
    }
}
