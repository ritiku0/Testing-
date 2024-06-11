using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace WindowServiceBasic
{
    internal class WindowService
    {
        private readonly System.Timers.Timer _timer;
        public WindowService()
        {
            _timer = new System.Timers.Timer(100) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object? sender, ElapsedEventArgs e)
        {
            string[] WindowServiceList = new string[] {DateTime.Now.ToString() };
            File.AppendAllLines(@"C:\Temp\Demos\WindowService.txt", WindowServiceList);
        }
        public void OnStart()
        {
            _timer.Start();
        }
        public void OnStop()
        {
            _timer.Stop();
        }
    }
}
