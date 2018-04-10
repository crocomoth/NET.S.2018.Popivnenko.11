using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.S._2018.Popivnenko._11.EventTimer;
using NET.S._2018.Popivnenko._11.EventTimer.API;

namespace NET.S._2018.Popivnenko._11.TimerTestProj
{
    [TestClass]
    public class TimerTester
    {
        [TestMethod]
        public void PositiveTest1()
        {
            ITimer timer = new EventTimer.Timer(TimeSpan.FromMilliseconds(500));
            timer.TimerEvent += CallBack;
            Thread.Sleep(1000);
        }

        private void CallBack(object sender, TimerEventArgs e)
        {
            Debug.WriteLine($"sender");

        }
    }
}
