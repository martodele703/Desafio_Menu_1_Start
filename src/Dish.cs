namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsVegetarian { get; set; }
    
    public Dish(string dish, decimal price, bool isVegetarian)
    {
        Name = dish;
        Price = price;
        IsVegetarian = isVegetarian;
    }
}