using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Sunny.UI;


namespace k_wallpaper
{
    public partial class DailyDisplay : UIPanel
    {
        public DailyDisplay()
        {
            InitializeComponent();
        }

        public DailyDisplay(string Event,string type,string time)
        {
            InitializeComponent();
            this.Eventlabel.Text = Event;
            this.Time.Text = time;
            this.Type.Text = type;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                Eventlabel.ForeColor = Color.Gray;
                Time.ForeColor = Color.Gray;
                Type.ForeColor = Color.Gray;
            }
            else
            {
                Eventlabel.ForeColor = Color.Black;
                Time.ForeColor = Color.Black;
                Type.ForeColor = Color.Black;
            }

        }
    }
}
