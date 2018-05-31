using System;
using System.Runtime.InteropServices;

namespace MouseSettingsChangerLib
{
    /// <summary>
    /// Source: http://web.archive.org/web/20111119033345/http://www.sparrowtail.com/changing-mouse-pointer-speed-c
    /// </summary>
    public class Changer
    {
        // Setting key
        private const UInt32 SpiSetmousespeed = 0x0071;

        // Win32 Api library
        [DllImport("User32.dll")]
        static extern Boolean SystemParametersInfo(
            UInt32 uiAction,
            UInt32 uiParam,
            UInt32 pvParam,
            UInt32 fWinIni);

        /// <summary>
        /// Change mouse sensitivity using Win32 API
        /// </summary>
        /// <param name="MouseSpeed">New mouse speed value</param>
        public static void ChangeMouseSpeed(UInt32 MouseSpeed = 1)
        {
            SystemParametersInfo(
              SpiSetmousespeed
              ,0
              ,MouseSpeed
              ,0);
        }
    }
}
