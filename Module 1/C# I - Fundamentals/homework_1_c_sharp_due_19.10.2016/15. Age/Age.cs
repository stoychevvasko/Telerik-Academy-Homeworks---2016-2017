using System;

class Age
{
    static void Main()
    {
        string[] dobStrings = Console.ReadLine().Split('.');
        int year = int.Parse(dobStrings[2]);
        int month = int.Parse(dobStrings[0]);
        int day = int.Parse(dobStrings[1]);
        
        DateTime dob = new DateTime(year, month, day);
        DateTime now = DateTime.Now.AddMonths(-7);

        int age = (int)((now - dob).TotalDays/365);
        
        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}