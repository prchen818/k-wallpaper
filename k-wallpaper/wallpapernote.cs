using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace k_wallpaper
{
    public class wallpapernote : wallpaper
    {
        public wallpapernote() : base()
        {

            Window = new Form
            {
                Height = 40,
                Width = 310,
                ShowInTaskbar = false,
                FormBorderStyle = FormBorderStyle.None,
                AutoSize=true,
                
            };


            UITableLayoutPanel p = new UITableLayoutPanel()
            {
                Height = 200,
                Width = 310,
                AutoSize=true,
                AutoSizeMode=AutoSizeMode.GrowAndShrink,
                BackColor = Color.Transparent
            };
            NoteMain.load(p);

            Window.Controls.Add(p);



            Window.Show();
            util.SetParent(Window.Handle, Handle);
            util.SetWindowLong(Window.Handle, util.WindowLongFlags.GWL_EXSTYLE, (int)util.WindowStylesEx.WS_EX_TOOLWINDOW | (int)util.WindowStylesEx.WS_EX_NOACTIVATE);
            util.SetWindowPos(Window.Handle, IntPtr.Zero, 1600, 50, 310, 500, util.SetWindowPosFlags.NoSize);


        }

    }
}
