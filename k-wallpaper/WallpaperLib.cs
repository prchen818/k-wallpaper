using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace k_wallpaper
{
    public partial class WallpaperLib : UIForm
    {
        public WallpaperLib()
        {
            InitializeComponent();
            refresh();
        }

        string storePath = @"PictureLib/";

        private void importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ofd.Title = "导入壁纸库";
                ofd.Filter = "JPEG|*.jpg;*.jpeg|MP4|*.mp4|PNG|*.png|GIF|*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileName != null)
                    {
                        string sourcePath = ofd.FileName;//临时存放图片源位置
                        string filename = Path.GetFileName(ofd.FileName);//图片的真实名字
                        string destPath = storePath + filename;//目标存放位置
                        
                        System.IO.File.Copy(sourcePath, destPath);
                        refresh();
                        MessageBox.Show("导入成功！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh()
        {
            if (!System.IO.Directory.Exists(storePath))
            {
                System.IO.Directory.CreateDirectory(storePath);
            }
            picBox.Clear();
            string[] imgs = Directory.GetFiles(storePath, "*.jpg");
            if (imgs.Length == 0)
            {
                UILabel lb = new UILabel();
                lb.Text = "壁纸库为空";
                picBox.Add(lb);
                return;
            }
            foreach (string img in imgs)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(320, 180);
                pb.ImageLocation = img;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.DoubleClick += new EventHandler(showDetails);
                picBox.Add(pb);
            }
        }

        private void showDetails(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            details details = new details(pic.ImageLocation);
            details.Show();
        }
    }
}
