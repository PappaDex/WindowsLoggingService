using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace Timer_Console
{
   public class Timer
    {
        TimerCallback _callback;
        object _state;
        int _dueTime;
        int _period;
        public Timer(TimerCallback callback, object state, int dueTime, int period)
        {
            _callback = callback;
            _state = state;
            _dueTime = dueTime;
            _period = period;
        }
        public Timer(TimerCallback callback)
        {
            _callback = callback;
        }
        public void Change(int due, int inf)
        {
            _period = inf;
            _dueTime = due;
        }
        public static void WriteToFile(string text)
        {
            string path = "C:\\Users\\astudent\\Desktop\\ServiceLog.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(string.Format( DateTime.Now.ToString("yyyy/MM/dd"),text));

                writer.Close();
            }
        }
    }
}
