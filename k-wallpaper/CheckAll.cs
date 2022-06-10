using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunny.UI;

namespace k_wallpaper
{
    public partial class CheckAll : UIForm
    {
        public CheckAll()
        {
            InitializeComponent();
            //uiDataGridView1.DataSource = new BindingList<CJson>(MyJsonHelper.Read_Json());
            //uiDataGridView1.AutoGenerateColumns = false;

            read();
            
        }

        void read()
        {
            List<CJson> cJsons = MyJsonHelper.Read_Json();

            //uiDataGridView1.DataSource = new BindingList<CJson>(cJsons);
            
            for (int i = 0; i < cJsons.Count; i++)
            {   
                if(cJsons[i].title==null)
                {
                    continue;
                }
                int row1 = this.uiDataGridView1.Rows.Add();
                this.uiDataGridView1.Rows[row1].Cells[0].Value = cJsons[i].title;
                this.uiDataGridView1.Rows[row1].Cells[1].Value = cJsons[i].Date;
                this.uiDataGridView1.Rows[row1].Cells[2].Value = cJsons[i].Time;
                this.uiDataGridView1.Rows[row1].Cells[3].Value = cJsons[i].EventType;
                this.uiDataGridView1.Rows[row1].Cells[4].Value = cJsons[i].Explaination;

            }
            
        }


    }
}
