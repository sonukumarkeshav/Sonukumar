using System;
public class Person
{
    // Construction declare
    public Person()
    {
        Name = "unknown";
    }
    
    // One arugnment constructors

    public Person(string name)
    {
        Name = name;
    }

    // Auto-implemented propery read only
    public string Name { get;}

    // Overriding the ToString method of Object class

    public override string ToString()
    {
        return Name;
    }


}

class TestPerson
{
    static void Main()
    {
        // Call the constructor that has  no parameters
        var person1 = new Person();
        Console.WriteLine(person1.Name);

        // Call the constructor that has one parametres
        
        var person2 = new Person("abc");
        Console.WriteLine(person2.Name);
        Console.WriteLine(person2);

    }
}