List<string> nums = Console.ReadLine().Split('|').ToList();

nums.Reverse();

List<string> result = new List<string>();

foreach (string s in nums) {
    string[] numbers = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
    foreach (string n in numbers) {
        result.Add(n);
    }
}

Console.WriteLine(String.Join(' ', result));