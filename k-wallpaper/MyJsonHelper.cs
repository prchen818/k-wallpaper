using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ThirdParty.Json.LitJson;

namespace k_wallpaper
{
	class MyJsonHelper
	{

        public static List<CJson> Read_Json()
        {
                List<CJson> jlist = new List<CJson>();
                StreamReader reader;
            try
            {
                int i = 0;
                if(File.Exists("MessageSaving.json"))
                {
                    reader = File.OpenText("MessageSaving.json");

                }
                else
                {
                    
                    string json = JsonMapper.ToJson(new CJson());
                    CJson cJson = new CJson();
                    StreamWriter sw = new StreamWriter("MessageSaving.json");
                    sw.Write("{" + "\"EasyNote\":" + "[{}]}");
                    sw.Close(); 
                    MyJsonHelper.Write_Json(cJson.title,cJson.Date,cJson.Time,cJson.EventType,cJson.Explaination);
                    reader = File.OpenText("MessageSaving.json");
                }
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
            catch(Exception ex)
            {
                
                
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
                jobj.Add(new JProperty("Explaination", explaination));
                jsonObject["EasyNote"].Last.AddAfterSelf(jobj);
                string convertingString = Convert.ToString(jsonObject);
                File.WriteAllText("MessageSaving.json",convertingString);
            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

	}
}