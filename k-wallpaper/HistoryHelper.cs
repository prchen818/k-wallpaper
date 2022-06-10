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
            catch(FileNotFoundException fe)
            {
                FileStream f = File.Create("WallpaperHistory.json");
                f.Close();
                JObject tmp = new JObject();
                tmp.Add(new JProperty("path", new List<string>(0)));
                string s = Convert.ToString(tmp);
                File.WriteAllText("WallpaperHistory.json", s);
                return null;
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
               //防止重复写入
                if (jsonString.Contains(js))
                {
                    return;
                }

                if (jsonObject["path"].Last != null)
                {
                    jsonObject["path"].Last.AddAfterSelf(js);
                }
                else
                {
                    List<string> l = new List<string>();
                    l.Add(js);
                    jsonObject.ReplaceAll(new JProperty("path",l));
                }

                string convertingString = Convert.ToString(jsonObject);
                File.WriteAllText("WallpaperHistory.json", convertingString);
            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

    }
}

