int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int[] firstHalfArr = new int[nums.Length / 4];
int[] lastHalfArr = new int[nums.Length / 4];
int[] middleArr = new int[nums.Length / 2];

int[] outputArr = new int[nums.Length / 2];

for (int i = 0; i < firstHalfArr.Length; i++) {
    firstHalfArr[i] = nums[i];
}

Array.Reverse(firstHalfArr);

for (int i = 0; i < lastHalfArr.Length; i++) {
    int startIndex = firstHalfArr.Length + middleArr.Length + i;
    lastHalfArr[i] = nums[startIndex];
}

Array.Reverse(lastHalfArr);

for (int i = 0; i < middleArr.Length; i++) {
    int startIndex = firstHalfArr.Length + i;
    middleArr[i] = nums[startIndex];
}

int[] combinedArr = new int[firstHalfArr.Length + lastHalfArr.Length];

combinedArr = firstHalfArr.Concat(lastHalfArr).ToArray();

for (int i = 0; i < nums.Length / 2; i++) {
    outputArr[i] = combinedArr[i] + middleArr[i];
}

Console.WriteLine(String.Join(' ', outputArr));