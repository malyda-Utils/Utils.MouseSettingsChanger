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
        private const UInt32 SpiGetmousespeed = 0x0070;

        /// <summary>
        /// For getting MouseSpeed
        /// </summary>
        [DllImport("User32.dll")]
        static extern Boolean SystemParametersInfo(
            UInt32 uiAction,
            UInt32 uiParam,
            ref UInt32 pvParam,
            UInt32 fWinIni);

        /// <summary>
        /// For seting MouseSpeed
        /// </summary>
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
              , 0
              , MouseSpeed
              , 0);
        }

        /// <summary>
        /// Get mouse sensitivity using Win32 API
        /// </summary>
        public static uint GetMouseSpeed()
        {
            UInt32 mouseSpeed = 0;
            SystemParametersInfo(
              SpiGetmousespeed
              , 0
              , ref mouseSpeed
              , 0);
            return mouseSpeed;
        }
    }
}
