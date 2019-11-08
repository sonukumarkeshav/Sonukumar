public class BasePerson
{
    public string name;
    public int age;
    public string address;

    public BasePerson(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    public void DisplayPersonDetails()
    {
        Console.WriteLine("Person Name = " +name);
        Console.WriteLine("Person Age = " +age);
        Console.WriteLine("Person Address = " +address);
    }

}

