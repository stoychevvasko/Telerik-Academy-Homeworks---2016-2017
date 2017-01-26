/*
Problem 8.* Events

* Read in MSDN about the keyword event in C# and how to publish events.
* Re-implement the above using .NET events and following the best practices.
*/

namespace Problem_08
{
    class Program
    {
        static void Main()
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            subscriber.Subscribe(publisher);
            publisher.Execute(2, 10);
        }
    }
}
