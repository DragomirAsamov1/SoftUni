using StoreBoxes;

List<Box> boxes = new List<Box>();

string[] command = Console.ReadLine().Split(' ');

while (command[0] != "end") {

    Item item = new Item() {
        Name = command[1],
        Price = decimal.Parse(command[3])
    };

    Box box = new Box() {
        SerialNumber = command[0],
        Item = item,
        Quantity = int.Parse(command[2]),
        PriceBox = item.Price * int.Parse(command[2])
    };

    boxes.Add(box);

    command = Console.ReadLine().Split(' ');
}

List<Box> sortedBoxes = boxes.OrderByDescending(box => box.PriceBox).ToList();

foreach (Box box in sortedBoxes) {
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
    Console.WriteLine($"-- ${box.PriceBox:f2}");
}