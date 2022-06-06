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
using System.Reflection;
using System.Drawing.Imaging;


namespace k_wallpaper
{
    public partial class PSFunctionForm : UIForm
    {//以panel为参照的中心点位
        const int panelCenterX = 680;
        const int panelCenterY = 360;

        //bitmap类是用于处理由像素数据定义的图像的对象
        public Bitmap originalBitmap { get;private set; }
        public Bitmap bitmap { get; private set; }
        public Bitmap newbitmap { get; private set; }

        //定义剪裁图片所需用的变量
        bool cut = false;
        bool blnDraw;
        Point start;         //画框的起始点
        Rectangle rect;
        Point Pstart;       //原图的起始点
        Rectangle Orect;//在原图中尺寸

        //定义平移、缩放图片所需用的变量
        Point mouseDownPoint = new Point(); //记录拖拽过程鼠标位置
        bool isMove = false;    //判断鼠标在picturebox上移动时，是否处于拖拽过程(鼠标左键是否按下)
        int zoomStep = 20;      //缩放步长

        public PSFunctionForm()
        {
            InitializeComponent();
        }

        private string picPath;
        public PSFunctionForm(string path)
        {
            InitializeComponent();
            picPath = path;
            bitmap = (Bitmap)Image.FromFile(path);
            originalBitmap = bitmap;
            //每打开图片，picturebox状态要复原，防止因为剪裁收到影响
            convertedPicture.Width = bitmap.Width;
            convertedPicture.Height = bitmap.Height;
            convertedPicture.Location = new Point((panelCenterX - bitmap.Width / 2), (panelCenterY - bitmap.Height / 2));
            originalPicture.Image = bitmap.Clone() as Image;
            convertedPicture.Image = bitmap.Clone() as Image;
            //每打开图片，更改cut
            cut = false;
            tipLabel.Text = "空闲中";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            tipLabel.Text = "空闲中";
        }

        /// <summary>
        /// 打开图片
        /// </summary>
        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                tipLabel.Text = "正在打开";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;

                    bitmap = (Bitmap)Image.FromFile(path);
                    originalBitmap = bitmap;
                    //每打开图片，picturebox状态要复原，防止因为剪裁收到影响
                    convertedPicture.Width = bitmap.Width;
                    convertedPicture.Height = bitmap.Height;
                    convertedPicture.Location = new Point((panelCenterX - bitmap.Width / 2), (panelCenterY - bitmap.Height / 2));


