using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace k_wallpaper
{
    public abstract class wallpapercore
    {
        public static  wallpaper _wallpaper;

       // public string pathway;

        private static IEnumerable<string> imgExtentions = new string[] { ".jpg", ".bmp", ".png" ,".jpeg"};

        static IEnumerable<string> vedioExtentions = new string[] { ".mp4", ".mov", "avi", "mkv", "3gp", "wmv", "mpg" };

        static IEnumerable<string> webExtentions = new string[] { ".html", ".htm" };

        static IEnumerable<string> processExtentions = new string[] { ".exe" };
        public wallpapercore(wallpaper wallpaper)
        {
            _wallpaper = wallpaper;
        }
        public static void Close()
        {
            _wallpaper.Close();
           _wallpaper.ToOldWallpaper();
           // _wallpaper.SetWallpaper(p);
        }
        public static wallpapercore GetWallpaperCore(wallpaper wallpaper)
        {
            var extention = Path.GetExtension(wallpaper.path).ToLower();
            if (imgExtentions.Contains(extention))
            {
                return new wallpaperimg(wallpaper);
            }
            else if (vedioExtentions.Contains(extention))
            {
               return new wallpapervideo(wallpaper);
            }
           //
            else
            {
                throw new ArgumentException("无效的格式", $"文件后缀为{extention}");
            }
        }
    }
}
   



