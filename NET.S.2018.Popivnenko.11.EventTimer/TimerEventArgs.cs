using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2018.Popivnenko._11.EventTimer
{
    public class TimerEventArgs : EventArgs
    {
        public TimerEventArgs(DateTime dateTime, string message)
        {
            DateTime = dateTime;
            this.Message = message ?? throw new ArgumentNullException(nameof(message));
        }

        public DateTime DateTime { get; protected set; }

        public string Message { get; protected set; }
    }
}
