namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    public int TableNumber { get; set; }
    public bool IsOccupied { get; private set; }
    
    private ArrayList order = new ArrayList();
    
    public Table(int tableNumber)
    { 
        this.TableNumber = tableNumber;
        this.IsOccupied = false;
    }

    public void Ocupy()
    {
        this.IsOccupied = true;
    }
    
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }

    public void AddToOrder(Dish dish)
    {
        order.Add(dish);
    }
}