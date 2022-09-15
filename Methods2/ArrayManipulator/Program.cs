int [] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

string [] command = Console.ReadLine().Split(' ').ToArray();

while (command[0] != "end") {
    if (command[0] == "exchange") {
        ExchangeArray(arr, int.Parse(command[1]));
    } else if (command[0] == "max" || command[0] == "min") {
        findMinMaxIndex(arr, command[0], command[1]);
    }
}

static void ExchangeArray(int[] numbers, int index) {
    int[] temp = new int[index + 1];

    for (int i = 0; i <= index; i++) {
        temp[i] = numbers[i];
    }

    for (int i = 0; i <= index; i++) {
        for (int j = 0; j < numbers.Length - 1; j++) {
            numbers[j] = numbers[j + 1];
        }
    }

    int counter = 0;

    for (int i = numbers.Length - 1 - index; i < numbers.Length; i++) {
        numbers[i] = temp[counter];
        counter++;
    }

    Console.WriteLine(String.Join(' ', numbers));
}

static void findMinMaxIndex(int[] numbers, string minMax, string command) {
    int index = int.MinValue;

    for (int i = 0; i < numbers.Length; i++) {
        if (minMax.Contains("min") && command.Contains("even")) {
            if (numbers[i] % 2 == 0) {
                if (index <= numbers[i]) {
                    index = i;
                }
            }
            if (command == "even") {
                if (numbers[i] % 2 == 0) {
                    if (index <= numbers[i]) {
                        index = i;
                    }
                }
            } else if (command == "odd") {
                if (numbers[i] % 2 != 0) {
                    if (index <= numbers[i]) {
                        index = i;
                    }
                }
            }
        }

        if (index != int.MinValue) {
            Console.WriteLine(index);
        } else {
            Console.WriteLine("No matches");
        }
    }
}