using System.Text;

List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

StringBuilder output = new StringBuilder();

bool isChanged = false;

while (command[0].ToLower() != "end") {
    switch (command[0].ToLower()) {
        case "add":
            numbers.Add(int.Parse(command[1]));
            isChanged = true;
            break;
        case "remove":
            numbers.Remove(int.Parse(command[1]));
            isChanged = true;
            break;
        case "removeat":
            numbers.RemoveAt(int.Parse(command[1]));
            isChanged = true;
            break;
        case "insert":
            numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));
            isChanged = true;
            break;
        case "contains":
            output.AppendLine(numbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
            break;
        case "printeven":
            output.AppendLine(String.Join(' ', numbers.Where(n => n % 2 == 0)));
            break;
        case "printodd":
            output.AppendLine(String.Join(' ', numbers.Where(n => n % 2 != 0)));
            break;
        case "getsum":
            output.AppendLine(numbers.Sum().ToString());
            break;
        case "filter":
            string result = string.Empty;
            switch (command[1]) {
                case "<":
                    result = String.Join(' ', numbers.Where(n => n < int.Parse(command[2])));
                    output.AppendLine(result);
                    break;
                case ">":
                    result = String.Join(' ', numbers.Where(n => n > int.Parse(command[2])));
                    output.AppendLine(result); 
                    break;
                case ">=":
                    result = String.Join(' ', numbers.Where(n => n >= int.Parse(command[2])));
                    output.AppendLine(result); 
                    break;
                case "<=":
                    result = String.Join(' ', numbers.Where(n => n <= int.Parse(command[2])));
                    output.AppendLine(result); 
                    break;
            }
            break;
        default:
            break;
    }

    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    
}

Console.WriteLine(output);

if (isChanged) {
    Console.WriteLine(String.Join(' ', numbers));
}