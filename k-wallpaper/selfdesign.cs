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
    public partial class selfdesign : UIForm
    {
        public selfdesign()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            wallpaper w = new wallpaper();
            w.SetWallpaper(@"..\..\102.jpg");
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
