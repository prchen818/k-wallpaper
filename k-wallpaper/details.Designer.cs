
namespace k_wallpaper
{
    partial class details
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
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.setwallpaper = new Sunny.UI.UIButton();
            this.Btn2PS = new Sunny.UI.UIButton();
            this.Btn_rename = new Sunny.UI.UIButton();
            this.picName = new Sunny.UI.UIMarkLabel();
            this.picbox = new k_wallpaper.WallpaperBox();
            this.renameText = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(256, 483);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(164, 46);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = " ";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // setwallpaper
            // 
            this.setwallpaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setwallpaper.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setwallpaper.Location = new System.Drawing.Point(768, 658);
            this.setwallpaper.MinimumSize = new System.Drawing.Size(1, 1);
            this.setwallpaper.Name = "setwallpaper";
            this.setwallpaper.Size = new System.Drawing.Size(119, 32);
            this.setwallpaper.TabIndex = 8;
            this.setwallpaper.Text = "设置为壁纸";
            this.setwallpaper.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setwallpaper.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.setwallpaper.Click += new System.EventHandler(this.setwallpaper_Click);
            // 
            // Btn2PS
            // 
            this.Btn2PS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn2PS.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn2PS.Location = new System.Drawing.Point(893, 658);
            this.Btn2PS.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn2PS.Name = "Btn2PS";
            this.Btn2PS.Size = new System.Drawing.Size(119, 32);
            this.Btn2PS.TabIndex = 9;
            this.Btn2PS.Text = "PS";
            this.Btn2PS.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn2PS.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn2PS.Click += new System.EventHandler(this.Btn2PS_Click);
            // 
            // Btn_rename
            // 
            this.Btn_rename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_rename.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_rename.Location = new System.Drawing.Point(643, 658);
            this.Btn_rename.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_rename.Name = "Btn_rename";
            this.Btn_rename.Size = new System.Drawing.Size(119, 32);
            this.Btn_rename.TabIndex = 10;
            this.Btn_rename.Text = "修改名称";
            this.Btn_rename.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_rename.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_rename.Click += new System.EventHandler(this.Btn_rename_Click);
            // 
            // picName
            // 
            this.picName.AutoSize = true;
            this.picName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picName.Location = new System.Drawing.Point(48, 73);
            this.picName.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.picName.Name = "picName";
            this.picName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.picName.Size = new System.Drawing.Size(74, 26);
            this.picName.TabIndex = 11;
            this.picName.Text = "图片名称";
            this.picName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.picName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // picbox
            // 
            this.picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox.Location = new System.Drawing.Point(52, 112);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(960, 540);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 12;
            this.picbox.TabStop = false;
            // 
            // renameText
            // 
            this.renameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.renameText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.renameText.Location = new System.Drawing.Point(52, 75);
            this.renameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.renameText.MinimumSize = new System.Drawing.Size(1, 16);
            this.renameText.Name = "renameText";
            this.renameText.ShowText = false;
            this.renameText.Size = new System.Drawing.Size(117, 29);
            this.renameText.TabIndex = 13;
            this.renameText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.renameText.Visible = false;
            this.renameText.Watermark = "请输入新名称";
            this.renameText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.renameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.renameText_KeyPress);
            // 
            // details
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.renameText);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.picName);
            this.Controls.Add(this.Btn_rename);
            this.Controls.Add(this.Btn2PS);
            this.Controls.Add(this.setwallpaper);
            this.Controls.Add(this.uiLabel4);
            this.MaximizeBox = false;
            this.Name = "details";
            this.Text = "自定义壁纸";
            this.ZoomScaleRect = new System.Drawing.Rectangle(30, 30, 874, 649);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton setwallpaper;
        private Sunny.UI.UIButton Btn2PS;
        private Sunny.UI.UIButton Btn_rename;
        private Sunny.UI.UIMarkLabel picName;
        private k_wallpaper.WallpaperBox picbox;
        private Sunny.UI.UITextBox renameText;
    }
}