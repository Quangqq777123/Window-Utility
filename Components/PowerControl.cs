using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowUtility
{
   
    internal class PowerControl
    {
        /*
         * dựa trên https://stackoverflow.com/questions/2079813/c-sharp-put-pc-to-sleep-or-hibernate
         * sử dụng api của thư viện PowrProf.dll
         * sử dụng hàm SetSuspendState cho việc điều khiển máy sleep hoạt hibernate 
         */
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
    }
}
