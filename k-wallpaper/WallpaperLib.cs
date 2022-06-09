using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using Newtonsoft.Json;
using k_wallpaper;

namespace k_wallpaper
{
    public partial class WallpaperLib : UIForm
    {
        public WallpaperLib()
        {
            InitializeComponent();
            refresh();
            loadHistory();
        }

        List<string> pics = new List<string>();
        string storePath = @"PictureLib/";
        bool sign = false;

        private void importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ofd.Title = "导入壁纸库";
                //此处之后的后缀还需要修改
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
            string[] extensions = { "*.jpg", "*.jpeg", "*.mp4", "*.png", "*.gif" };

            foreach(string pattern in extensions)
            {
                string[] imgs = Directory.GetFiles(storePath, pattern);
                if (imgs.Length == 0)
                {
                    continue;
                }
                addpicture2lib(imgs);
            }
            if (picBox.IsNull())
            {
                UILabel lb = new UILabel();
                lb.Text = "壁纸库为空";
                picBox.Add(lb);
            }
        }

        private void addpicture2lib(string[] imgs)
        {
            foreach (string img in imgs)
            {
                
                WallpaperBox pb = new WallpaperBox();
                pb.Size = new Size(320, 180);
                pb.Image = util.GetThumbnailByPath(img);
                pb.wpLocation = img;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.DoubleClick += new EventHandler(showDetails);
                picBox.Add(pb);
                
            }
        }

        private void showDetails(object sender, EventArgs e)
        {
            WallpaperBox pic = (WallpaperBox)sender;
            details details = new details(pic);
            details.Show();
        }

        private void search_Btn_Click(object sender, EventArgs e)
        {
            new NetSearch().Show();
        }

        private void leftshow_Click(object sender, EventArgs e)
        {
            if (!sign)
            {
                for (int i = 0; i < 190; i++)
                {
                    leftPanel.Location = new Point(leftPanel.Location.X + 1, leftPanel.Location.Y);
                    //Thread.Sleep(10);
                }
                leftshow.Text = "收\n起\n";
                sign = !sign;
            }
            else
            {
                for (int i = 0; i < 190; i++)
                {
                    leftPanel.Location = new Point(leftPanel.Location.X - 1, leftPanel.Location.Y);
                    //Thread.Sleep(10);
                }
                leftshow.Text = "历\n史\n";
                sign = !sign;
            }
        }

        private void loadHistory()
        {
            pics = HistoryHelper.Read_Json();
            picHistory.DataSource = pics;
        }

        
    }

    public class WallpaperBox: PictureBox
    {
        public string wpLocation;

        public WallpaperBox() : base()
        {

        }
    }

   

}
