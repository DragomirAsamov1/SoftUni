using System;
using System.Collections.Generic;

namespace WildFarm {
    public class Program {
        static void Main(string[] args) {
            List<IAnimal> animals = new List<IAnimal> ();

            string command = Console.ReadLine();

            while (command != "End") {
                try {
                    string[] animalInfo = command.Split(' ');
                    string[] foodInfo = Console.ReadLine().Split(' ');

                    IAnimal animal = AnimalFactory.CreateAnimal(animalInfo);
                    Console.WriteLine(animal.ProduceSound());

                    animals.Add(animal);

                    IFood food = FoodFactory.CreateFood(foodInfo);
                    animal.Eat(food);

                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                command = Console.ReadLine();
            }

            foreach (IAnimal animal in animals) {
                Console.WriteLine(animal);
            }
        }
    }
}
