using ContosoPizza.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContosoPizza.Services
{
    public class PizzaService 
    {
        static List<Pizza> Pizzas { get; }

        static PizzaService()
        {
            Pizzas = new List<Pizza>
            {
                new() { ID = 0, Name = "Pepperoni", Calories = 1200, Price = 8.75m },
                new() { ID = 1, Name = "Margarita", Calories = 2000, Price = 12 },
                new() { ID = 2, Name = "Mushrooms", Calories = 800, Price = 10 }
            };
        }

        public List<Pizza> GetAll()
        {
            return Pizzas;
        }

        public Pizza GetPizza(int id) 
        {
            return Pizzas.Where(pizza => pizza.ID == id).FirstOrDefault();
        }

        public void AddPizza(string name, int calories, decimal price)
        {
            int id = Pizzas.Count == 0 ? 0 : (Pizzas.Max(pizza => pizza.ID) + 1);

            AddPizza(id, name, calories, price);
        }

        public void AddPizza(int id, string name, int calories, decimal price)
        {
            AddPizza(new Pizza { ID = id, Name = name, Calories = calories, Price = price } );
        }

        public void AddPizza(Pizza pizza) 
        {
            Pizzas.Add(pizza);
        }

        public void DeletePizza(Pizza pizza) 
        {
            Pizzas.Remove(pizza);
        }

        public void DeletePizza(int id) 
        {
            DeletePizza(GetPizza(id));
        }

        public void UpdatePizza(int id, string name, int calories, decimal price)
        {
            UpdatePizza(new Pizza { ID = id, Name = name, Calories = calories, Price = price } );
        }

        public void UpdatePizza(Pizza pizza)
        {
            var old = GetPizza(pizza.ID);
            
            if(old == null) return; // MAY DO error or add

            old.Name = pizza.Name;
            old.Calories = pizza.Calories;
            old.Price = pizza.Price;
        }
    }
}