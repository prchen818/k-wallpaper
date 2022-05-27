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
    public partial class instruction : UIForm
    {
        static int i = 0;
        public instruction()
        {
            InitializeComponent();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            i--;
            showimg();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            i++;
            showimg();
        }
        public void showimg()
        {
            if (i <= 0)
            {
                i = 0;
            }
            if(i==1)
            {
                string path1= @"..\..\Resources\102.jpg";
                pictureBox1.Image = Image.FromFile(path1);
                uiLabel1.Text = "1";
            }
        }

        private void instruction_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
