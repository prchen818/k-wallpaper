using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Drawing;


namespace k_wallpaper
{
    public class wallpaper
    {
            public IntPtr Handle { get; private set; }

            public dynamic Window { get; set; }

            public Rectangle Fullscreen { get; }

            private string oldWallpaperFolder;

            private wallpapercore wallpaperCore;
        
            public wallpaper()
            {
                Fullscreen = util.GetFullscreen();
                oldWallpaperFolder = $"C:\\Users\\{Environment.UserName}\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\CachedFiles\\";
                util.SendMessage(util.FindWindow("Progman", null), 0x052C, 0, 0);
                util.EnumWindows(((tophandle, _) =>
                {
                    if (util.FindWindowEx(tophandle, IntPtr.Zero, "SHELLDLL_DefView", string.Empty) != IntPtr.Zero)
                    {
                        Handle = util.FindWindowEx(IntPtr.Zero, tophandle, "WorkerW", string.Empty);
                        return false;
                    }
                    return true;
                }), IntPtr.Zero);
                if (Handle == IntPtr.Zero)
                {
                    throw new startexception("未能找到壁纸层", "Wallpaper.Wallpaper");
                }

                   // SetWallpaper(@"..\..\102.jpg");
            }

            public void Close()
            {
                if (Window != null)
                {
                    Window.Close();
                    Window = null;
                }
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
                  
                }
                catch (Exception exception)
                {
                   
                }
            }

            public void SetWallpaper(string fullPath)
            {
                
                wallpaperCore = wallpapercore.GetWallpaperCore(this);
            }
        }
    }

