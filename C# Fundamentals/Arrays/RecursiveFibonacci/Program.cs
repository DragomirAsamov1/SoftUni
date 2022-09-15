int input = int.Parse(Console.ReadLine());

int[] arr = new int[input];

if (arr.Length > 0) {
    arr[0] = 1;
}

if (arr.Length > 1) {
    arr[1] = 1;
}

for (int i = 2; i < input; i++) {
    arr[i] = arr[i - 2] + arr[i - 1];
}

Console.WriteLine(arr[input-1]);