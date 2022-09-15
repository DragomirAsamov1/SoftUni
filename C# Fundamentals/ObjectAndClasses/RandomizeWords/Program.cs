List<string> words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

Random rnd = new Random();

for (int i = 0; i < words.Count; i++) {
    int randomIndex = rnd.Next(0, words.Count);
    string word = words[i];
    words[i] = words[randomIndex];
    words[randomIndex] = word;
}

foreach (var word in words) {
    Console.WriteLine(word);
}