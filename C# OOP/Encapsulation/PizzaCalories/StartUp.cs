using System;

namespace PizzaCalories {
    public class StartUp {
        static void Main(string[] args) {
            string[] pizzaInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] doughInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string command = Console.ReadLine();

            try {
                Dough dough = new Dough(doughInput[1], doughInput[2], int.Parse(doughInput[3]));
                Pizza pizza = new Pizza(pizzaInput[1], dough);
                while (command != "END") {
                    string[] toppingInput = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    Topping topping = new Topping(toppingInput[1], int.Parse(toppingInput[2]));

                    pizza.AddTopping(topping);

                    command = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");
            } catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
