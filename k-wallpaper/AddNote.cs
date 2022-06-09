using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunny.UI;
using System.Configuration;
using System.Collections;

namespace k_wallpaper
{
    public partial class AddNote : UIForm
    {
        static IList<string> infoList = new List<string>() { "工作", "学习", "生活" };

        private void bindCbox()
        {
            TypeBox.DataSource = infoList;
        }
        private void inittime()
        {
            Ti.Text=System.DateTime.Now.ToString("t");
            Da.Text= System.DateTime.Now.ToString("yyyy-MM-dd");
        }
        public AddNote()
        {
            InitializeComponent();
            bindCbox();
            inittime();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            //ConfigurationManager.AppSettings
            if (EventNameBox.Text == "")
            {
                UIMessageBox.Show("事件名不能为空");

            }
            else
            {
                MyJsonHelper.Write_Json(EventNameBox.Text, Da.Text, Ti.Text, TypeBox.Text, ExplainationBox.Text);
                this.Dispose();

            }
            if (MyEvent != null)
                MyEvent();

        }
        public delegate void MyDelegate();

        public event MyDelegate MyEvent;


    }
}
