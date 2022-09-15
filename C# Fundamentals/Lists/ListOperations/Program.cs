List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

while (command[0].ToLower() != "end") {
    switch (command[0].ToLower()) {
        case "add": add(numbers, int.Parse(command[1]));
            break;
        case "insert": insert(numbers, int.Parse(command[2]), int.Parse(command[1]));
            break;
        case "remove": remove(numbers, int.Parse(command[1]));
            break;
        case "shift":
            switch (command[1].ToLower()) {
                case "left": shiftLeft(numbers, int.Parse(command[2]));
                    break;
                case "right": shiftRight(numbers, int.Parse(command[2]));
                    break;
                default:
                    break;
            }
            break;
        default:
            break;
    }

    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
}

Console.WriteLine(String.Join(' ', numbers));

static void add (List<int> nums,int num) {
    nums.Add(num);
}

static void insert(List<int> nums, int index, int num) {

    if (index < 0 & index > nums.Count) {
        Console.WriteLine("Invalid index");
    } else {
        nums.Insert(index, num);
    }
}

static void remove(List<int> nums, int index) {
    if (index < 0 || index > nums.Count - 1) {
        Console.WriteLine("Invalid index");
    } else {
        nums.RemoveAt(index);
    }
}

static void shiftLeft (List<int> nums, int count) {
    for (int i = 0; i < count; i++) {
        nums.Add(nums[0]);
        nums.RemoveAt(0);
    }
}

static void shiftRight (List<int> nums, int count) {
    for (int i = 0; i < count; i++) {
        nums.Insert(0, nums[nums.Count - 1]);
        nums.RemoveAt(nums.Count - 1);
    }
}