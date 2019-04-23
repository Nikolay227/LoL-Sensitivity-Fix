using System.Runtime.InteropServices;

namespace LOLSensFix.Utils
{
    internal class WinAPI
    {
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        private static extern bool _SystemParametersInfo(
            uint uiAction,
            uint uiParam,
            int pvParam,
            uint fWinIni);

        public static unsafe int GetSensitivity()
        {
            int speed;
            _SystemParametersInfo(/* SpiGetMouseSpeed */ 0x0070, 0, (int) &speed, 0);
            return speed;
        }

        public static void SetSensitivity(int sensitivity)
        {
            _SystemParametersInfo(0x0071, 0, sensitivity, 0);
        }
    }
}
