using System;

struct Item
{
    public string Name;
    public int Quantity;
    public decimal Price;
}

struct Check
{
    public string s_Name;
    public string BuyerName;
    public DateTime Date;
    public Item[] Items;
    public decimal Discount;
    public decimal Order;
}

class Program
{
    static void Main(string[] args)
    {
        Item item1 = new Item { Name = "Bread", Quantity = 1, Price = 28.50m };
        Item item2 = new Item { Name = "Banana", Quantity = 1, Price = 58.00m };
        Item item3 = new Item { Name = "Water", Quantity = 3, Price = 50.70m };

        Check check = new Check();
        check.s_Name = "ATB";
        check.BuyerName = "Yakuskin Arkadiy";
        check.Date = DateTime.Now;
        check.Items = new Item[] { item1, item2, item3 };
        check.Discount = 10.00m;
        check.Order = (item1.Quantity * item1.Price + item2.Quantity * item2.Price + item3.Quantity * item3.Price) * (1 - check.Discount / 100);

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(check.s_Name);
        Console.WriteLine(check.Date.ToString());
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"{"Name",-20} {"Quantity",10} {"price",10} {"full_price",10}");
        Console.WriteLine(new string('-', 30));
        foreach (Item item in check.Items)
        {
            Console.WriteLine($"{item.Name,-20} {item.Quantity,10} {item.Price,10:C} {item.Quantity * item.Price,10:C}");
        }
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"{"Discount",-20} {check.Discount,20:C}");
        Console.WriteLine($"{"Order",-20} {check.Order,20:C}");
        Console.WriteLine(check.BuyerName);
        Console.WriteLine("Thank you for your purchase! Come and see us again!");
        Console.ResetColor();
    }
}
