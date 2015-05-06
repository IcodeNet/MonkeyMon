using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyMon.Gathering
{
    public static class Gatherer
    {
        public static void Store(string log)
        {
            var writerLock = "lock";
            lock (writerLock)
            {
                // Write the string to a file.
                System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\gatherer.txt");
                file.WriteLine(log);

                file.Close();
            }
        }
    }
}
