using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    public string Name { get; set; }
    private ArrayList assignedTables = new ArrayList();
    
    public Waiter(string name)
    {
        Name = name;
        assignedTables = new ArrayList();
    }

    public void AssignTable(Table table)
    {
        assignedTables.Add(table);
        Console.WriteLine($"La mesa {table} fue agregada al mozo {Name}");
    }

    public void TakeOrder(Table table, Dish dish)
    {
        if (assignedTables.Contains(table))
        {
            table.AddToOrder(dish);
        }
    }
    
}