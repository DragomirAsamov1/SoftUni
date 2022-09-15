using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm {
    public static class AnimalFactory {
        public static IAnimal CreateAnimal(string[] animalInfo) {
            IAnimal animal = null;

            string type = animalInfo[0];
            string name = animalInfo[1];
            double weight = double.Parse(animalInfo[2]);

            if (type == "Cat" || type == "Tiger") {
                string livingRegion = animalInfo[3];
                string breed = animalInfo[4];

                if (type == "Cat") {
                    animal = new Cat(name, weight, livingRegion, breed);
                } else {
                    animal = new Tiger(name, weight, livingRegion, breed);
                }
            } else if (type == "Hen" || type == "Owl") {
                double wingSize = double.Parse(animalInfo[3]);

                if (type == "Hen") {
                    animal = new Hen(name, weight, wingSize);
                } else {
                    animal = new Owl(name, weight, wingSize);
                }
            } else {
                string livingRegion = animalInfo[3];

                if (type == "Dog") {
                    animal = new Dog(name, weight, livingRegion);
                } else {
                    animal = new Mouse(name, weight, livingRegion);
                }
            }

            return animal;

        }
    }
}
