using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
namespace WindowUtility
{
   
    internal class PowerControl
    {
        /*
         * dựa trên https://stackoverflow.com/questions/2079813/c-sharp-put-pc-to-sleep-or-hibernate
         * sử dụng api của thư viện PowrProf.dll
         * sử dụng hàm SetSuspendState cho việc điều khiển máy sleep hoạt hibernate 
         * dựa trên https://stackoverflow.com/questions/14466373/log-off-a-windows-user-locally-using-c-sharp
         * 
         */
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        [DllImport("powrprof.dll", SetLastError = true)]
        private static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);


        private List<Thread> threads = new List<Thread>();

        private void addNewThread(ThreadStart threadAction) {
            Thread thread = new Thread(threadAction);
            this.threads.Add(thread);
            thread.Start();
        }

        public void shutdown(int seconds = 0)
        {
            this.addNewThread (() => Process.Start("shutdown", $"/s /t {seconds}"));
        }

        public void restart(int seconds = 0)
        {
            this.addNewThread(() => Process.Start("shutdown", $"/r /t {seconds}"));
        }

        public void hibernate(int seconds = 0)
        {
            this.addNewThread(() => {
                Thread.Sleep(seconds * 1000);
                SetSuspendState(true, false, false);
                }
            );
        }

        public void sleep(int seconds = 0)
        {
            this.addNewThread(() => {
                Thread.Sleep(seconds * 1000);
                SetSuspendState(false, false, false);
                }
            );
        }

        public void logout(int seconds = 0)
        {
            this.addNewThread(() => {
                Thread.Sleep(seconds * 1000);
                ExitWindowsEx(0, 0);
                }
            );
        }
        public void cancelAllActions()
        {
            foreach (Thread thread in threads)
            {
                if (thread.IsAlive)
                {
                    thread.Abort();
                }
            }
            threads.Clear();
            Process.Start("shutdown", "/a"); 
        }
    }
}
