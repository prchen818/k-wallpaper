using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunny.UI;

namespace k_wallpaper
{

    public partial class NoteMain : UIForm
    {
        private void Loading()
        {
            List<CJson> cJsons = check(MyJsonHelper.Read_Json());
            for (int i = 0; i < cJsons.Count; i++)
            {
                DailyDisplay test = new DailyDisplay(cJsons[i].title, cJsons[i].EventType, cJsons[i].Date + cJsons[i].Time);
                uiTableLayoutPanel1.Controls.Add(test);
            }
        }
        public NoteMain()
        {
            InitializeComponent();
            Loading();
        }

        public NoteMain(int show)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Opacity = 0.7;
            this.ControlBox = false;
            this.ShowTitle = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Loading();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddNote add1 = new AddNote();
            add1.MyEvent += new AddNote.MyDelegate(Add_MyEvent);
            add1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckAll checkAll = new CheckAll();
            checkAll.Show();
        }

        public List<CJson> check(List<CJson> clist)
        {
            List<CJson> todaylist = new List<CJson>();
            for(int i=0;i<clist.Count;i++)
            {
                if (clist[i].Date == System.DateTime.Now.ToString("yyyy-MM-dd"))
                {
                    todaylist.Add(clist[i]);
                }
            }
            return todaylist;
        }

        void Add_MyEvent()
        {
            uiTableLayoutPanel1.Controls.Clear();
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.ColumnCount = 1;
            Loading();
        }

       
    }
}
