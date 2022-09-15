int [] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

for (int i = 0; i < arr.Length; i++) {

    bool isItBigger = true;

    for (int j = i + 1; j < arr.Length; j++) {
        if (arr[j] >= arr[i]) {
            isItBigger = false;
            break;
        }
    }
    if (isItBigger) {
        Console.Write(arr[i] + " ");
    }

}