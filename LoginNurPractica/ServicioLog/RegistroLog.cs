using System;
using System.IO;

namespace ServiceLogs
{
    public class RegistroLog
    {
        public void log(string text)
        {
            string rutalog = "D:\\Clases2022001200.txt";

            using (StreamWriter w = File.AppendText(rutalog))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                w.WriteLine("  :");
                w.WriteLine("  :{0}", text);
                w.WriteLine("-------------------------------");
            }
        }
    }
}
