using System;

namespace Problem_08
{
    public class Subscriber
    {
        public void Subscribe(Publisher publisher)
        {
            publisher.Tick += new Publisher.EventHandler(TakeAction);
        }

        private void TakeAction(Publisher publisher, EventArgs e)
        {
            System.Console.WriteLine("An event was raised. A subscriber method took action on {0}.",
                                    DateTime.Now.ToString("d MMMM yyyy @ HH:mm:ss"));
            Console.WriteLine();
        }
    }
}
