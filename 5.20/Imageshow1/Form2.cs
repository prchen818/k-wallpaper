using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace picture
{
    public partial class Form2 : Form
    {
        private int index = 0;
        private string[] files;
        private Bitmap myBitmap,srcBitmap;
        private Image myImage;
        private string path;
        private Form1 form1;
        static string filep;
        public Form2(string filepath, Form1 form1)
        {
            InitializeComponent();
            srcBitmap = new Bitmap(filepath);
            myBitmap = new Bitmap(srcBitmap, pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = myBitmap;
             path = Path.GetDirectoryName(filepath);
            this.form1 = form1;
            files = Directory.GetFiles(path);
            int i = 0;
            foreach(var Fi in files)
            {
                if (filepath.Equals(Fi))
                {
                    index = i;
                    filep = Fi;
                }

            }
            this.Text = "图片" + filepath;
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.AutoMouseWheel);
            myImage = pictureBox1.Image;

            RadioButton1_CheckedChanged(null,null);
            
        }

     
        private void AutoMouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            myImage = pictureBox1.Image;
            if (e.Delta > 0)myBitmap = new Bitmap(myImage, myImage.Width * 2, myImage.Height * 2);
            else myBitmap = new Bitmap(myImage, myImage.Width/2, myImage.Height /2);
            pictureBox1.Image = myBitmap;
        }
        private void Button1_Click放大(object sender, EventArgs e)
        {
            srcBitmap = new Bitmap(files[index]);
            myBitmap = new Bitmap(srcBitmap, pictureBox1.Image.Width * 2, pictureBox1.Image.Height * 2);
            pictureBox1.Image = myBitmap;
        }
        private void Button2_Click缩小(object sender, EventArgs e)
        {
            srcBitmap = new Bitmap(files[index]);
            myBitmap = new Bitmap(srcBitmap, pictureBox1.Image.Width / 2, pictureBox1.Image.Height / 2);
            pictureBox1.Image = myBitmap;
        }
        private void Button3_Click下一张(object sender, EventArgs e)
        {
            index = (index + 1) % files.Length;
            srcBitmap = new Bitmap(files[index]);
            if (radioButton1.Checked)
            {
                myBitmap = new Bitmap(srcBitmap, srcBitmap.Size.Width, srcBitmap.Size.Height);
            }
            else myBitmap = new Bitmap(srcBitmap, pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = myBitmap;
            this.Text = "图片" + files[index];
        }
        private void Fornt_Click(object sender, EventArgs e)
        {
            if (index == 0) { index = files.Length - 1; }
            else index = (index - 1) % files.Length;
            srcBitmap = new Bitmap(files[index]);
            if (radioButton1.Checked)
            {
                myBitmap = new Bitmap(srcBitmap, srcBitmap.Size.Width, srcBitmap.Size.Height);
            }
            else myBitmap = new Bitmap(srcBitmap, pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = myBitmap;
            this.Text = "图片" + files[index];
        }
        private void RotateSHUN_Click(object sender, EventArgs e)
        {
            myImage = pictureBox1.Image;
            myImage.RotateFlip(RotateFlipType.Rotate90FlipXY); //调用RotateFlip方法将JPG格式图像进行旋转            
            myBitmap = new Bitmap(myImage, myImage.Width , myImage.Height );
            pictureBox1.Image = myBitmap;
        }
        private void RotateNI_Click(object sender, EventArgs e)
        {
            myImage = pictureBox1.Image;
            myImage.RotateFlip(RotateFlipType.Rotate270FlipXY); //调用RotateFlip方法将JPG格式图像进行旋转            
            myBitmap = new Bitmap(myImage, myImage.Width, myImage.Height);
            pictureBox1.Image = myBitmap;
        }
        private void AllScreen_Click(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;     //设置窗体为无边框样式
            this.WindowState = FormWindowState.Maximized;    //最大化窗体 
            srcBitmap = new Bitmap(files[index]);
            myBitmap = new Bitmap(srcBitmap, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = myBitmap;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();//开始
            this.panel1.Visible=false;
        }
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int Photo(int uAction, int uParam, string lpvParam, int fuWinIni);
        private void Button1_Click(object sender, EventArgs e)
        {
            //按钮点击时发生 
            Photo(20, 0,filep, 2);
            //调用API

        }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            srcBitmap = new Bitmap(files[index]);
            myBitmap = new Bitmap(srcBitmap, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = myBitmap;
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            srcBitmap = new Bitmap(files[index]);
            myBitmap = new Bitmap(srcBitmap, srcBitmap.Size.Width, srcBitmap.Size.Height);
            pictureBox1.Image = myBitmap;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            index = (index + 1) % files.Length;
            srcBitmap = new Bitmap(files[index]);
            myBitmap = new Bitmap(srcBitmap, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = myBitmap;
            timer1.Interval = 2000;//设置timer1控件时间间隔为2000ms即2秒 
        }
        private void form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timer1.Enabled = false;
                pictureBox1.Dock = DockStyle.None;
                this.FormBorderStyle = FormBorderStyle.Sizable;  //设置窗体为普通样式
                this.WindowState = FormWindowState.Normal;
                srcBitmap = new Bitmap(files[index]);
                myBitmap = new Bitmap(srcBitmap, srcBitmap.Size.Width, srcBitmap.Size.Height);
                pictureBox1.Image = myBitmap;
                this.panel1.Visible = true;
            }
            if (e.KeyCode == Keys.F1)
            {
                timer1.Enabled = false;

            }
            if (e.KeyCode == Keys.F2)
            {
                timer1.Enabled = true;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

    }
}
