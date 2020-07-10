using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveHaxvius
{
    public static class Logger
    {
        public static StringBuilder LogString = new StringBuilder();
        public delegate void LogHookDelegate(String x);
        public static LogHookDelegate LogHook;
        public static void Out(string str)
        {
            var now = DateTime.Now;
            Console.WriteLine( );
            str = $"{now.ToString("HH:mm")} - {str}";
            LogString.Append(str).Append(Environment.NewLine);
            LogHook?.Invoke(str);
            LogThis(str);
        }
        private static void LogThis(string str)
        {
            try
            {
                File.AppendAllText(@"..\" + DateTime.Now.ToString("yyyyMMdd") + "_exviusLog.txt", str + "\n");                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
