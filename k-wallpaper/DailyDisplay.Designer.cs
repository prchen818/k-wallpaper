
namespace k_wallpaper
{
    partial class DailyDisplay
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
            this.Eventlabel = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Eventlabel
            // 
            this.Eventlabel.AutoSize = true;
            this.Eventlabel.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Eventlabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eventlabel.Location = new System.Drawing.Point(24, 5);
            this.Eventlabel.Name = "Eventlabel";
            this.Eventlabel.Size = new System.Drawing.Size(58, 29);
            this.Eventlabel.TabIndex = 0;
            this.Eventlabel.Text = "aaa";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(24, 40);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 21);
            this.Time.TabIndex = 1;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(148, 13);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(0, 21);
            this.Type.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DailyDisplay
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Eventlabel);
            this.Name = "DailyDisplay";
            this.Size = new System.Drawing.Size(300, 69);
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label Eventlabel;
        protected System.Windows.Forms.Label Time;
        protected System.Windows.Forms.Label Type;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}