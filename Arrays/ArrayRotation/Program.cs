int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int firstElement;

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++) {

    firstElement = arr[0];

    for (int j = 0; j < arr.Length - 1; j++) {

        arr[j] = arr[j + 1];
    }
    arr[arr.Length - 1] = firstElement;
}

Console.WriteLine(String.Join(' ', arr));
