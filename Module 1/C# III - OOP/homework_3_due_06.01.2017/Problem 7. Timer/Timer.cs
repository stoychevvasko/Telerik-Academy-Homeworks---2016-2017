using System;
using System.Threading;

namespace Problem_07
{
    /// <summary>
    /// Executes a method at each t-second interval (intervalInSeconds).
    /// </summary>
    public class Timer
    {
        public delegate void MethodFed();

        public MethodFed method;

        public void Play(int intervalInSeconds, int durationInSeconds)
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(durationInSeconds);

            while (start <= end)
            {
                method();
                Thread.Sleep(intervalInSeconds * 1000);
                start = DateTime.Now;
            }
        }
    }
}
