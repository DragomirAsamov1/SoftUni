double [] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

for (int i = 0; i < arr.Length; i++) {
    Console.WriteLine($"{arr[i]} => {Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
}



