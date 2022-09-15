List<int> firstList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

List<int> secondList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

List<int> resultList = new List<int>();

for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++) {
    resultList.Add(firstList[i]);
    resultList.Add(secondList[i]);
}

for (int i = Math.Min(firstList.Count, secondList.Count); i < Math.Max(firstList.Count, secondList.Count); i++) {
    if (firstList.Count >= secondList.Count) {
        resultList.Add(firstList[i]);
    } else {
        resultList[i] = secondList[i];
    }
}

Console.WriteLine(String.Join(' ', resultList));