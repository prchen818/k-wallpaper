
namespace k_wallpaper
{
    partial class PSFunctionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PSFunctionForm));
            this.mainPanel = new Sunny.UI.UIPanel();
            this.convertedPicture = new System.Windows.Forms.PictureBox();
            this.originalPicture = new System.Windows.Forms.PictureBox();
            this.darkCornerButton = new Sunny.UI.UIButton();
            this.brightnessButtonminus = new Sunny.UI.UIButton();
            this.brightnessPlus = new Sunny.UI.UIButton();
            this.fogButton = new Sunny.UI.UIButton();
            this.reliefButton = new Sunny.UI.UIButton();
            this.mosaicButton = new Sunny.UI.UIButton();
            this.darkButton = new Sunny.UI.UIButton();
            this.softButton = new Sunny.UI.UIButton();
            this.cutButton = new Sunny.UI.UIButton();
            this.centerButton = new Sunny.UI.UIButton();
            this.openButton = new Sunny.UI.UIButton();
            this.saveButton = new Sunny.UI.UIButton();
            this.tipLabel = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.clearButton = new Sunny.UI.UIButton();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convertedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.convertedPicture);
            this.mainPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainPanel.Location = new System.Drawing.Point(174, 66);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1334, 732);
            this.mainPanel.Style = Sunny.UI.UIStyle.Custom;
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Text = "工作台";
            this.mainPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // convertedPicture
            // 
            this.convertedPicture.Location = new System.Drawing.Point(188, 145);
            this.convertedPicture.Name = "convertedPicture";
            this.convertedPicture.Size = new System.Drawing.Size(943, 394);
            this.convertedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.convertedPicture.TabIndex = 0;
            this.convertedPicture.TabStop = false;
            this.convertedPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.convertedPicture_Paint);
            this.convertedPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.convertedPicture_MouseDown);
            this.convertedPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.convertedPicture_MouseMove);
            this.convertedPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.convertedPicture_MouseUp);
            this.convertedPicture.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.convertedPicture_MouseWheel);
            // 
            // originalPicture
            // 
            this.originalPicture.Location = new System.Drawing.Point(3, 69);
            this.originalPicture.Name = "originalPicture";
            this.originalPicture.Size = new System.Drawing.Size(148, 103);
            this.originalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPicture.TabIndex = 1;
            this.originalPicture.TabStop = false;
            // 
            // darkCornerButton
            // 
            this.darkCornerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.darkCornerButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.darkCornerButton.Location = new System.Drawing.Point(19, 211);
            this.darkCornerButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.darkCornerButton.Name = "darkCornerButton";
            this.darkCornerButton.Size = new System.Drawing.Size(100, 35);
            this.darkCornerButton.Style = Sunny.UI.UIStyle.Custom;
            this.darkCornerButton.TabIndex = 2;
            this.darkCornerButton.Text = "暗角";
            this.darkCornerButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.darkCornerButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.darkCornerButton.Click += new System.EventHandler(this.darkCornerButton_Click);
            // 
            // brightnessButtonminus
            // 
            this.brightnessButtonminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brightnessButtonminus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.brightnessButtonminus.Location = new System.Drawing.Point(73, 252);
            this.brightnessButtonminus.MinimumSize = new System.Drawing.Size(1, 1);
            this.brightnessButtonminus.Name = "brightnessButtonminus";
            this.brightnessButtonminus.Size = new System.Drawing.Size(20, 35);
            this.brightnessButtonminus.Style = Sunny.UI.UIStyle.Custom;
            this.brightnessButtonminus.TabIndex = 3;
            this.brightnessButtonminus.Text = "<";
            this.brightnessButtonminus.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.brightnessButtonminus.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.brightnessButtonminus.Click += new System.EventHandler(this.brightnessButtonminus_Click);
            // 
            // brightnessPlus
            // 
            this.brightnessPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brightnessPlus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.brightnessPlus.Location = new System.Drawing.Point(99, 252);
            this.brightnessPlus.MinimumSize = new System.Drawing.Size(1, 1);
            this.brightnessPlus.Name = "brightnessPlus";
            this.brightnessPlus.Size = new System.Drawing.Size(20, 35);
            this.brightnessPlus.Style = Sunny.UI.UIStyle.Custom;
            this.brightnessPlus.TabIndex = 4;
            this.brightnessPlus.Text = ">";
            this.brightnessPlus.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.brightnessPlus.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.brightnessPlus.Click += new System.EventHandler(this.brightnessPlus_Click);
            // 
            // fogButton
            // 
            this.fogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fogButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fogButton.Location = new System.Drawing.Point(19, 293);
            this.fogButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.fogButton.Name = "fogButton";
            this.fogButton.Size = new System.Drawing.Size(100, 35);
            this.fogButton.Style = Sunny.UI.UIStyle.Custom;
            this.fogButton.TabIndex = 5;
            this.fogButton.Text = "雾化";
            this.fogButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fogButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.fogButton.Click += new System.EventHandler(this.fogButton_Click);
            // 
            // reliefButton
            // 
            this.reliefButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reliefButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reliefButton.Location = new System.Drawing.Point(19, 334);
            this.reliefButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.reliefButton.Name = "reliefButton";
            this.reliefButton.Size = new System.Drawing.Size(100, 35);
            this.reliefButton.Style = Sunny.UI.UIStyle.Custom;
            this.reliefButton.TabIndex = 6;
            this.reliefButton.Text = "浮雕";
            this.reliefButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reliefButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.reliefButton.Click += new System.EventHandler(this.reliefButton_Click);
            // 
            // mosaicButton
            // 
            this.mosaicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mosaicButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mosaicButton.Location = new System.Drawing.Point(19, 375);
            this.mosaicButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.mosaicButton.Name = "mosaicButton";
            this.mosaicButton.Size = new System.Drawing.Size(100, 35);
            this.mosaicButton.Style = Sunny.UI.UIStyle.Custom;
            this.mosaicButton.TabIndex = 7;
            this.mosaicButton.Text = "马赛克";
            this.mosaicButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mosaicButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mosaicButton.Click += new System.EventHandler(this.mosaicButton_Click);
            // 
            // darkButton
            // 
            this.darkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.darkButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.darkButton.Location = new System.Drawing.Point(19, 416);
            this.darkButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.darkButton.Name = "darkButton";
            this.darkButton.Size = new System.Drawing.Size(100, 35);
            this.darkButton.Style = Sunny.UI.UIStyle.Custom;
            this.darkButton.TabIndex = 8;
            this.darkButton.Text = "去色";
            this.darkButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.darkButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.darkButton.Click += new System.EventHandler(this.darkButton_Click);
            // 
            // softButton
            // 
            this.softButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.softButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.softButton.Location = new System.Drawing.Point(19, 457);
            this.softButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.softButton.Name = "softButton";
            this.softButton.Size = new System.Drawing.Size(100, 35);
            this.softButton.Style = Sunny.UI.UIStyle.Custom;
            this.softButton.TabIndex = 9;
            this.softButton.Text = "柔化";
            this.softButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.softButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.softButton.Click += new System.EventHandler(this.softButton_Click);
            // 
            // cutButton
            // 
            this.cutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cutButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cutButton.Location = new System.Drawing.Point(19, 534);
            this.cutButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(100, 35);
            this.cutButton.Style = Sunny.UI.UIStyle.Custom;
            this.cutButton.TabIndex = 10;
            this.cutButton.Text = "剪裁";
            this.cutButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cutButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // centerButton
            // 
            this.centerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.centerButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.centerButton.Location = new System.Drawing.Point(19, 575);
            this.centerButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(100, 35);
            this.centerButton.Style = Sunny.UI.UIStyle.Custom;
            this.centerButton.TabIndex = 11;
            this.centerButton.Text = "居中";
            this.centerButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.centerButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.centerButton.Click += new System.EventHandler(this.centerButton_Click);
            // 
            // openButton
            // 
            this.openButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openButton.Location = new System.Drawing.Point(19, 685);
            this.openButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 35);
            this.openButton.Style = Sunny.UI.UIStyle.Custom;
            this.openButton.TabIndex = 12;
            this.openButton.Text = "打开";
            this.openButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.Location = new System.Drawing.Point(19, 726);
            this.saveButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 35);
            this.saveButton.Style = Sunny.UI.UIStyle.Custom;
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "保存";
            this.saveButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tipLabel
            // 
            this.tipLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tipLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tipLabel.Location = new System.Drawing.Point(19, 786);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(100, 23);
            this.tipLabel.Style = Sunny.UI.UIStyle.Custom;
            this.tipLabel.TabIndex = 14;
            this.tipLabel.Text = "空闲中";
            this.tipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tipLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(14, 252);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(53, 38);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 15;
            this.uiLabel2.Text = "亮度";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearButton.Location = new System.Drawing.Point(19, 644);
            this.clearButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 35);
            this.clearButton.Style = Sunny.UI.UIStyle.Custom;
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "重置";
            this.clearButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PSFunctionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.centerButton);
            this.Controls.Add(this.cutButton);
            this.Controls.Add(this.softButton);
            this.Controls.Add(this.darkButton);
            this.Controls.Add(this.mosaicButton);
            this.Controls.Add(this.reliefButton);
            this.Controls.Add(this.fogButton);
            this.Controls.Add(this.brightnessPlus);
            this.Controls.Add(this.brightnessButtonminus);
            this.Controls.Add(this.darkCornerButton);
            this.Controls.Add(this.originalPicture);
            this.Controls.Add(this.mainPanel);
            this.Name = "PSFunctionForm";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "图片工作坊";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.TitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1920, 1020);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.convertedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel mainPanel;
        private System.Windows.Forms.PictureBox convertedPicture;
        private System.Windows.Forms.PictureBox originalPicture;
        private Sunny.UI.UIButton darkCornerButton;
        private Sunny.UI.UIButton brightnessButtonminus;
        private Sunny.UI.UIButton brightnessPlus;
        private Sunny.UI.UIButton fogButton;
        private Sunny.UI.UIButton reliefButton;
        private Sunny.UI.UIButton mosaicButton;
        private Sunny.UI.UIButton darkButton;
        private Sunny.UI.UIButton softButton;
        private Sunny.UI.UIButton cutButton;
        private Sunny.UI.UIButton centerButton;
        private Sunny.UI.UIButton openButton;
        private Sunny.UI.UIButton saveButton;
        private Sunny.UI.UILabel tipLabel;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Sunny.UI.UIButton clearButton;
    }
}