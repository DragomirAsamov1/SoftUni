using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking {
    public class Parking {
        public Parking(int capacity) {
            Cars = new List<Car>();
            Capacity = capacity;
        }
        public List<Car> Cars { get; set; }
        public int Capacity { get; set; }
        public int Count => Cars.Count;

        public string AddCar(Car car) {
            if (Cars.Any(x => x.RegistrationNumber == car.RegistrationNumber)){
                return "Car with that registration number, already exists!";
            } else {
                if (Cars.Count > Capacity) {
                    return "Parking is full!";
                } else {
                    Cars.Add(car);
                    return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
                }
            }
        }

        public string RemoveCar(string RegistrationNumber) {

            Car car = Cars.FirstOrDefault(x => x.RegistrationNumber == RegistrationNumber);
            if (car == null) {
                return "Car with that registration number, doesn't exist!";
            }
            Cars.Remove(car);
            return $"Successfully removed {RegistrationNumber}";
        }

        public Car GetCar(string registrationNumber) => Cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers) => Cars = Cars.Where(x => !registrationNumbers.Contains(x.RegistrationNumber)).ToList();
    }
}
