List<int> numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

for (int i = 0; i <= numbers.Count / 2; i++) {
    numbers[i] += numbers[numbers.Count - 1];
    numbers.Remove(numbers.Last());
}

Console.WriteLine(String.Join(' ', numbers));