List<int> player1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
List<int> player2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

for (int i = 0; i < Math.Min(player1.Count, player2.Count); i++) {
    if (player1[i] > player2[i]) {
        player1.Add(player1[i]);
        player1.Add(player2[i]);
        player1.RemoveAt(i);
        player2.RemoveAt(i);
        i = -1;

    } else if (player1[i] < player2[i]) {
        player2.Add(player2[i]);
        player2.Add(player1[i]);
        player1.RemoveAt(i);
        player2.RemoveAt(i);
        i = -1;

    } else {
        player1.RemoveAt(i);
        player2.RemoveAt(i);
        i = -1;
    }

    if (player1.Count == 0) {
        Console.WriteLine($"Second player Wins! Sum: {player2.Sum()}");
    } else if (player2.Count == 0) {
        Console.WriteLine($"First player Wins! Sum: {player1.Sum()}");
    }
}