List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

int[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int bombNum = command[0];
int power = command[1];

for (int i = 0; i < numbers.Count; i++) {
    if (bombNum == numbers[i]) {
        rightBoom(numbers, i, power);
        leftBoom(numbers, i, power);
    }
}

numbers.RemoveAll(n => n == bombNum);

Console.WriteLine(sum(numbers));
Console.WriteLine(String.Join(' ', numbers));

static void leftBoom (List<int> nums, int index, int power) {
    for (int i = 0; i < power; i++) {
        if (index - 1 >= 0) {
            nums.RemoveAt(index - 1);
            index--;
        } else {
            break;
        }
    }
}

static void rightBoom(List<int> nums, int index, int power) {
    for (int i = 0; i < power; i++) {
        if (index + 1 <= nums.Count - 1) {
            nums.RemoveAt(index + 1);
        } else {
            break;
        }
    }
}

static int sum (List<int> nums) {
    return nums.Sum();
}
