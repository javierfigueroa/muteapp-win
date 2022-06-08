using System.Runtime.InteropServices;

namespace MuteAppConsole
{
    /// <summary>
    /// This service abstracts the functionality to toggle the microphone mute action through the window handle
    /// </summary>
    internal class MuteService
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x180000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public void ToggleMute(IntPtr handle)
        {
            SendMessageW(handle, WM_APPCOMMAND, handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }
    }
}
