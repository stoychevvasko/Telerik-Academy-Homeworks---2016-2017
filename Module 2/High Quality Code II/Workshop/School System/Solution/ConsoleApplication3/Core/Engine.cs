namespace SchoolSystem.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using Commands.Contracts;
    using Contracts;
    using Models;
    using Providers;

    public class Engine
    {
        public Engine(IReader reader)
        {
            this.Reader = reader;
        }

        public IReader Reader
        {
            get;
            set;
        }

        internal static Dictionary<int, Teacher> Teachers { get; set; } = new Dictionary<int, Teacher>();

        internal static Dictionary<int, Student> Students { get; set; } = new Dictionary<int, Student>();

        public void Start()
        {
            while (true)
            {
                try
                {
                    var command = this.Reader.ReadLine();
                    if (command == "End")
                    {
                        break;
                    }

                    var aadeshName = command.Split(' ')[0];

                    // When I wrote this, only God and I understood what it was doing
                    // Now, only God knows
                    var assembly = GetType().GetTypeInfo().Assembly;
                    var typeInfo = assembly.DefinedTypes
                        .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
                        .Where(type => type.Name.ToLower().Contains(aadeshName.ToLower()))
                        .FirstOrDefault();
                    if (typeInfo == null)
                    {
                        // throw exception when typeinfo is null
                        throw new ArgumentException("The passed command is not found!");
                    }

                    var userCommand = Activator.CreateInstance(typeInfo) as ICommand;
                    var parameters = command.Split(' ').ToList();
                    parameters.RemoveAt(0);
                    this.WriteLine(userCommand.Execute(parameters));
                }
                catch (Exception ex)
                {
                    this.WriteLine(ex.Message);
                }
            }
        }

        public void WriteLine(string m)
        {
            var p = m.Split();
            var s = string.Join(" ", p);
            var c = 0d;

            for (double i = 0; i < 0x105; i++)
            {
                try
                {
                    Console.Write(s[int.Parse(i.ToString())]);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            Console.Write("\n");
            Thread.Sleep(350);
        }
    }
}
