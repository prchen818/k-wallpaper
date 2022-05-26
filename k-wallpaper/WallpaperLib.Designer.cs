namespace k_wallpaper
{
    partial class WallpaperLib
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
            this.picBox = new Sunny.UI.UIFlowLayoutPanel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.importBtn = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picBox.Location = new System.Drawing.Point(49, 80);
            this.picBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.picBox.Name = "picBox";
            this.picBox.Padding = new System.Windows.Forms.Padding(2);
            this.picBox.ShowText = false;
            this.picBox.Size = new System.Drawing.Size(1171, 592);
            this.picBox.TabIndex = 1;
            this.picBox.Text = "uiFlowLayoutPanel1";
            this.picBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.picBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(49, 49);
            this.uiMarkLabel1.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiMarkLabel1.TabIndex = 2;
            this.uiMarkLabel1.Text = "本地壁纸";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // importBtn
            // 
            this.importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.importBtn.Location = new System.Drawing.Point(1048, 48);
            this.importBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(83, 24);
            this.importBtn.TabIndex = 3;
            this.importBtn.Text = "导入";
            this.importBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.importBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(1137, 48);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(83, 24);
            this.uiButton2.TabIndex = 4;
            this.uiButton2.Text = "搜索";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // WallpaperLib
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.picBox);
            this.Name = "WallpaperLib";
            this.Text = "Form1";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIFlowLayoutPanel picBox;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UIButton importBtn;
        private Sunny.UI.UIButton uiButton2;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}