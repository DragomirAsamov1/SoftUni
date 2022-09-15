int countFilledNums = int.Parse(Console.ReadLine());
int[] arr = new int[countFilledNums];

for (int i = 0; i < countFilledNums; i++) {
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(String.Join(' ', arr.Reverse()));