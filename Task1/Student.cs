using System.Security.Cryptography.X509Certificates;

namespace Task1;

public class Student : Person
{
    
    public void Study()
    {
        System.Console.WriteLine("I'm studying");
    }
    public void ShowAge()
    {
        System.Console.WriteLine($"My age is {Age} years old");
    }
}
