using System;
using System.Threading;

namespace Problem_08
{
    public class Publisher
    {
        public event EventHandler Tick;

        public delegate void EventHandler(Publisher publisher, EventArgs e);

        public void Execute(int intervalInSeconds, int durationInSeconds)
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(durationInSeconds);

            while (start <= end)
            {
                Thread.Sleep(intervalInSeconds * 1000);
                start = DateTime.Now;

                Tick?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
