using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void addPictures(string[] files)
        {
            foreach (string fullname in files)
            {
                if (fullname.Contains(".jpg") || fullname.Contains(".bmp") || fullname.Contains(".jpeg") || fullname.Contains(".png"))
                {
                    PictureBox box = new PictureBox();
                    box.Tag = fullname;
                    box.Width = 120;
                    box.Height = 90;
                    Image image = Image.FromFile(fullname);
                    Image thumbImage=Image.FromFile(fullname);
                    thumbImage = image.GetThumbnailImage(100, 100, null, IntPtr.Zero); 
                    box.Image = thumbImage;
                    box.Click += this.PictureBox1_Click;                 
                    this.flowLayoutPanel1.Controls.Add(box);
                }
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            string fp = box.Tag  as string;
            this.Hide();
            Form2 sp = new Form2(fp,this);
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            if( path.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {

                this.flowLayoutPanel1.Controls.Clear();
                
                var files = Directory.GetFiles(path.SelectedPath);
                addPictures(files);
            }

            
        }
    }
}
