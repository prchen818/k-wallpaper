using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace psfunction
{
    public partial class WPLib : Form
    {
        public WPLib()
        {
            InitializeComponent();
            refresh();
        }

        string storePath = @"Resources/";
        
        /// <summary>
        /// 导入壁纸：
        /// 将壁纸文件从源路径复制到程序数据目录
        /// </summary>
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
                        if (!System.IO.Directory.Exists(storePath))
                        {
                            System.IO.Directory.CreateDirectory(storePath);
                        }
                        System.IO.File.Copy(sourcePath, destPath);
                        MessageBox.Show("导入成功！");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 刷新壁纸库显示
        /// </summary>
        private void refresh()
        {
            picBox.Controls.Clear();
            string[] imgs = Directory.GetFiles(storePath,"*.jpg");
            foreach (string img in imgs)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(320, 180);
                pb.Image = Image.FromFile(img);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.BorderStyle = BorderStyle.FixedSingle;
                picBox.Controls.Add(pb);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
