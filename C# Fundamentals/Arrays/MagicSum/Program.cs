﻿int [] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int magicNum = int.Parse(Console.ReadLine());

for (int i = 0; i < arr.Length; i++) {
    for (int j = i + 1; j < arr.Length; j++) {
        if (arr[i] + arr[j] == magicNum) {
            Console.WriteLine("{0} {1}",arr[i], arr[j]);
        }
    }
}