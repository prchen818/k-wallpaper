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

namespace k_wallpaper
{
    public partial class NetSearch : UIForm
    {
        public NetSearch()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (wd.Text != "")
            {
                string url = "https://cn.bing.com/images/search?q=" +
                    wd.Text + "&qft=+filterui:imagesize-custom_1920_1080";
                webBrowser.Navigate(url);
                webBrowser.Visible = true;
                wd.Visible = false;
                Btn.Visible = false;
            }
        }
    }
}
