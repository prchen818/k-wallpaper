
namespace psfunction
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.originalPicture = new System.Windows.Forms.PictureBox();
            this.convertedPicture = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.darkCornerButton = new System.Windows.Forms.Button();
            this.brightnessButton = new System.Windows.Forms.Button();
            this.fogButton = new System.Windows.Forms.Button();
            this.reliefButton = new System.Windows.Forms.Button();
            this.mosaicButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.tipLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.darkButton = new System.Windows.Forms.Button();
            this.softButton = new System.Windows.Forms.Button();
            this.cutButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.centerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convertedPicture)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // originalPicture
            // 
            this.originalPicture.BackColor = System.Drawing.SystemColors.Control;
            this.originalPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.originalPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalPicture.Location = new System.Drawing.Point(12, 12);
            this.originalPicture.Name = "originalPicture";
            this.originalPicture.Size = new System.Drawing.Size(124, 93);
            this.originalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPicture.TabIndex = 0;
            this.originalPicture.TabStop = false;
            // 
            // convertedPicture
            // 
            this.convertedPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.convertedPicture.Location = new System.Drawing.Point(9, 0);
            this.convertedPicture.Name = "convertedPicture";
            this.convertedPicture.Size = new System.Drawing.Size(1742, 973);
            this.convertedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.convertedPicture.TabIndex = 1;
            this.convertedPicture.TabStop = false;
            this.convertedPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.convertedPicture_Paint);
            this.convertedPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.convertedPicture_MouseDown);
            this.convertedPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.convertedPicture_MouseMove);
            this.convertedPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.convertedPicture_MouseUp);
            this.convertedPicture.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.convertedPicture_MouseWheel);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(13, 111);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(94, 29);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "打开";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 146);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // darkCornerButton
            // 
            this.darkCornerButton.Location = new System.Drawing.Point(12, 227);
            this.darkCornerButton.Name = "darkCornerButton";
            this.darkCornerButton.Size = new System.Drawing.Size(94, 29);
            this.darkCornerButton.TabIndex = 4;
            this.darkCornerButton.Text = "暗角";
            this.darkCornerButton.UseVisualStyleBackColor = true;
            this.darkCornerButton.Click += new System.EventHandler(this.darkCornerButton_Click);
            // 
            // brightnessButton
            // 
            this.brightnessButton.Location = new System.Drawing.Point(12, 262);
            this.brightnessButton.Name = "brightnessButton";
            this.brightnessButton.Size = new System.Drawing.Size(94, 29);
            this.brightnessButton.TabIndex = 5;
            this.brightnessButton.Text = "亮度";
            this.brightnessButton.UseVisualStyleBackColor = true;
            this.brightnessButton.Click += new System.EventHandler(this.brightnessButton_Click);
            // 
            // fogButton
            // 
            this.fogButton.Location = new System.Drawing.Point(12, 297);
            this.fogButton.Name = "fogButton";
            this.fogButton.Size = new System.Drawing.Size(94, 29);
            this.fogButton.TabIndex = 6;
            this.fogButton.Text = "雾化";
            this.fogButton.UseVisualStyleBackColor = true;
            this.fogButton.Click += new System.EventHandler(this.fogButton_Click);
            // 
            // reliefButton
            // 
            this.reliefButton.Location = new System.Drawing.Point(12, 332);
            this.reliefButton.Name = "reliefButton";
            this.reliefButton.Size = new System.Drawing.Size(94, 29);
            this.reliefButton.TabIndex = 7;
            this.reliefButton.Text = "浮雕";
            this.reliefButton.UseVisualStyleBackColor = true;
            this.reliefButton.Click += new System.EventHandler(this.reliefButton_Click);
            // 
            // mosaicButton
            // 
            this.mosaicButton.Location = new System.Drawing.Point(12, 367);
            this.mosaicButton.Name = "mosaicButton";
            this.mosaicButton.Size = new System.Drawing.Size(94, 29);
            this.mosaicButton.TabIndex = 8;
            this.mosaicButton.Text = "马赛克";
            this.mosaicButton.UseVisualStyleBackColor = true;
            this.mosaicButton.Click += new System.EventHandler(this.mosaicButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.BackColor = System.Drawing.SystemColors.Control;
            this.tipLabel.Location = new System.Drawing.Point(13, 965);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(54, 20);
            this.tipLabel.TabIndex = 10;
            this.tipLabel.Text = "忙碌中";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // darkButton
            // 
            this.darkButton.Location = new System.Drawing.Point(13, 438);
            this.darkButton.Name = "darkButton";
            this.darkButton.Size = new System.Drawing.Size(94, 29);
            this.darkButton.TabIndex = 11;
            this.darkButton.Text = "去色";
            this.darkButton.UseVisualStyleBackColor = true;
            this.darkButton.Click += new System.EventHandler(this.darkButton_Click);
            // 
            // softButton
            // 
            this.softButton.Location = new System.Drawing.Point(13, 474);
            this.softButton.Name = "softButton";
            this.softButton.Size = new System.Drawing.Size(94, 29);
            this.softButton.TabIndex = 12;
            this.softButton.Text = "柔化";
            this.softButton.UseVisualStyleBackColor = true;
            this.softButton.Click += new System.EventHandler(this.softButton_Click);
            // 
            // cutButton
            // 
            this.cutButton.Location = new System.Drawing.Point(13, 629);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(94, 29);
            this.cutButton.TabIndex = 13;
            this.cutButton.Text = "剪裁";
            this.cutButton.UseVisualStyleBackColor = true;
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.convertedPicture);
            this.mainPanel.Location = new System.Drawing.Point(151, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1761, 973);
            this.mainPanel.TabIndex = 14;
            // 
            // centerButton
            // 
            this.centerButton.Location = new System.Drawing.Point(13, 677);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(94, 29);
            this.centerButton.TabIndex = 15;
            this.centerButton.Text = "居中";
            this.centerButton.UseVisualStyleBackColor = true;
            this.centerButton.Click += new System.EventHandler(this.centerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 997);
            this.Controls.Add(this.centerButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.cutButton);
            this.Controls.Add(this.softButton);
            this.Controls.Add(this.darkButton);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.mosaicButton);
            this.Controls.Add(this.reliefButton);
            this.Controls.Add(this.fogButton);
            this.Controls.Add(this.brightnessButton);
            this.Controls.Add(this.darkCornerButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.originalPicture);
            this.Name = "Form1";
            this.Text = "壁纸自定义";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convertedPicture)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalPicture;
        private System.Windows.Forms.PictureBox convertedPicture;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button darkCornerButton;
        private System.Windows.Forms.Button brightnessButton;
        private System.Windows.Forms.Button fogButton;
        private System.Windows.Forms.Button reliefButton;
        private System.Windows.Forms.Button mosaicButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button darkButton;
        private System.Windows.Forms.Button softButton;
        private System.Windows.Forms.Button cutButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button centerButton;
    }
}

