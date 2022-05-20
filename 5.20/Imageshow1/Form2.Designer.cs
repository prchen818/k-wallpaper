namespace picture
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.moveOut = new System.Windows.Forms.Button();
            this.moveSmall = new System.Windows.Forms.Button();
            this.RotateRight = new System.Windows.Forms.Button();
            this.RotateLeft = new System.Windows.Forms.Button();
            this.ScreenAll = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Front = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // moveOut
            // 
            this.moveOut.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.moveOut.Image = ((System.Drawing.Image)(resources.GetObject("moveOut.Image")));
            this.moveOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moveOut.Location = new System.Drawing.Point(370, 20);
            this.moveOut.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.moveOut.Name = "moveOut";
            this.moveOut.Size = new System.Drawing.Size(164, 80);
            this.moveOut.TabIndex = 1;
            this.moveOut.Text = "放大";
            this.moveOut.UseVisualStyleBackColor = true;
            this.moveOut.Click += new System.EventHandler(this.Button1_Click放大);
            // 
            // moveSmall
            // 
            this.moveSmall.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.moveSmall.Image = ((System.Drawing.Image)(resources.GetObject("moveSmall.Image")));
            this.moveSmall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moveSmall.Location = new System.Drawing.Point(546, 20);
            this.moveSmall.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.moveSmall.Name = "moveSmall";
            this.moveSmall.Size = new System.Drawing.Size(164, 80);
            this.moveSmall.TabIndex = 2;
            this.moveSmall.Text = "缩小";
            this.moveSmall.UseVisualStyleBackColor = true;
            this.moveSmall.Click += new System.EventHandler(this.Button2_Click缩小);
            // 
            // RotateRight
            // 
            this.RotateRight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RotateRight.Image = ((System.Drawing.Image)(resources.GetObject("RotateRight.Image")));
            this.RotateRight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RotateRight.Location = new System.Drawing.Point(1382, 18);
            this.RotateRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RotateRight.Name = "RotateRight";
            this.RotateRight.Size = new System.Drawing.Size(228, 80);
            this.RotateRight.TabIndex = 5;
            this.RotateRight.Text = "逆时针";
            this.RotateRight.UseVisualStyleBackColor = true;
            this.RotateRight.Click += new System.EventHandler(this.RotateSHUN_Click);
            // 
            // RotateLeft
            // 
            this.RotateLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RotateLeft.Image = ((System.Drawing.Image)(resources.GetObject("RotateLeft.Image")));
            this.RotateLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RotateLeft.Location = new System.Drawing.Point(1156, 20);
            this.RotateLeft.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RotateLeft.Name = "RotateLeft";
            this.RotateLeft.Size = new System.Drawing.Size(214, 80);
            this.RotateLeft.TabIndex = 6;
            this.RotateLeft.Text = "顺时针";
            this.RotateLeft.UseVisualStyleBackColor = true;
            this.RotateLeft.Click += new System.EventHandler(this.RotateNI_Click);
            // 
            // ScreenAll
            // 
            this.ScreenAll.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ScreenAll.Image = ((System.Drawing.Image)(resources.GetObject("ScreenAll.Image")));
            this.ScreenAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScreenAll.Location = new System.Drawing.Point(1622, 18);
            this.ScreenAll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ScreenAll.Name = "ScreenAll";
            this.ScreenAll.Size = new System.Drawing.Size(212, 80);
            this.ScreenAll.TabIndex = 7;
            this.ScreenAll.Text = "全屏";
            this.ScreenAll.UseVisualStyleBackColor = true;
            this.ScreenAll.Click += new System.EventHandler(this.AllScreen_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.RotateRight);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.Front);
            this.panel1.Controls.Add(this.moveOut);
            this.panel1.Controls.Add(this.moveSmall);
            this.panel1.Controls.Add(this.ScreenAll);
            this.panel1.Controls.Add(this.RotateLeft);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Location = new System.Drawing.Point(24, 1174);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2052, 106);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1846, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 80);
            this.button1.TabIndex = 12;
            this.button1.Text = "设置为壁纸";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(216, 40);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 28);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "拉伸";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(84, 40);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 28);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "原图";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // Front
            // 
            this.Front.Image = ((System.Drawing.Image)(resources.GetObject("Front.Image")));
            this.Front.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Front.Location = new System.Drawing.Point(722, 18);
            this.Front.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Front.Name = "Front";
            this.Front.Size = new System.Drawing.Size(208, 80);
            this.Front.TabIndex = 4;
            this.Front.Text = "上一张";
            this.Front.UseVisualStyleBackColor = true;
            this.Front.Click += new System.EventHandler(this.Fornt_Click);
            // 
            // Next
            // 
            this.Next.Image = ((System.Drawing.Image)(resources.GetObject("Next.Image")));
            this.Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Next.Location = new System.Drawing.Point(942, 18);
            this.Next.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(202, 80);
            this.Next.TabIndex = 3;
            this.Next.Text = "下一张";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Button3_Click下一张);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2052, 1138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2100, 1286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "图片";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form2_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button moveOut;
        private System.Windows.Forms.Button moveSmall;
        private System.Windows.Forms.Button Front;
        private System.Windows.Forms.Button RotateRight;
        private System.Windows.Forms.Button RotateLeft;
        private System.Windows.Forms.Button ScreenAll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Next;
    }
}