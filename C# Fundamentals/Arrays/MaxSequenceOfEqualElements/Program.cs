int [] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int target = -1;
int sequence = 0;
int maxSequence = 0;
int num = -1;

for (int i = 0; i < arr.Length; i++) {
    
    if (target == arr[i]) {
        sequence++;
        if (maxSequence < sequence) {
            maxSequence = sequence;
            num = target;
        }
    } else {
        target = arr[i];
        sequence = 1;
    }
}

int[] newArr = new int[maxSequence];
for (int i = 0; i < newArr.Length; i++) {
    newArr[i] = num;
}

Console.WriteLine(String.Join(' ', newArr));