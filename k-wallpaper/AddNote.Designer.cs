
namespace k_wallpaper
{
    partial class AddNote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.Da = new Sunny.UI.UIDatePicker();
            this.Ti = new Sunny.UI.UITimePicker();
            this.EventNameBox = new Sunny.UI.UITextBox();
            this.TypeBox = new Sunny.UI.UIComboBox();
            this.ExplainationBox = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "事项标题：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "事项类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "事项说明：";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(200, 450);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 4;
            this.uiButton1.Text = "添加";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // Da
            // 
            this.Da.FillColor = System.Drawing.Color.White;
            this.Da.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Da.Location = new System.Drawing.Point(150, 127);
            this.Da.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Da.MaxLength = 10;
            this.Da.MinimumSize = new System.Drawing.Size(63, 0);
            this.Da.Name = "Da";
            this.Da.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Da.Size = new System.Drawing.Size(117, 29);
            this.Da.SymbolDropDown = 61555;
            this.Da.SymbolNormal = 61555;
            this.Da.TabIndex = 5;
            this.Da.Text = "2022-05-28";
            this.Da.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Da.Value = new System.DateTime(2022, 5, 28, 9, 52, 17, 294);
            this.Da.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Ti
            // 
            this.Ti.FillColor = System.Drawing.Color.White;
            this.Ti.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ti.Location = new System.Drawing.Point(287, 127);
            this.Ti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ti.MaxLength = 5;
            this.Ti.MinimumSize = new System.Drawing.Size(63, 0);
            this.Ti.Name = "Ti";
            this.Ti.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Ti.Size = new System.Drawing.Size(74, 29);
            this.Ti.SymbolDropDown = 61555;
            this.Ti.SymbolNormal = 61555;
            this.Ti.TabIndex = 7;
            this.Ti.Text = "10:11";
            this.Ti.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ti.TimeFormat = "HH:mm";
            this.Ti.Value = new System.DateTime(2022, 5, 28, 10, 11, 34, 940);
            this.Ti.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // EventNameBox
            // 
            this.EventNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EventNameBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EventNameBox.Location = new System.Drawing.Point(150, 86);
            this.EventNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EventNameBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.EventNameBox.Name = "EventNameBox";
            this.EventNameBox.ShowText = false;
            this.EventNameBox.Size = new System.Drawing.Size(150, 29);
            this.EventNameBox.TabIndex = 8;
            this.EventNameBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.EventNameBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // TypeBox
            // 
            this.TypeBox.DataSource = null;
            this.TypeBox.FillColor = System.Drawing.Color.White;
            this.TypeBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TypeBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TypeBox.Location = new System.Drawing.Point(150, 178);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TypeBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.TypeBox.Size = new System.Drawing.Size(117, 29);
            this.TypeBox.TabIndex = 9;
            this.TypeBox.Text = "--请选择--";
            this.TypeBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TypeBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ExplainationBox
            // 
            this.ExplainationBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExplainationBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExplainationBox.Location = new System.Drawing.Point(150, 228);
            this.ExplainationBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExplainationBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.ExplainationBox.Multiline = true;
            this.ExplainationBox.Name = "ExplainationBox";
            this.ExplainationBox.ShowText = false;
            this.ExplainationBox.Size = new System.Drawing.Size(257, 195);
            this.ExplainationBox.TabIndex = 10;
            this.ExplainationBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExplainationBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AddNote
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(496, 527);
            this.Controls.Add(this.ExplainationBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.EventNameBox);
            this.Controls.Add(this.Ti);
            this.Controls.Add(this.Da);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNote";
            this.Text = "AddNote";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIDatePicker Da;
        private Sunny.UI.UITimePicker Ti;
        private Sunny.UI.UITextBox EventNameBox;
        private Sunny.UI.UIComboBox TypeBox;
        private Sunny.UI.UITextBox ExplainationBox;
    }
}