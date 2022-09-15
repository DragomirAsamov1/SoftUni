int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int arrCount = arr.Length - 1;

int result = 0;

for (int i = 0; i < arrCount; i++) {
    int[] modifiedArray = new int[arr.Length - 1];

    for (int j = 0; j < modifiedArray.Length; j++) {
        modifiedArray[j] = arr[j] + arr[j + 1];
    }
    arr = modifiedArray;
    result = modifiedArray[0];
}

Console.WriteLine(result);