List<int> wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

int capacity = int.Parse(Console.ReadLine());

string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

while (command[0].ToLower() != "end") {
    switch (command[0].ToLower()) {
        case "add":
            wagons.Add(int.Parse(command[1]));
            break;
        default:
            for (int i = 0; i < wagons.Count; i++) {
                if (wagons[i] + int.Parse(command[0]) <= capacity) {
                    wagons[i] += int.Parse(command[0]);
                    break;
                }
            }
            break;
    }

    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
}

Console.WriteLine(String.Join(' ', wagons));
