List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

List<int> result = numbers.Where(n => n >= 0).Reverse().ToList();


if (result.Count != 0) {
    Console.WriteLine(String.Join(' ', result));
} else {
    Console.WriteLine("Empty");
}