using System;

namespace Vehicles {
    public class StartUp {
        static void Main(string[] args) {
            string[] carInfo = Console.ReadLine().Split(' ');
            string[] truckInfo = Console.ReadLine().Split(' ');
            string[] busInfo = Console.ReadLine().Split(' ');

            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            Bus bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] command = Console.ReadLine().Split(' ');

                try {
                    IVehicle vehicle = GetVehicleType(car, truck, bus, command[1]);

                    if (command[0] == "Drive") {
                        Console.WriteLine(vehicle.Drive(double.Parse(command[2])));
                    } else if (command[0] == "Refuel") {
                        vehicle.Refuel(double.Parse(command[2]));
                    } else if (command[0] == "DriveEmpty") {
                        bus.IsEmpty = true;
                        bus.Drive(double.Parse(command[2]));
                        bus.IsEmpty = false;
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);

        }

        private static IVehicle GetVehicleType(Car car, Truck truck, Bus bus, string vehicle) {
            if (vehicle == "Car") {
                return car;
            } else if (vehicle == "Truck") {
                return truck;
            }
            return bus;
        }
    }
}
