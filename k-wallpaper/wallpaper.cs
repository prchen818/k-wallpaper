using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Drawing;
using Sunny.UI;


namespace k_wallpaper
{
    public class wallpaper
    {
        public IntPtr Handle { get; private set; }

        public dynamic Window { get; set; }

        public Rectangle Fullscreen { get; }

        public string path;

        private string oldWallpaperFolder;

        private wallpapercore wallpaperCore;

        private wallpapernote _wallpapernote;

        public wallpaper()
        {
            Fullscreen = util.GetFullscreen();
            oldWallpaperFolder = $"C:\\Users\\{Environment.UserName}\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles\\";
            //生成WorkerW窗口
            util.SendMessage(util.FindWindow("Progman", null), 0x052C, 0, 0);
            //遍历顶级窗口
            util.EnumWindows(((tophandle, _) =>
            {
                // 找到包含 SHELLDLL_DefView 这个窗口句柄的 WorkerW
                if (util.FindWindowEx(tophandle, IntPtr.Zero, "SHELLDLL_DefView", string.Empty) != IntPtr.Zero)
                {
                    //  找到当前 WorkerW 窗口的，后一个 WorkerW 窗口。
                    Handle = util.FindWindowEx(IntPtr.Zero, tophandle, "WorkerW", string.Empty);
                    return false;
                }
                return true;
            }), IntPtr.Zero);
            if (Handle == IntPtr.Zero)
            {
                throw new startexception("未能找到壁纸层", "Wallpaper.Wallpaper");
            }

        }

        public void Close()
        {
            if (Window != null)
            {
                Window.Close();
                Window = null;
            }
            if (_wallpapernote != null)
            {
                _wallpapernote.Close();
                _wallpapernote = null;
            }
        }

        public void SetWallpaper(string fullPath)
        {
            path = fullPath;
            wallpapercore.Close();
            wallpaperCore = wallpapercore.GetWallpaperCore(this);

            if (_wallpapernote != null)
            {
                _wallpapernote.Close();
            }
            _wallpapernote = new wallpapernote();

/*            UITableLayoutPanel p = new UITableLayoutPanel();
            NoteMain.load(p);
            wallpapercore._wallpaper.Window.Controls.Add(p);
            wallpapercore._wallpaper.Window.Controls.Find(p).BringToFront();*/


        }

        public void ToOldWallpaper()
        {
            try
            {
                foreach (var file in new DirectoryInfo(oldWallpaperFolder).GetFiles())
                {
                    if (file.Name.Contains(Fullscreen.Height.ToString()) && file.Name.Contains(Fullscreen.Width.ToString()))
                    {
                        
                        Graphics.FromHdc(util.GetDC(Handle)).DrawImage(Image.FromFile(file.FullName), Fullscreen);
                        break;
                    }
                }
            }
                   
            catch (FileNotFoundException exception)
            {
                MessageBox.Show($"{exception.Data.ToString()}\n{exception.Message}\n{exception.Source}\n{exception.StackTrace}\n{exception.TargetSite}\n很抱歉, 我们未能找到您原来的壁纸, 请手动恢复");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Data.ToString()}\n{exception.Message}\n{exception.Source}\n{exception.StackTrace}\n{exception.TargetSite}\n很抱歉,在应用原壁纸时出现异常!");
            }
        }

    }
}

