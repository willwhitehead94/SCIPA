using System;
using System.Windows.Forms;

namespace SCIPA.UI.HMI
{
    /// <summary>
    /// Class implements and modifies C# code found on StackOverflow
    /// at the following URL:
    /// 
    /// http://stackoverflow.com/questions/4912354/how-do-i-create-a-tabcontrol-with-no-tab-headers
    /// See the chosen answer, by Cody Gray. Originally from Dot Net Thoughts (no longer active).
    /// </summary>
    public class CustomTabControl : TabControl
{
        /// <summary>
        /// Used to remove the tab headers when at run time.
        /// </summary>
        private const int TCM_ADJUSTRECT = 0x1328;

        protected override void WndProc(ref Message m)
        {
            //When running the code during application run time, hide the
            //headers.
            if (m.Msg == TCM_ADJUSTRECT && !DesignMode)
            {
                m.Result = (IntPtr)1;
                return;
            }

            //Calls the Windows Process method from the base class.
            base.WndProc(ref m);
        }
    }
}