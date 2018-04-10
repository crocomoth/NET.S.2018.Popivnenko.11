using NET.S._2018.Popivnenko._11.EventTimer.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NET.S._2018.Popivnenko._11.EventTimer
{
    public class Timer : ITimer
    {
        public Timer(TimeSpan timeSpan)
        {
            TimerEvent = (sender, e) => { };
            this.dateTime = DateTime.Now + timeSpan;

            ThreadPool.QueueUserWorkItem(this.Wait);
        }

        private DateTime dateTime;

        public event TimerFunc TimerEvent;

        private void Wait(object state)
        {
            while (DateTime.Now < this.dateTime)
            {
                Thread.Sleep(100);
            }

            TimerEventArgs timerEventArgs = new TimerEventArgs(DateTime.Now, "ring ring!");
            TimerEvent.Invoke(this, timerEventArgs);
        }

    }
}
