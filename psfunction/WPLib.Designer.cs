namespace psfunction
{
    partial class WPLib
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
            this.picBox = new System.Windows.Forms.FlowLayoutPanel();
            this.importBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.AutoSize = true;
            this.picBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.picBox.Location = new System.Drawing.Point(65, 91);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(0, 0);
            this.picBox.TabIndex = 0;
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(65, 42);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(94, 29);
            this.importBtn.TabIndex = 1;
            this.importBtn.Text = "导入";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(165, 42);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(94, 29);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "刷新";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // WPLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.picBox);
            this.Name = "WPLib";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel picBox;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}