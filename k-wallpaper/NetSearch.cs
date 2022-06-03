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

                webBrowser.Navigate("https://image.baidu.com/search/index?tn=baiduimage&word=" + wd.Text + "&width=1920&height=1080");
                webBrowser.Visible = true;
                wd.Visible = false;
                Btn.Visible = false;
            }
        }
    }
}
