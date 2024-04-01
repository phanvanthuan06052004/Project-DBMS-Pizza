using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace daidi
{
    public static class mdiProperties
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwLong);
        [DllImport("user32.dll")]
        private static extern int SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int X, int T, int cx, int cy, uint uFlags);


        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0X200;
        private const uint SWP_NOSIZE = 0X0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOZORDER = 0X0004;
        private const uint SWO_NOACTIVATE = 0X0010;
        private const uint SWP_FRAMECHANGED = 0X0020;
        private const uint SWO_NOOWNERZODER = 0X0200;

        public static bool SetBevel (this Form form, bool show)
        {
            foreach (Control control in form.Controls)
            {
                MdiClient client = control as MdiClient;
                if (client != null)
                {
                    int windowLong = GetWindowLong(control.Handle, GWL_EXSTYLE);
                    if (show)
                    {
                        windowLong |= WS_EX_CLIENTEDGE;
                    }
                    else
                    {
                        windowLong &= WS_EX_CLIENTEDGE;
                    }
                    SetWindowLong(control.Handle, GWL_EXSTYLE, windowLong);
                    SetWindowPos(control.Handle, IntPtr.Zero, 0, 0, 0, 0, SWO_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWO_NOOWNERZODER | SWP_FRAMECHANGED);
                    return true;
                }
            }
            return false;
        }
    }
}
