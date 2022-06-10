using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Markup;
using System.Runtime.Serialization;
using System.Media;
using System.Windows.Interop;
using Microsoft.WindowsAPICodePack.Shell;

namespace k_wallpaper
{


    internal class util
    {
        /// <summary>
        /// 用于获取缩略图
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public static Bitmap GetThumbnailByPath(string filePath)
        {
            ShellFile shellFile = ShellFile.FromFilePath(filePath);
            Bitmap thumbnail = shellFile.Thumbnail.ExtraLargeBitmap;
            return thumbnail;
        }


        //获取当前系统壁纸文件路径
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SystemParametersInfo(uint uAction, uint uParam, StringBuilder lpvParam, uint init);
        public const uint SPI_GETDESKWALLPAPER = 0x0073;


        /// <summary>
        /// 获取窗体的句柄函数
        /// </summary>
        /// <param name="lpClassName">窗口类名</param>
        /// <param name="lpWindowName">窗口标题名</param>
        /// <returns>返回句柄</returns>
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]

        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwndParent">要查找子窗口的父窗口句柄</param>
        /// <param name="hwndChildAfter">子窗口句柄。查找从在Z序中的下一个子窗口开始。子窗口必须为hwndPareRt窗口的直接子窗口而非后代窗口。如果HwndChildAfter为NULL，查找从hwndParent的第一个子窗口开始。如果hwndParent 和 hwndChildAfter同时为NULL，则函数查找所有的顶层窗口及消息窗口。</param>
        /// <param name="lpszClass">指向一个指定了类名的空结束字符串，或一个标识类名字符串的成员的指针。</param>
        /// <param name="lpszWindow">指向一个指定了窗口名（窗口标题）的空结束字符串。</param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll")]
        public static extern bool EnumWindows(EnumWindowsProc proc, IntPtr lParam);

        public delegate bool EnumWindowsProc(IntPtr hwnd, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hwnd, IntPtr parentHwnd);
        public enum SystemMetricsFlags
        {
            SM_CXSCREEN = 0,
            SM_CYSCREEN = 1
        };
        //获取系统桌面尺寸

        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetrics(SystemMetricsFlags flags);

        //转为像素
        public static void TransformFromPixels(int pxX, int pxY, out int X, out int Y)
        {
            System.Windows.Media.Matrix matrix = new HwndSource(new HwndSourceParameters()).CompositionTarget.TransformToDevice;
            X = (int)(pxX / matrix.M11);
            Y = (int)(pxY / matrix.M22);
        }

    /*    public static Point TransformToPixels(int X, int Y)
        {
            System.Windows.Media.Matrix Matrix = new HwndSource(new HwndSourceParameters()).CompositionTarget.TransformToDevice;
            return new Point((int)(X * Matrix.M11), (int)(Y * Matrix.M22));
        }*/
        public static void TransformToPixels(int X, int Y, out int pxX, out int pxY)
        {
            System.Windows.Media.Matrix Matrix = new HwndSource(new HwndSourceParameters()).CompositionTarget.TransformToDevice;
            pxX = (int)(X * Matrix.M11);
            pxY = (int)(Y * Matrix.M22);
        }

     /*   [DllImport("user32.dll", EntryPoint = "GetWindowDC")]
        public static extern IntPtr GetWindowDC(Int32 ptr);*/

