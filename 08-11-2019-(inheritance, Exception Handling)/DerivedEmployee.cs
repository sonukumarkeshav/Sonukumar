class DerivedEmployee : BasePerson
{
    public int id;
    public double salary;

    public DerivedEmployee(){} 
    public DerivedEmployee(string name , int age, string address, int id, double salary)
    {
        
        this.name = name;
        this.age = age;
        this.address = address;
        this.id = id;
        this.salary = salary;
    }
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("ID of the Employee == " +id);
        Console.WriteLine("Name of the Employee == " +name);
        Console.WriteLine("Age of the Employee == " +age);
        Console.WriteLine("Address  of the Employee == " +address);
        Console.WriteLine("Salary of the Employee == "+salary );
    }

}