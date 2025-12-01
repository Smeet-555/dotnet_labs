using System;

class Item
{
    public string Name;
    public double Price;
    public int Quantity;

    public Item(string name, double price, int quantity)
    {
        if (quantity <= 0)
            throw new Exception("Item quantity must be greater than zero.");

        if (price <= 0)
            throw new Exception("Item price must be positive.");

        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotal()
    {
        return Price * Quantity;
    }
}

class ShoppingCart
{
    private Item[] items;
    private int count;

    public ShoppingCart(int size)
    {
        items = new Item[size];
        count = 0;
    }

    public void AddItem(string name, double price, int quantity)
    {
        try
        {
            if (count >= items.Length)
                throw new Exception("Cart is full!");

            Item item = new Item(name, price, quantity);
            items[count] = item;
            count++;

            Console.WriteLine("Item added successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public double CalculateTotal()
    {
        double total = 0;

        for (int i = 0; i < count; i++)
        {
            total += items[i].GetTotal();
        }

        return total;
    }

    public void DisplayCart()
    {
        Console.WriteLine("\n--- Shopping Cart ---");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(
                items[i].Name + " | Price: " + items[i].Price +
                " | Qty: " + items[i].Quantity +
                " | Total: " + items[i].GetTotal());
        }

        Console.WriteLine("\nFinal Bill = " + CalculateTotal());
    }
}

class Program3C7
{
    public static void Run()
    {
        ShoppingCart cart = new ShoppingCart(5); 

        cart.AddItem("Laptop", 60000, 1);
        cart.AddItem("Mouse", 500, 2);

        // Invalid item (Exception)
        cart.AddItem("Keyboard", 1200, 0);

        cart.DisplayCart();
    }
}
