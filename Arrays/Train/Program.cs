int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
int result = 0;

for (int i = 0; i < n; i++) {
    arr[i] = int.Parse(Console.ReadLine());
    result += arr[i];
}

Console.WriteLine(String.Join(' ', arr));
Console.WriteLine(result);