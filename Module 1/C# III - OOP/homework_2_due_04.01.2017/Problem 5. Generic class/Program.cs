/*
Problem 5. Generic class

* Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
* Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
* Implement methods for adding element, accessing element by index, removing element by index, inserting element 
at given position, clearing the list, finding element by its value and ToString().
* Check all input parameters to avoid accessing elements at invalid positions. 
*/

using System;
using System.Collections.Generic;
using Problem_04;

namespace Problem_05
{
    class Program
    {
        static void Main()
        {
            GenericList<string> testStringList = new GenericList<string>()
                          .Add("asdf")
                          .Add("qwerty")
                          .Add("asd")
                          .Add("123456789")
                          .Remove(2)
                          ;



            Console.WriteLine(testStringList);
            Console.WriteLine("Generic list count: {0}", testStringList.Count);

            Console.WriteLine();
            testStringList.Insert("Inserted at index 0", 0)
                          .Insert("Inserted at index 0 - duplicate", 0);
            Console.WriteLine(testStringList);
            Console.WriteLine("index of `{0}`: {1}",
                "Inserted at index 0 - duplicate",
                testStringList.Find("Inserted at index 0 - duplicate"));

            Console.WriteLine();
            Console.WriteLine("Clear");
            testStringList.Clear();
            for (int i = 0; i < testStringList.Count; i++)
            {
                Console.WriteLine(testStringList[i]);
            }
        }
    }
}
