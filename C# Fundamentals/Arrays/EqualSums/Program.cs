int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int curr = 0; curr < arr.Length; curr++) {
    int sumRight = 0;

    for (int i = curr + 1; i < arr.Length; i++) {
        sumRight += arr[i];
    }

    int sumLeft = 0;

    for (int i = curr - 1; i >= 0; i--) {
        sumLeft += arr[i];
    }

    if (sumRight == sumLeft) {
        Console.WriteLine(curr);
        return;
    }
}

Console.WriteLine("no");