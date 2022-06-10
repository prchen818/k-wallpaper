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


        public details(WallpaperBox box)
        {
            InitializeComponent();
            picbox.wpLocation=box.wpLocation;
            picbox.Image = box.Image;
            picName.Text = Path.GetFileNameWithoutExtension(box.wpLocation);
            HistoryHelper.Write_Json(box.wpLocation);
        }

        private void Btn2PS_Click(object sender, EventArgs e)
        {
            
            PSFunctionForm ps = new PSFunctionForm(picbox.wpLocation);
            ps.Show();
        }

        private void setwallpaper_Click(object sender, EventArgs e)
        {
            Mainform.k_w.SetWallpaper(picbox.wpLocation);
            //Mainform.k_w.SetWallpaper(@"C:\Users\沛\AppData\Roaming\Microsoft\Windows\Themes\CachedFiles\CachedImage_1920_1080_POS4.jpg");
        }
        
        private void Btn_rename_Click(object sender, EventArgs e)
        {
            picName.Visible = false;
            renameText.Visible = true;
            renameText.Focus();
        }



        private void Rename()
        {
            string srcPath = picbox.wpLocation;
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
                        picbox.wpLocation = desPath;
                        HistoryHelper.Write_Json(srcPath);
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
