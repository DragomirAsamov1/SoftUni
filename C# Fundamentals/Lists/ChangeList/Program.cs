﻿List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

while (command[0].ToLower() != "end") {
    switch (command[0].ToLower()) {
        case "delete":
            numbers.RemoveAll(n => n == int.Parse(command[1]));
            break;
        case "insert":
            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
            break;
        default:
            break;
    }

    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
}

Console.WriteLine(String.Join(' ', numbers));