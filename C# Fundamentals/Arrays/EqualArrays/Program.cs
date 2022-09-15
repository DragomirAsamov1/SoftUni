int [] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int [] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int sum = 0;

for (int i = 0; i < arr1.Length; i++) {
    if (arr1[i] != arr2[i]) {
        Console.WriteLine("Arrays are not identical. Found difference at {0} index", i);
        return;
    } else {
        sum += arr1[i];
    }
}

Console.WriteLine("Arrays are identical. Sum: {0}", sum);