        public static Rectangle GetFullscreen()
        {
            int X = GetSystemMetrics(SystemMetricsFlags.SM_CXSCREEN);
            int Y = GetSystemMetrics(SystemMetricsFlags.SM_CYSCREEN);
            if (X % 10 == 0 && Y % 10 == 0)
            {
                return new Rectangle(0, 0, X, Y);
            }
            else
            {
                TransformToPixels(X, Y, out int x, out int y);
                return new Rectangle(0, 0, x, y);
            }
       
        }
        //该函数将指定的消息发送到一个或多个窗口。此函数为指定的窗口调用窗口程序，直到窗口程序处理完消息再返回。
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);


        [DllImport("user32.dll", EntryPoint = "GetDC")]
        public static extern IntPtr GetDC(IntPtr ptr);

        public enum WindowLongFlags : int
        {
            //窗口样式
            GWL_EXSTYLE = -20,
            GWLP_HINSTANCE = -6,
            GWLP_HWNDPARENT = -8,
            GWL_ID = -12,
            GWL_STYLE = -16,
            GWL_USERDATA = -21,
            GWL_WNDPROC = -4,
            DWLP_USER = 0x8,
            DWLP_MSGRESULT = 0x0,
            DWLP_DLGPROC = 0x4
        }

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, WindowLongFlags nIndex, int dwNewLong);

        public enum SetWindowPosFlags : uint
        {
            /// <summary>If the calling thread and the thread that owns the window are attached to different input queues,
            /// the system posts the request to the thread that owns the window. This prevents the calling thread from
            /// blocking its execution while other threads process the request.</summary>
            /// <remarks>SWP_ASYNCWINDOWPOS</remarks>
            AsynWindowPos = 0x4000,

            /// <summary>Prevents generation of the WM_SYNCPAINT message.</summary>
            /// <remarks>SWP_DEFERERASE</remarks>
            DeferErase = 0x2000,

            /// <summary>Draws a frame (defined in the window's class description) around the window.</summary>
            /// <remarks>SWP_DRAWFRAME</remarks>
            DrawFrame = 0x0020,

            /// <summary>Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to
            /// the window, even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE
            /// is sent only when the window's size is being changed.</summary>
            /// <remarks>SWP_FRAMECHANGED</remarks>
            FrameChanged = 0x0020,

            /// <summary>Hides the window.</summary>
            /// <remarks>SWP_HIDEWINDOW</remarks>
            HideWindow = 0x0080,

            /// <summary>Does not activate the window. If this flag is not set, the window is activated and moved to the
            /// top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter
            /// parameter).</summary>
            /// <remarks>SWP_NOACTIVATE</remarks>
            NoActivate = 0x0010,

            /// <summary>Discards the entire contents of the client area. If this flag is not specified, the valid
            /// contents of the client area are saved and copied back into the client area after the window is sized or
            /// repositioned.</summary>
            /// <remarks>SWP_NOCOPYBITS</remarks>
            NoCopyBits = 0x0100,

            /// <summary>Retains the current position (ignores X and Y parameters).</summary>
            /// <remarks>SWP_NOMOVE</remarks>
            NoMove = 0x0002,

            /// <summary>Does not change the owner window's position in the Z order.</summary>
            /// <remarks>SWP_NOOWNERZORDER</remarks>
            NoOwnerZOrder = 0x0200,

            /// <summary>Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to
            /// the client area, the nonclient area (including the title bar and scroll bars), and any part of the parent
            /// window uncovered as a result of the window being moved. When this flag is set, the application must
            /// explicitly invalidate or redraw any parts of the window and parent window that need redrawing.</summary>
            /// <remarks>SWP_NOREDRAW</remarks>
            NoRedraw = 0x0008,

            /// <summary>Same as the SWP_NOOWNERZORDER flag.</summary>
            /// <remarks>SWP_NOREPOSITION</remarks>
            NoReposition = 0x0200,

            /// <summary>Prevents the window from receiving the WM_WINDOWPOSCHANGING message.</summary>
            /// <remarks>SWP_NOSENDCHANGING</remarks>
            NoSendChanging = 0x0400,

            /// <summary>Retains the current size (ignores the cx and cy parameters).</summary>
            /// <remarks>SWP_NOSIZE</remarks>
            NoSize = 0x0001,

            /// <summary>Retains the current Z order (ignores the hWndInsertAfter parameter).</summary>
            /// <remarks>SWP_NOZORDER</remarks>
            NoZOrder = 0x0004,

            /// <summary>Displays the window.</summary>
            /// <remarks>SWP_SHOWWINDOW</remarks>
            ShowWindow = 0x0040
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        //修改窗口大小尺寸
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

        public enum WindowStylesEx : uint
        {
            /// <summary>
            /// Specifies that a window created with this style accepts drag-drop files.
            /// </summary>
            WS_EX_ACCEPTFILES = 0x00000010,

            /// <summary>
            /// Forces a top-level window onto the taskbar when the window is visible.
            /// </summary>
            WS_EX_APPWINDOW = 0x00040000,

            /// <summary>
            /// Specifies that a window has a border with a sunken edge.
            /// </summary>
            WS_EX_CLIENTEDGE = 0x00000200,

            /// <summary>
            /// Windows XP: Paints all descendants of a window in bottom-to-top painting order using double-buffering. For more information, see Remarks. This cannot be used if the window has a class style of either CS_OWNDC or CS_CLASSDC.
            /// </summary>
            WS_EX_COMPOSITED = 0x02000000,

            /// <summary>
            /// Includes a question mark in the title bar of the window. When the user clicks the question mark, the cursor changes to a question mark with a pointer. If the user then clicks a child window, the child receives a WM_HELP message. The child window should pass the message to the parent window procedure, which should call the WinHelp function using the HELP_WM_HELP command. The Help application displays a pop-up window that typically contains help for the child window.
            /// WS_EX_CONTEXTHELP cannot be used with the WS_MAXIMIZEBOX or WS_MINIMIZEBOX styles.
            /// </summary>
            WS_EX_CONTEXTHELP = 0x00000400,

            /// <summary>
            /// The window itself contains child windows that should take part in dialog box navigation. If this style is specified, the dialog manager recurses into children of this window when performing navigation operations such as handling the TAB key, an arrow key, or a keyboard mnemonic.
            /// </summary>
            WS_EX_CONTROLPARENT = 0x00010000,

            /// <summary>
            /// Creates a window that has a double border; the window can, optionally, be created with a title bar by specifying the WS_CAPTION style in the dwStyle parameter.
            /// </summary>
            WS_EX_DLGMODALFRAME = 0x00000001,

            /// <summary>
            /// Windows 2000/XP: Creates a layered window. Note that this cannot be used for child windows. Also, this cannot be used if the window has a class style of either CS_OWNDC or CS_CLASSDC.
            /// </summary>
            WS_EX_LAYERED = 0x00080000,

            /// <summary>
            /// Arabic and Hebrew versions of Windows 98/Me, Windows 2000/XP: Creates a window whose horizontal origin is on the right edge. Increasing horizontal values advance to the left.
            /// </summary>
            WS_EX_LAYOUTRTL = 0x00400000,

            /// <summary>
            /// Creates a window that has generic left-aligned properties. This is the default.
            /// </summary>
            WS_EX_LEFT = 0x00000000,

            /// <summary>
            /// If the shell language is Hebrew, Arabic, or another language that supports reading order alignment, the vertical scroll bar (if present) is to the left of the client area. For other languages, the style is ignored.
            /// </summary>
            WS_EX_LEFTSCROLLBAR = 0x00004000,

            /// <summary>
            /// The window text is displayed using left-to-right reading-order properties. This is the default.
            /// </summary>
            WS_EX_LTRREADING = 0x00000000,

            /// <summary>
            /// Creates a multiple-document interface (MDI) child window.
            /// </summary>
            WS_EX_MDICHILD = 0x00000040,

            /// <summary>
            /// Windows 2000/XP: A top-level window created with this style does not become the foreground window when the user clicks it. The system does not bring this window to the foreground when the user minimizes or closes the foreground window.
            /// To activate the window, use the SetActiveWindow or SetForegroundWindow function.
            /// The window does not appear on the taskbar by default. To force the window to appear on the taskbar, use the WS_EX_APPWINDOW style.
            /// </summary>
            WS_EX_NOACTIVATE = 0x08000000,

            /// <summary>
            /// Windows 2000/XP: A window created with this style does not pass its window layout to its child windows.
            /// </summary>
            WS_EX_NOINHERITLAYOUT = 0x00100000,

            /// <summary>
            /// Specifies that a child window created with this style does not send the WM_PARENTNOTIFY message to its parent window when it is created or destroyed.
            /// </summary>
            WS_EX_NOPARENTNOTIFY = 0x00000004,

            /// <summary>
            /// Combines the WS_EX_CLIENTEDGE and WS_EX_WINDOWEDGE styles.
            /// </summary>
            WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE,

            /// <summary>
            /// Combines the WS_EX_WINDOWEDGE, WS_EX_TOOLWINDOW, and WS_EX_TOPMOST styles.
            /// </summary>
            WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST,

            /// <summary>
            /// The window has generic "right-aligned" properties. This depends on the window class. This style has an effect only if the shell language is Hebrew, Arabic, or another language that supports reading-order alignment; otherwise, the style is ignored.
            /// Using the WS_EX_RIGHT style for static or edit controls has the same effect as using the SS_RIGHT or ES_RIGHT style, respectively. Using this style with button controls has the same effect as using BS_RIGHT and BS_RIGHTBUTTON styles.
            /// </summary>
            WS_EX_RIGHT = 0x00001000,

            /// <summary>
            /// Vertical scroll bar (if present) is to the right of the client area. This is the default.
            /// </summary>
            WS_EX_RIGHTSCROLLBAR = 0x00000000,

            /// <summary>
            /// If the shell language is Hebrew, Arabic, or another language that supports reading-order alignment, the window text is displayed using right-to-left reading-order properties. For other languages, the style is ignored.
            /// </summary>
            WS_EX_RTLREADING = 0x00002000,

            /// <summary>
            /// Creates a window with a three-dimensional border style intended to be used for items that do not accept user input.
            /// </summary>
            WS_EX_STATICEDGE = 0x00020000,

            /// <summary>
            /// Creates a tool window; that is, a window intended to be used as a floating toolbar. A tool window has a title bar that is shorter than a normal title bar, and the window title is drawn using a smaller font. A tool window does not appear in the taskbar or in the dialog that appears when the user presses ALT+TAB. If a tool window has a system menu, its icon is not displayed on the title bar. However, you can display the system menu by right-clicking or by typing ALT+SPACE.
            /// </summary>
            WS_EX_TOOLWINDOW = 0x00000080,

            /// <summary>
            /// Specifies that a window created with this style should be placed above all non-topmost windows and should stay above them, even when the window is deactivated. To add or remove this style, use the SetWindowPos function.
            /// </summary>
            WS_EX_TOPMOST = 0x00000008,

            /// <summary>
            /// Specifies that a window created with this style should not be painted until siblings beneath the window (that were created by the same thread) have been painted. The window appears transparent because the bits of underlying sibling windows have already been painted.
            /// To achieve transparency without these restrictions, use the SetWindowRgn function.
            /// </summary>
            WS_EX_TRANSPARENT = 0x00000020,

            /// <summary>
            /// Specifies that a window has a border with a raised edge.
            /// </summary>
            WS_EX_WINDOWEDGE = 0x00000100
        }
        public class StartException : Exception
        {
            /// <summary>
            /// 导致异常的函数名
            /// </summary>
            public string Function { get; set; }

            public StartException()
            {
            }

            public StartException(string message, string function) : base(message)
            {
                Function = function;
            }

            public StartException(string message) : base(message)
            {
            }

            public StartException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected StartException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
       
    }
}
