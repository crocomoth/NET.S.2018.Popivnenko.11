using System;
using System.Threading;
using NET.S._2018.Popivnenko._11.EventTimer.API;

namespace NET.S._2018.Popivnenko._11.EventTimer
{
    public class Timer : ITimer
    {
        private DateTime dateTime;

        public Timer(TimeSpan timeSpan)
        {
            TimerEvent = (sender, e) => { };
            this.dateTime = DateTime.Now + timeSpan;

            ThreadPool.QueueUserWorkItem(this.Wait);
        }

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
