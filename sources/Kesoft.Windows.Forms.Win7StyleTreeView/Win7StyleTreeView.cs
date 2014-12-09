using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Kesoft.Windows.Forms.Win7StyleTreeView
{
    /// <summary>
    /// Windows 7 style TreeView control.
    /// </summary>
    public partial class Win7StyleTreeView : TreeView
    {
        public Win7StyleTreeView()
        {
            InitializeComponent();
            Helper.ApplyTreeViewThemeStyles(this);
        }

        public Win7StyleTreeView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Helper.ApplyTreeViewThemeStyles(this);
        }


        internal class Helper
        {
            private const int TvFirst = 0x1100;
            private const int TvmSetextendedstyle = TvFirst + 44;
            private const int TvmGetextendedstyle = TvFirst + 45;
            private const int TvsExFadeinoutexpandos = 0x0040;
            private const int TvsExDoublebuffer = 0x0004;

            [DllImport("uxtheme.dll", CharSet = CharSet.Auto)]
            private static extern int SetWindowTheme(IntPtr hWnd, string subAppName, string subIdList);

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

            private static int TreeViewGetExtendedStyle(IntPtr handle)
            {
                var ptr = SendMessage(handle, TvmGetextendedstyle, IntPtr.Zero, IntPtr.Zero);
                return ptr.ToInt32();
            }

            private static void TreeViewSetExtendedStyle(IntPtr handle, int extendedStyle, int mask)
            {
                SendMessage(handle, TvmSetextendedstyle, new IntPtr(mask), new IntPtr(extendedStyle));
            }

            public static void ApplyTreeViewThemeStyles(TreeView treeView)
            {
                if (treeView == null)
                {
                    throw new ArgumentNullException("treeView");
                }

                treeView.HotTracking = true;
                treeView.ShowLines = false;

                var hwnd = treeView.Handle;
                SetWindowTheme(hwnd, "Explorer", null);
                var exstyle = TreeViewGetExtendedStyle(hwnd);
                exstyle |= TvsExDoublebuffer | TvsExFadeinoutexpandos;
                TreeViewSetExtendedStyle(hwnd, exstyle, 0);
            }
        }
    }
}