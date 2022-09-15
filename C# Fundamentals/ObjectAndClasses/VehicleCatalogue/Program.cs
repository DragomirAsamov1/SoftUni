using VehicleCatalogue;

string[] command = Console.ReadLine().Split('/');

Catalog catalog = new Catalog();


while (command[0] != "end") {
    string type = command[0];

    if (type == "Car") {
        Car car = new Car() {
            Brand = command[1],
            Model = command[2],
            HorsePower = int.Parse(command[3])
        };
        catalog.Cars.Add(car);
    } else if (type == "Truck"){
        Truck truck = new Truck() {
            Brand = command[1],
            Model = command[2],
            Weight = int.Parse(command[3])
        };
        catalog.Trucks.Add(truck);
    }

    command = Console.ReadLine().Split('/');
}

if (catalog.Cars.Count > 0) {
    Console.WriteLine("Cars:");

    foreach (Car carList in catalog.Cars.OrderBy(car => car.Brand)) {
        Console.WriteLine($"{carList.Brand}: {carList.Model} - {carList.HorsePower}hp");
    }
}

if (catalog.Trucks.Count > 0) {
    Console.WriteLine("Trucks:");

    foreach (Truck truckList in catalog.Trucks.OrderBy(truck => truck.Brand)) {
        Console.WriteLine($"{truckList.Brand}: {truckList.Model} = {truckList.Weight}kg");
    }
}