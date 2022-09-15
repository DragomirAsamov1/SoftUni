int [] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int evenResult = 0;
int oddResult = 0;

for (int i = 0; i < arr.Length; i++) {
    if (arr[i]% 2 == 0) {
        evenResult += arr[i];
    } else {
        oddResult += arr[i];
    }
}

Console.WriteLine(evenResult - oddResult);