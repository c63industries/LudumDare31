using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace C63.LudumDare31.Game
{
    public static class Extensions
    {
        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 7;

        public static void ScrollToBottom(RichTextBox rtb)
        {
            SendMessage(rtb.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);
        }

        public static void ScrollToBottom(TextBox tb)
        {
            SendMessage(tb.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
    }
}
