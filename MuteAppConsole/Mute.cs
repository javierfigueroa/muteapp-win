using System.Runtime.InteropServices;

namespace MuteAppConsole
{
    /// <summary>
    /// This is a static class to encapsulate calls to the MuteService
    /// </summary>
    internal static class Mute
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        static MuteService service = new MuteService();

        public static void Toggle()
        {   
            service.ToggleMute(GetConsoleWindow());
        }
    }
}
