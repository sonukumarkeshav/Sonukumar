using System;
class Customer_AutoImlemented
{
    // Auto-implemented properties for trivial get and set
    public double TotalPurchases { get; set; }
    public string Name { get; set; }
    public int CustomerId { get; set;}

    
    // Constructor

    public Customer_AutoImlemented(double purchases, string name, int id)
    {
            TotalPurchases = purchases;
            Name = name;
            CustomerId = id;
        
    }
        // Method

       public string GetContactInfo(){ return "ContactInfo"; }
       public string GetTranactionHistory(){ return "History"; }
   

}

class Test
{
    public static void Main(string[] args)
    {
        Customer_AutoImlemented obj = new Customer_AutoImlemented(45323.22, "Northnadl", 101);
        Console.WriteLine("Total purchases value before modified: " +obj.TotalPurchases);
        obj.TotalPurchases += 3432.0;
          Console.WriteLine("Total purchases value after modified: " +obj.TotalPurchases);
    }
}