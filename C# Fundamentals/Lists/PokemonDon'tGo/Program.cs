List<int> nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

int index = 0;

int finalSum = 0;

while (nums.Count != 0) {
    index = int.Parse(Console.ReadLine());

    if (index >= 0 && index < nums.Count) {
        int checkNum = nums[index];
        finalSum += checkNum;
        nums.RemoveAt(index);

        changeElements(nums, checkNum);

    } else if (index < 0) {
        if (nums.Count > 0) {
            int checkNum = nums[0];
            int numToAdd = nums[nums.Count - 1];
            nums.RemoveAt(0);
            nums.Insert(0, numToAdd);
            finalSum += checkNum;
            changeElements(nums, checkNum);
        }
    } else if (index > nums.Count - 1) {
        if (nums.Count > 0) {
            int checkNum = nums[nums.Count-1];
            int numToAdd = nums[0];
            nums.RemoveAt(nums.Count - 1);
            nums.Add(numToAdd);
            finalSum += checkNum;
            changeElements(nums, checkNum);
        }
    }
}

Console.WriteLine(finalSum);

static void changeElements(List<int> nums, int checkNum) {
    for (int i = 0; i < nums.Count; i++) {
        if (nums[i] <= checkNum) {
            nums[i] += checkNum;
        } else {
            nums[i] -= checkNum;
        }
    }
}