namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private List<Dish> dishes = new List<Dish>();

    public List<Dish> Dishes
    {
        get { return dishes;}
        set
        {
            if (value != null)
            {
                dishes = value;
            }
        }
        
    }
    public void AddDish(Dish dish)
    {
        this.dishes.Add(dish);
    }

    public void RemoveDish(Dish dish)
    {
        this.dishes.Remove(dish);
    }

    public Dish GetDishByName(string name)
    {
        bool flag = true;
        int i = 0;
        
        while (flag || i < this.dishes.Count)
        {
            if (this.dishes[i].Name == name)
            {
                flag = false;
            }

            i++;
        }

        if (flag) return null;
        else return this.dishes[i];
    }
}