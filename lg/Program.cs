using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process myProcess = new Process();

            string fileName = @"C:\Users\admin\Desktop\lg\WCS\WCS20160112\WCS.exe";

            string para = @"你好 北京欢迎你！";

            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(fileName, para);

            myProcess.StartInfo = myProcessStartInfo;

            myProcess.Start();

            while (!myProcess.HasExited)
            {

                myProcess.WaitForExit();

            }

            int returnValue = myProcess.ExitCode;

            Console.Read();
        }
    }
}
