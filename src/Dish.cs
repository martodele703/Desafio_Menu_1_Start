namespace Ucu.Poo.Restaurant;
using System;

public class Dish
{
    public Dish(string name, double price, bool isVegetarian)
    {
        Name = name;
        Price = price;
        IsVegetarian = isVegetarian;
        
        Console.WriteLine("El nombre es :", name);
        Console.WriteLine("El precio es: ", price);
        Console.WriteLine("Vegetariano: ", isVegetarian);
    }
    private string name
    {
        get; set;
    }
    private double price
    {
        get; set;
    }
    private bool isVegetarian
    {
        get; set;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value; 
        }
    }

    public bool IsVegetarian
    {
        get {
            return isVegetarian;
        }
        set {
            IsVegetarian = value;
        }
    }
}
