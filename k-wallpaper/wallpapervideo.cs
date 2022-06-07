using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;

namespace k_wallpaper
{
    public class wallpapervideo : wallpapercore
    {
        public wallpapervideo(wallpaper wallpaper) : base(wallpaper)
        {
            try
            {
                util.TransformFromPixels(_wallpaper.Fullscreen.Width, _wallpaper.Fullscreen.Height, out int x, out int y);

                MediaElement Media = new MediaElement()
                {
                    LoadedBehavior = MediaState.Manual,
                    Width = x,
                    Height = y,
                    Stretch = Stretch.Fill,
                    Source = new Uri(Path.GetFullPath(wallpaper.path))
                };

                Media.MediaEnded += ((s, e) =>
                {
                    Media.Stop(); Media.Play();
                });

                _wallpaper.Window = new Window()
                {
                    ShowInTaskbar = false,
                    WindowStyle = WindowStyle.None,
                    ResizeMode = ResizeMode.NoResize,
                    IsTabStop = false,
                    Content = Media
                };

                _wallpaper.Window.Show();
                IntPtr WallpaperHandle = new WindowInteropHelper(_wallpaper.Window).Handle;
                util.SetParent(WallpaperHandle, _wallpaper.Handle);
                util.SetWindowLong(WallpaperHandle, util.WindowLongFlags.GWL_EXSTYLE, (int)util.WindowStylesEx.WS_EX_TOOLWINDOW);//WS_EX_TOOLWINDOW=128
                util.SetWindowPos(WallpaperHandle, IntPtr.Zero, 0, 0, _wallpaper.Fullscreen.Width, _wallpaper.Fullscreen.Height, util.SetWindowPosFlags.FrameChanged);

                Media.Play();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Data.ToString()}\n{exception.Message}\n{exception.Source}\n{exception.StackTrace}\n{exception.TargetSite}\n初始化视频壁纸失败!");
            }
        }
    }
}
