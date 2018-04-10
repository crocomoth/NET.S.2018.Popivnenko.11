using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2018.Popivnenko._11.EventTimer.API
{
    public interface ITimer
    {
        event TimerFunc TimerEvent;
    }
}
