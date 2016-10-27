/**
Company info
Description

    A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.

info 	input
Company name: 	Telerik Academy
Company address: 	31 Al. Malinov, Sofia
Phone number: 	+359 888 55 55 555
Fax number: 	
Web site: 	http://telerikacademy.com/
Manager first name: 	Nikolay
Manager last name: 	Kostov
Manager age: 	25
Manager phone: 	+359 2 981 981
Input

    You will each piece of information about the company on a separate line, in the same order as in the example
        Company name
        Company address
        Phone number
        Fax number
        Web site
        Manager first name
        Manager last name
        Manager age
        Manager phone

Output

    Print the information the same way as shown in the sample test. Make sure that you print "(no fax)" if an empty line is passed as fax number.

Constraints

    The input will always be in the described format
    Only the fax number field can be empty, all other fields will be least one symbol
    Time limit: 0.1s
    Memory limit: 16MB

Sample tests
Input 	Output
Telerik Academy
231 Al. Malinov, Sofia
+359 888 55 55 555

http://telerikacademy.com/
Nikolay
Kostov
25
+359 2 981 981 	Telerik Academy
Address: 231 Al. Malinov, Sofia
Tel. +359 888 55 55 555
Fax: (no fax)
Web site: http://telerikacademy.com/
Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)
**/

using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        string managerAge = Console.ReadLine();
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber.Length > 0 ? faxNumber : "(no fax)");
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}