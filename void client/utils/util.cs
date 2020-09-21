using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace void_client.utils
{
    class util
    {
        private static async Task wait(int ms)
        {
            await Task.Delay(ms);
        }

        public static void wait_non_async(int ms)
        {
            DateTime now = DateTime.Now;
            while ((DateTime.Now - now).TotalMilliseconds < ms)
            {
                Application.DoEvents();
            }
        }
    }
}
