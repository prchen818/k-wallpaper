using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_wallpaper
{
    public class wallpaperimg:wallpapercore
    {
        public wallpaperimg(wallpaper wallpaper) :base(wallpaper)
        {
            
            _wallpaper.Window = new Form
            {
                Height = _wallpaper.Fullscreen.Height,
                Width = _wallpaper.Fullscreen.Width,
                ShowInTaskbar = false,
                FormBorderStyle = FormBorderStyle.None,
            };

            _wallpaper.Window.Controls.Add(new PictureBox()
            {
                ImageLocation =wallpaper.path,
                Left = 0,
                Top = 0,
                Height = _wallpaper.Fullscreen.Height,
                Width = _wallpaper.Fullscreen.Width,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage
            });

            _wallpaper.Window.Show();
            util.SetParent(_wallpaper.Window.Handle, _wallpaper.Handle);
            util.SetWindowLong(_wallpaper.Window.Handle, util.WindowLongFlags.GWL_EXSTYLE, (int)util.WindowStylesEx.WS_EX_TOOLWINDOW | (int)util.WindowStylesEx.WS_EX_NOACTIVATE);
            util.SetWindowPos(_wallpaper.Window.Handle, IntPtr.Zero, 0, 0, _wallpaper.Fullscreen.Width, _wallpaper.Fullscreen.Height, util.SetWindowPosFlags.FrameChanged);


        }
        
    }
}
