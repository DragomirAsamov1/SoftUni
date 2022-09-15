int input = int.Parse(Console.ReadLine());

printMatrix(input);

void printMatrix(int input) {
    for (int i = 0; i < input; i++) {
        for (int j = 0; j < input; j++) {
            Console.Write(input + " ");
        }
        Console.WriteLine();
    }
}

