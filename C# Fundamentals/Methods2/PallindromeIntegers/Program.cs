using System.Text;

string command = Console.ReadLine();

while (command != "END") {
    Console.WriteLine(Reversed(command));
    command = Console.ReadLine();
}

Reversed(command);

static bool Reversed(string command) {
    StringBuilder sb = new StringBuilder();

    for (int i = command.Length - 1; i >= 0; i--) {
        sb.Append(command[i]);
    }
    if (command == sb.ToString()) {
        return true;
    } else {
        return false;
    }
}