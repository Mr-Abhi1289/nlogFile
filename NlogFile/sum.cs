using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogFile
{
    internal class sum
    {
        Nlog nlog = new Nlog();
        public void dosum(int a, int b)
        {
            if (a==0|| b==0)
            {
                nlog.LogError("a and be values are zero");
            }
            else
            {
                int c = a + b;
                nlog.logdebug("debug successfully");
                nlog.LogInfo("values are added "+a+" +"+b+" ="+ c);
            }
            
        }
    }
}