                    originalPicture.Image = bitmap.Clone() as Image;
                    convertedPicture.Image = bitmap.Clone() as Image;
                }
                //每打开图片，更改cut
                cut = false;
                tipLabel.Text = "空闲中";
            }
            catch { }
        }

        /// <summary>
        /// 保存图片
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                tipLabel.Text = "正在保存";
                bool isSave = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //获取要保存的路径
                    string fileName = saveFileDialog1.FileName.ToString();
                    if (fileName != "" && fileName != null)
                    {
                        //获取图片扩展名
                        string fileExtName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToString();
                        System.Drawing.Imaging.ImageFormat imgformat = null;
                        //确定要保存文件的扩展名
                        if (fileExtName != "")
                        {
                            switch (fileExtName)
                            {
                                case "jpg":
                                    imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                    break;
                                case "bmp":
                                    imgformat = System.Drawing.Imaging.ImageFormat.Bmp;
                                    break;
                                case "gif":
                                    imgformat = System.Drawing.Imaging.ImageFormat.Gif;
                                    break;
                                default:
                                    MessageBox.Show("只能存取为: jpg,bmp,gif 格式");
                                    isSave = false;
                                    break;
                            }
                            //默认保存为JPG格式
                            if (imgformat == null)
                            {
                                imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                            }

                            //保存图片
                            if (isSave)
                            {
                                try
                                {
                                    this.convertedPicture.Image.Save(fileName, imgformat);
                                    tipLabel.Text = "保存成功";
                                    timer1.Enabled = true;
                                }
                                catch
                                {
                                    tipLabel.Text = "保存失败！你还没有截取过图片或已经清空图片!";
                                    timer1.Enabled = true;
                                }
                            }
                        }
                    }
                }
                tipLabel.Text = "空闲中";
            }
            catch { }
        }
        /// <summary>
        /// 添加暗角：
        /// 计算顶点与中心的距离maxDistance
        /// 计算每个像素点与中心的距离distance
        /// 计算factor = distance / maxDistance
        /// 将当前像素点的颜色设置为 原颜色 * （1-factor）
        /// </summary>
        private void darkCornerButton_Click(object sender, EventArgs e)
        {
            try
            {
                tipLabel.Text = "正在绘制暗角";
                if (bitmap != null)
                {
                    newbitmap = (Bitmap)convertedPicture.Image;
                    float centerx = newbitmap.Width / 2;
                    float centery = newbitmap.Height / 2;
                    double maxDist = Math.Sqrt(centerx * centerx + centery * centery);
                    double currDist = 0;
                    double factor;
                    Color pixel;

                    for (int i = 0; i < newbitmap.Width; i++)
                    {
                        for (int j = 0; j < newbitmap.Height; j++)
                        {
                            currDist = Math.Sqrt(((double)i - centerx) * ((double)i - centerx) + ((double)j - centery) * ((double)j - centery));
                            factor = currDist / maxDist;

                            pixel = newbitmap.GetPixel(i, j);
                            int red = (int)(pixel.R * (1 - factor));
                            int green = (int)(pixel.G * (1 - factor));
                            int blue = (int)(pixel.B * (1 - factor));
                            newbitmap.SetPixel(i, j, Color.FromArgb(red, green, blue));
                        }
                    }
                    bitmap = newbitmap.Clone() as Bitmap;
                    convertedPicture.Image = bitmap.Clone() as Image;
                }
                else
                {
                    tipLabel.Text = ("加载图片失败！错误！");
                    timer1.Enabled = true;
                }
                tipLabel.Text = "空闲中";
            }
            catch { }
        }

        /// <summary>
        /// 此方法用于减少图片亮度
        /// </summary>
        private void brightnessButtonminus_Click(object sender, EventArgs e)
        {
            try
            {
                tipLabel.Text = "正在调整亮度";
                if (bitmap != null)
                {
                    newbitmap = bitmap.Clone() as Bitmap;
                    Color pixel;
                    int red, green, blue;
                    for (int x = 0; x < newbitmap.Width; x++)
                    {
                        for (int y = 0; y < newbitmap.Height; y++)
                        {
                            pixel = newbitmap.GetPixel(x, y);
                            red = (int)(pixel.R * 0.9);
                            green = (int)(pixel.G * 0.9);
                            blue = (int)(pixel.B * 0.9);
                            newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                        }
                    }
                    bitmap = newbitmap.Clone() as Bitmap;
                    convertedPicture.Image = bitmap.Clone() as Image;
                }
                else
                {
                    tipLabel.Text = ("加载图片失败！错误！");
                    timer1.Enabled = true;
                }
                tipLabel.Text = "空闲中";
            }
            catch { }
        }

        /// <summary>
        /// 此方法用于增加图片亮度
        /// </summary>
        private void brightnessPlus_Click(object sender, EventArgs e)
        {
            try
            {
                tipLabel.Text = "正在调整亮度";
                if (bitmap != null)
                {
                    newbitmap = bitmap.Clone() as Bitmap;
                    Color pixel;
                    int red, green, blue;
                    for (int x = 0; x < newbitmap.Width; x++)
                    {
                        for (int y = 0; y < newbitmap.Height; y++)
                        {
                            pixel = newbitmap.GetPixel(x, y);
                            //增加亮度，溢出则置最大值
                            red = (int)(pixel.R * 1.1);
                            green = (int)(pixel.G * 1.1);
                            blue = (int)(pixel.B * 1.1);
                            if (red > 255) red = 255;
                            if (green > 255) green = 255;
                            if (blue > 255) blue = 255;

                            newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                        }
                    }
                    bitmap = newbitmap.Clone() as Bitmap;
                    convertedPicture.Image = bitmap.Clone() as Image;
                }
                else
                {
                    tipLabel.Text = ("加载图片失败！错误！");
                    timer1.Enabled = true;
                }
                tipLabel.Text = "空闲中";
            }
            catch { }
        }

        /// <summary>
        /// 图像雾化效果
        /// </summary>
        private void fogButton_Click(object sender, EventArgs e)
        {
            try
            {
                tipLabel.Text = "正在绘制雾化效果";
                newbitmap = bitmap.Clone() as Bitmap;
                Color pixel;
                for (int x = 1; x < newbitmap.Width - 1; x++)
                    for (int y = 1; y < newbitmap.Height - 1; y++)
                    {
                        System.Random MyRandom = new Random();
                        int k = MyRandom.Next(123456);
                        //像素块大小
                        int dx = x + k % 19;
                        int dy = y + k % 19;
                        if (dx >= newbitmap.Width)
                            dx = newbitmap.Width - 1;
                        if (dy >= newbitmap.Height)
                            dy = newbitmap.Height - 1;
                        pixel = bitmap.GetPixel(dx, dy);
                        newbitmap.SetPixel(x, y, pixel);
                    }
                bitmap = newbitmap.Clone() as Bitmap;
                convertedPicture.Image = bitmap.Clone() as Image;
                tipLabel.Text = "空闲中";
            }
            catch (Exception ex)
            {
                tipLabel.Text = ("加载图片失败！错误！");
                timer1.Enabled = true;
            }
        }

        /// <summary>
        /// 浮雕效果就是把RGB三个颜色取反。 
        /// 具体的实现用255-当前颜色的分量
        /// </summary>
        private void reliefButton_Click(object sender, EventArgs e)
        {
            try
            {
                tipLabel.Text = "正在进行浮雕";
                if (bitmap != null)
                {
                    newbitmap = bitmap.Clone() as Bitmap;

                    Color pixel;
                    int red, green, blue;
                    for (int x = 0; x < newbitmap.Width; x++)
                    {
                        for (int y = 0; y < newbitmap.Height; y++)
                        {
                            pixel = newbitmap.GetPixel(x, y);
                            red = (int)(255 - pixel.R);
                            green = (int)(255 - pixel.G);
                            blue = (int)(255 - pixel.B);
                            newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                        }
                    }
                    bitmap = newbitmap.Clone() as Bitmap;
                    convertedPicture.Image = bitmap.Clone() as Image;
                }
                else
                {
                    tipLabel.Text = ("加载图片失败！错误！");
                    timer1.Enabled = true;
                }
                tipLabel.Text = "空闲中";
            }
            catch { }
        }

        /// <summary>
        /// 实现图片马赛克效果
        /// </summary>
        private void mosaicButton_Click(object sender, EventArgs e)
        {
            try
            {
                tipLabel.Text = "正在绘制马赛克";
                if (bitmap != null)
                {
                    newbitmap = bitmap.Clone() as Bitmap;
                    int RIDIO = 10;                                                           //马赛克的尺度，默认为周围两个像素
                    for (int h = 0; h < newbitmap.Height; h += RIDIO)
                    {
                        for (int w = 0; w < newbitmap.Width; w += RIDIO)
                        {
                            int avgRed = 0, avgGreen = 0, avgBlue = 0;
                            int count = 0;
                            //取周围的像素
                            for (int x = w; (x < w + RIDIO && x < newbitmap.Width); x++)
                            {
                                for (int y = h; (y < h + RIDIO && y < newbitmap.Height); y++)
                                {
                                    Color pixel = newbitmap.GetPixel(x, y);
                                    avgRed += pixel.R;
                                    avgGreen += pixel.G;
                                    avgBlue += pixel.B;
                                    count++;
                                }
                            }
                            //取平均值
                            avgRed = avgRed / count;
                            avgBlue = avgBlue / count;
                            avgGreen = avgGreen / count;
                            //设置颜色
                            for (int x = w; (x < w + RIDIO && x < newbitmap.Width); x++)
                            {
                                for (int y = h; (y < h + RIDIO && y < newbitmap.Height); y++)
                                {
                                    Color newColor = Color.FromArgb(avgRed, avgGreen, avgBlue);
                                    newbitmap.SetPixel(x, y, newColor);
                                }
                            }
                        }
                    }
                    bitmap = newbitmap.Clone() as Bitmap;
                    convertedPicture.Image = bitmap.Clone() as Image;
                }
                else
                {
                    tipLabel.Text = ("加载图片失败！错误！");
                    timer1.Enabled = true;
                }
                tipLabel.Text = "空闲中";
            }
            catch { }
        }
        /// <summary>
        /// 此方法将图片原有的颜色去除，留下灰色
        /// </summary>
        private void darkButton_Click(object sender, EventArgs e)
        {
            try
            {
                tipLabel.Text = "正在去色";
                if (bitmap != null)
                {
                    newbitmap = bitmap.Clone() as Bitmap;
                    Color pixel;
                    int ret;
                    for (int x = 0; x < newbitmap.Width; x++)
                    {
                        for (int y = 0; y < newbitmap.Height; y++)
                        {
                            pixel = newbitmap.GetPixel(x, y);
                            ret = (int)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);
                            newbitmap.SetPixel(x, y, Color.FromArgb(ret, ret, ret));
                        }
                    }
                    bitmap = newbitmap.Clone() as Bitmap;
                    convertedPicture.Image = bitmap.Clone() as Image;
                }
                else
                {
                    tipLabel.Text = ("加载图片失败！错误！");
                    timer1.Enabled = true;
                }
                tipLabel.Text = "空闲中";
            }
            catch { }
        }

        /// <summary>
        /// 柔化效果显示图片
        /// </summary>
        private void softButton_Click(object sender, EventArgs e)
        {
            try
            {
                tipLabel.Text = "正在柔化";
                newbitmap = bitmap.Clone() as Bitmap;
                Color pixel;
                //高斯模板
                int[] Gauss = { 1, 2, 1, 2, 4, 2, 1, 2, 1 };
                for (int x = 1; x < newbitmap.Width - 1; x++)
                    for (int y = 1; y < newbitmap.Height - 1; y++)
                    {
                        int r = 0, g = 0, b = 0;
                        int Index = 0;
                        for (int col = -1; col <= 1; col++)
                            for (int row = -1; row <= 1; row++)
                            {
                                pixel = bitmap.GetPixel(x + row, y + col);
                                r += pixel.R * Gauss[Index];
                                g += pixel.G * Gauss[Index];
                                b += pixel.B * Gauss[Index];
                                Index++;
                            }
                        r /= 14;
                        g /= 14;
                        b /= 14;
                        //处理颜色值溢出
                        r = r > 255 ? 255 : r;
                        r = r < 0 ? 0 : r;
                        g = g > 255 ? 255 : g;
                        g = g < 0 ? 0 : g;
                        b = b > 255 ? 255 : b;
                        b = b < 0 ? 0 : b;
                        newbitmap.SetPixel(x - 1, y - 1, Color.FromArgb(r, g, b));
                    }
                bitmap = newbitmap.Clone() as Bitmap;
                convertedPicture.Image = bitmap.Clone() as Image;
                tipLabel.Text = "空闲中";
            }
            catch (Exception ex)
            {
                tipLabel.Text = ("加载图片失败！错误！");
                timer1.Enabled = true;
            }
        }

        /// <summary>
        /// 按下剪裁按钮，开始剪裁
        /// </summary>
        private void cutButton_Click(object sender, EventArgs e)
        {
            try
            {
                cut = true;
                tipLabel.Text = "请画框剪裁";
            }
            catch { }
        }
        /// <summary>
        /// 鼠标左键点击图片，则触发开始画框这个功能，
        /// 或者触发移动功能，取决于剪裁按钮是否按下
        /// </summary>
        private void convertedPicture_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (cut == true)
                {
                    int originalWidth = this.convertedPicture.Image.Width;
                    int originalHeight = this.convertedPicture.Image.Height;
                    //rectangle初始化存储原图的大小比例
                    PropertyInfo rectangleProperty = this.convertedPicture.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
                    Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(this.convertedPicture, null);
                    //currentwidth存储宽
                    //currentheight存储高
                    int currentWidth = rectangle.Width;
                    int currentHeight = rectangle.Height;
                    //rate存储现高与原图高的比例
                    double rate = (double)currentHeight / (double)originalHeight;

                    int black_left_width = (currentWidth == this.convertedPicture.Width) ? 0 : (this.convertedPicture.Width - currentWidth) / 2;
                    int black_top_height = (currentHeight == this.convertedPicture.Height) ? 0 : (this.convertedPicture.Height - currentHeight) / 2;

                    int zoom_x = e.X - black_left_width;
                    int zoom_y = e.Y - black_top_height;

                    double original_x = (double)zoom_x / rate;
                    double original_y = (double)zoom_y / rate;
                    //新图的起始点
                    Pstart = new Point((int)e.X, (int)e.Y);
                    //画框的起始点
                    start = e.Location;
                    Invalidate();
                    blnDraw = true;
                }
                else//移动功能触发
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        mouseDownPoint.X = Cursor.Position.X;
                        mouseDownPoint.Y = Cursor.Position.Y;
                        isMove = true;
                        convertedPicture.Focus();
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// 鼠标按下左键后移动，则框的大小随之改变
        /// </summary>
        private void convertedPicture_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (blnDraw && cut)
                {
                    if (e.Button != MouseButtons.Left)//判断是否按下左键
                        return;
                    Point tempEndPoint = e.Location;//记录框的位置和大小
                    rect.Location = new Point(
                    Math.Min(start.X, tempEndPoint.X),
                    Math.Min(start.Y, tempEndPoint.Y));
                    rect.Size = new Size(
                    Math.Abs(start.X - tempEndPoint.X),
                    Math.Abs(start.Y - tempEndPoint.Y));

                    int originalWidth = this.convertedPicture.Image.Width;
                    int originalHeight = this.convertedPicture.Image.Height;
                    PropertyInfo rectangleProperty = this.convertedPicture.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
                    Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(this.convertedPicture, null);

                    int currentWidth = rectangle.Width;
                    int currentHeight = rectangle.Height;

                    double rate = (double)currentHeight / (double)originalHeight;

                    int black_left_width = (currentWidth == this.convertedPicture.Width) ? 0 : (this.convertedPicture.Width - currentWidth) / 2;
                    int black_top_height = (currentHeight == this.convertedPicture.Height) ? 0 : (this.convertedPicture.Height - currentHeight) / 2;

                    int zoom_x = e.X - black_left_width;
                    int zoom_y = e.Y - black_top_height;

                    double original_x = (double)zoom_x / rate;
                    double original_y = (double)zoom_y / rate;

                    Orect.Location = new Point(
                    Math.Min(Pstart.X, (int)original_x),
                    Math.Min(Pstart.Y, (int)original_y));
                    Orect.Size = new Size(
                    Math.Abs(Pstart.X - e.X),
                    Math.Abs(Pstart.Y - e.Y));
                    convertedPicture.Invalidate();
                }
                else//移动功能
                {
                    convertedPicture.Focus();
                    if (isMove)
                    {
                        int x, y;
                        int moveX, moveY;
                        moveX = Cursor.Position.X - mouseDownPoint.X;
                        moveY = Cursor.Position.Y - mouseDownPoint.Y;
                        x = convertedPicture.Location.X + moveX;
                        y = convertedPicture.Location.Y + moveY;
                        convertedPicture.Location = new Point(x, y);
                        mouseDownPoint.X = Cursor.Position.X;
                        mouseDownPoint.Y = Cursor.Position.Y;
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// 鼠标按键松开，表示画框结束
        /// </summary>
        private void convertedPicture_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (blnDraw)
                {
                    bitmap = PartDraw(bitmap, Orect);
                    this.convertedPicture.Width = bitmap.Width;
                    this.convertedPicture.Height = bitmap.Height;
                    this.convertedPicture.Image = bitmap;
                    this.convertedPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    convertedPicture.Location = new Point((panelCenterX - this.convertedPicture.Width / 2), (panelCenterY - this.convertedPicture.Height / 2));
                    //结束绘制,控制量置零
                    blnDraw = false;
                    cut = false;
                    tipLabel.Text = "空闲中";
                }
                else//移动功能
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        isMove = false;
                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// 将画的框加上颜色
        /// </summary>
        private void convertedPicture_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (blnDraw && cut)
                {
                    if (convertedPicture.Image != null)
                    {
                        if (rect != null && rect.Width > 0 && rect.Height > 0)
                        {
                            e.Graphics.DrawRectangle(new Pen(Color.Gray, 2), rect);//重新绘制颜色
                        }
                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// 此方法用于切割图片
        /// </summary>
        public static Bitmap PartDraw(Image src, Rectangle cutpart)
        {
            Bitmap rectbmp = new Bitmap(cutpart.Width, cutpart.Height, PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(rectbmp))
            {
                g.DrawImage(src, new Rectangle(0, 0, cutpart.Width, cutpart.Height), cutpart, GraphicsUnit.Pixel);
                g.Dispose();
             }
             return rectbmp;
        }
       /// <summary>
       /// 鼠标滚轮滚动
       /// </summary>
        private void convertedPicture_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                int x = e.Location.X;
                int y = e.Location.Y;
                int ow = convertedPicture.Width;
                int oh = convertedPicture.Height;
                int VX, VY;
                //一定要加1.0！！这里的double要注意！！
                double ratio = (1.0 * convertedPicture.Width) / (1.0 * convertedPicture.Height);
                if (e.Delta > 0)
                {
                    convertedPicture.Width += zoomStep;
                    convertedPicture.Height = Convert.ToInt32(convertedPicture.Width / ratio);
                }
                if (e.Delta < 0)
                {
                    if (convertedPicture.Width < bitmap.Width / 10)
                        return;
                    convertedPicture.Width -= zoomStep;
                    convertedPicture.Height = Convert.ToInt32(convertedPicture.Width / ratio);
                }
                VX = (int)((double)x * (ow - convertedPicture.Width) / ow);
                VY = (int)((double)y * (oh - convertedPicture.Height) / oh);
                convertedPicture.Location = new Point(convertedPicture.Location.X + VX, convertedPicture.Location.Y + VY);
                bitmap = this.convertedPicture.Image.Clone() as Bitmap;
            }
            catch { }
        }
        /// <summary>
        /// 按下居中按钮，图片居中
        /// </summary>
        private void centerButton_Click(object sender, EventArgs e)
        {
            try {
                convertedPicture.Location = new Point((panelCenterX - convertedPicture.Width / 2), (panelCenterY - convertedPicture.Height / 2));
            }
            catch { }
         }
        /// <summary>
        /// 重置按钮触发事件
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                //每重置图片，picturebox状态要复原，防止因为剪裁收到影响
                convertedPicture.Width = originalBitmap.Width;
                convertedPicture.Height = originalBitmap.Height;
                convertedPicture.Location = new Point((panelCenterX - originalBitmap.Width / 2), (panelCenterY - originalBitmap.Height / 2));

                originalPicture.Image = originalBitmap.Clone() as Image;
                convertedPicture.Image = originalBitmap.Clone() as Image;

                cut = false;
                tipLabel.Text = "空闲中";
            }
            catch { }
        }
    }
}
