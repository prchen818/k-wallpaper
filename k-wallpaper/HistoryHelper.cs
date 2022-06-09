using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace k_wallpaper
{
    class HistoryHelper
    {
        public static List<string> Read_Json()
        {
            
            try
            {
                int i = 0;
                StreamReader reader = File.OpenText("WallpaperHistory.json");
                JsonTextReader jsonTextReader = new JsonTextReader(reader);
                JObject jsonObject = new JObject();
                jsonObject = (JObject)JToken.ReadFrom(jsonTextReader);
                var Path = jsonObject["path"];
                if(Path==null)
                {
                    reader.Close();
                    return new List<string>();
                }
                List<string> rep = Path.ToObject<List<string>>();
                reader.Close();
                return rep;
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void Write_Json(string js)
        {
            try
            {
                string jsonString = File.ReadAllText("WallpaperHistory.json", Encoding.UTF8);
                JObject jsonObject = JObject.Parse(jsonString);
                JObject jobj = new JObject();
               //防止重复写入
                if (jsonString.Contains(js))
                {
                    return;
                }
                jobj.Add(new JProperty(js));
            
                jsonObject["path"].Last.AddAfterSelf(js);
                string convertingString = Convert.ToString(jsonObject);
                File.WriteAllText("WallpaperHistory.json", convertingString);
            }
            catch
            {

                MessageBox.Show("error");
            }
        }

    }
}

