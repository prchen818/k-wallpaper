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
            this.leftshow = new Sunny.UI.UIButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.importBtn = new Sunny.UI.UIButton();
            this.search_Btn = new Sunny.UI.UIButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.picHistory = new Sunny.UI.UIListBox();
            this.leftPanel = new Sunny.UI.UIPanel();
            this.leftPanel.SuspendLayout();
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
            // leftshow
            // 
            this.leftshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftshow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftshow.Location = new System.Drawing.Point(193, 3);
            this.leftshow.MinimumSize = new System.Drawing.Size(1, 1);
            this.leftshow.Name = "leftshow";
            this.leftshow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.leftshow.Size = new System.Drawing.Size(31, 490);
            this.leftshow.TabIndex = 4;
            this.leftshow.Text = "历\n史\n";
            this.leftshow.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftshow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.leftshow.Click += new System.EventHandler(this.leftshow_Click);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(49, 49);
            this.uiMarkLabel1.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel1.Size = new System.Drawing.Size(92, 32);
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
            // search_Btn
            // 
            this.search_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_Btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search_Btn.Location = new System.Drawing.Point(1137, 48);
            this.search_Btn.MinimumSize = new System.Drawing.Size(1, 1);
            this.search_Btn.Name = "search_Btn";
            this.search_Btn.Size = new System.Drawing.Size(83, 24);
            this.search_Btn.TabIndex = 4;
            this.search_Btn.Text = "搜索";
            this.search_Btn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search_Btn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.search_Btn.Click += new System.EventHandler(this.search_Btn_Click);
            // 
            // picHistory
            // 
            this.picHistory.FillColor = System.Drawing.Color.White;
            this.picHistory.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picHistory.Location = new System.Drawing.Point(4, 5);
            this.picHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picHistory.MinimumSize = new System.Drawing.Size(1, 1);
            this.picHistory.Name = "picHistory";
            this.picHistory.Padding = new System.Windows.Forms.Padding(2);
            this.picHistory.ShowText = false;
            this.picHistory.Size = new System.Drawing.Size(190, 490);
            this.picHistory.TabIndex = 3;
            this.picHistory.Text = "uiListBox1";
            this.picHistory.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.picHistory.ItemClick += new System.EventHandler(this.picHistory_ItemClick);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Transparent;
            this.leftPanel.Controls.Add(this.picHistory);
            this.leftPanel.Controls.Add(this.leftshow);
            this.leftPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftPanel.Location = new System.Drawing.Point(-190, 126);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.leftPanel.Size = new System.Drawing.Size(221, 500);
            this.leftPanel.TabIndex = 5;
            this.leftPanel.Text = null;
            this.leftPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // WallpaperLib
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.search_Btn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.picBox);
            this.MaximizeBox = false;
            this.Name = "WallpaperLib";
            this.Text = "本地壁纸";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIFlowLayoutPanel picBox;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UIButton importBtn;
        private Sunny.UI.UIButton search_Btn;
        private System.Windows.Forms.OpenFileDialog ofd;
        private Sunny.UI.UIListBox picHistory;
        private Sunny.UI.UIPanel leftPanel;
        private Sunny.UI.UIButton leftshow;
    }
}