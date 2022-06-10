namespace k_wallpaper
{
    partial class NetSearch
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.wd = new Sunny.UI.UITextBox();
            this.Btn = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 35);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1280, 682);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Visible = false;
            // 
            // wd
            // 
            this.wd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wd.Location = new System.Drawing.Point(352, 315);
            this.wd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wd.MinimumSize = new System.Drawing.Size(1, 16);
            this.wd.Name = "wd";
            this.wd.ShowText = false;
            this.wd.Size = new System.Drawing.Size(459, 35);
            this.wd.TabIndex = 1;
            this.wd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.wd.Watermark = "输入关键词";
            this.wd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Btn
            // 
            this.Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn.Location = new System.Drawing.Point(843, 315);
            this.Btn.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(100, 35);
            this.Btn.TabIndex = 2;
            this.Btn.Text = "搜索";
            this.Btn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // NetSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::k_wallpaper.Properties.Resources._1600427341151;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.wd);
            this.Controls.Add(this.webBrowser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetSearch";
            this.Text = "搜索";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private Sunny.UI.UITextBox wd;
        private Sunny.UI.UIButton Btn;
    }
}