using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace k_wallpaper
{
	class MyJsonHelper
	{

        public static List<CJson> Read_Json()
        {
                List<CJson> jlist = new List<CJson>();

            try
            {
                int i = 0;
                StreamReader reader = File.OpenText("MessageSaving.json");
                JsonTextReader jsonTextReader = new JsonTextReader(reader);
                JObject jsonObject = new JObject();
                jsonObject=(JObject)JToken.ReadFrom(jsonTextReader);
                var EasyNotes = jsonObject["EasyNote"];
                foreach (JObject a in EasyNotes)
                {
                    CJson cJson = new CJson();
                    dynamic stuff = JsonConvert.DeserializeObject(jsonObject.ToString());
                    cJson.title = stuff.EasyNote[i].title;
                    cJson.Date = stuff.EasyNote[i].Date;
                    cJson.Time = stuff.EasyNote[i].Time;
                    cJson.EventType = stuff.EasyNote[i].EventType;
                    cJson.Explaination = stuff.EasyNote[i].Explaination;
                    jlist.Add(cJson);
                    i++;
                }
                reader.Close();
                return jlist;
            }
            catch
            {
                
                MessageBox.Show("error");
                return null;
            }
        }
        public static void Write_Json(string title,string Date,string Time, string eventtype,string explaination)
        {
            try
            {
                string jsonString = File.ReadAllText("MessageSaving.json", Encoding.UTF8);
                JObject jsonObject = JObject.Parse(jsonString);
                JObject jobj = new JObject();
                jobj.Add(new JProperty("title", title));
                jobj.Add(new JProperty("Date", Date));
                jobj.Add(new JProperty("Time", Time));
                jobj.Add(new JProperty("EventType", eventtype));
                jobj.Add(new JProperty("Expaination", explaination));
                jsonObject["EasyNote"].Last.AddAfterSelf(jobj);
                string convertingString = Convert.ToString(jsonObject);
                File.WriteAllText("MessageSaving.json",convertingString);
            }
            catch
            {
                
                MessageBox.Show("error");
            }
        }

	}
}