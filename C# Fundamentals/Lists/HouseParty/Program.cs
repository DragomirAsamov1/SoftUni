using System.Text;

int n = int.Parse(Console.ReadLine());

string[] command = new string[]{ };

List<string> names = new List<string>();

StringBuilder output = new StringBuilder();

for (int i = 1; i <= n; i++) {
    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

    if (names.Contains(command[0])) {
        if (command[2].ToLower().Contains("not")) {
            names.Remove(command[0]);
        } else {
            output.AppendLine($"{command[0]} is already in the list!");
        }
    } else {
        if (!command[2].ToLower().Contains("not")) {
            names.Add(command[0]);
        } else {
            output.AppendLine($"{command[0]} is not in the list!");
        }
    }
}

Console.WriteLine(output);

Console.WriteLine(String.Join(' ', names));