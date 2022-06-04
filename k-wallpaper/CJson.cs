using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_wallpaper
{
    public class CJson
    {

        public string title;
        public string Date;
        public string Time;
        public string EventType;
        public string Explaination; 
        public override string ToString()
        {
            return string.Format("title:{0},Date:{1},Time:{2},EventType:{3},Explaination:{4}", title, Date, Time, EventType, Explaination);
        }

    }
}
