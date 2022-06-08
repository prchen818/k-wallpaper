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
        public wallpaper k_w = new wallpaper();
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
           k_w.SetWallpaper(picbox.ImageLocation);
            wallpapercore.GetWallpaperCore(k_w);
        }

        private void Btn_rename_Click(object sender, EventArgs e)
        {
            renameText.Visible = true;
            renameText.Focus();
        }



        private void Rename()
        {
            picName.Visible = false;
            string srcPath = picbox.ImageLocation;
            string dicPath = Path.GetDirectoryName(srcPath);
            string extension = Path.GetExtension(srcPath);
            if (renameText.Text != "" || renameText.Text != null)
            {
                string desPath = dicPath + "/" + renameText.Text  + extension;
                if (File.Exists(desPath))
                {
                    MessageBox.Show("重复命名！请重新输入！");
                }
                else
                {
                    try
                    {
                        File.Move(srcPath, desPath);
                        picName.Text = renameText.Text;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("输入不能为空！");
            }

            picName.Visible = true;
            renameText.Visible = false;
        }

        private void renameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Rename();
            }
        }
    }
}
