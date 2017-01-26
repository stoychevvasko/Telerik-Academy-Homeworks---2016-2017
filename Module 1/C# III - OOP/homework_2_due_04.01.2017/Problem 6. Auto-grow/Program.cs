/*
Problem 6. Auto-grow

* Implement auto-grow functionality: when the internal array is full, create a new array of 
double size and move all elements to it.
*/

namespace Problem_06
{
    class Program
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>();
            for (int i = 0; i < 16; i++)
            {
                list = list.Add(i);
            }
            System.Console.WriteLine("Capacity: {0}", list.Capacity);
            for (int i = 0; i < 16; i++)
            {
                list = list.Add(i);
            }
            System.Console.WriteLine("Capacity: {0}", list.Capacity);
        }
    }
}
