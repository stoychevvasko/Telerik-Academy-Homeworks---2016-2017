namespace SchoolSystem.Commands
{
    using System.Collections.Generic;
    using Contracts;
    using Core;

    public class StudentListMarksCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            return Engine.Students[int.Parse(parameters[0])].ListMarks();
        }
    }
}
