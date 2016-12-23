/*
Problem 11. Version attribute

* Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods 
and holds a version in the format major.minor (e.g. 2.11).
* Apply the version attribute to a sample class and display its version at runtime.
*/

using System;
using System.Reflection;

namespace Problem_11
{
    [VersionAttribute(2, 22)]
    public class TestClass
    {
    }

    class Program
    {
        static void Main()
        {
            var typesArray = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in typesArray)
            {
                Object[] attirbutes = type.GetCustomAttributes(false);

                foreach (var attr in attirbutes)
                {
                    if (attr is VersionAttribute)
                    {
                        Console.WriteLine("{0} v.{1}.{2}", type.Name, ((VersionAttribute)attr).Major, ((VersionAttribute)attr).Minor);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
