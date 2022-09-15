int maxNumber = int.Parse(Console.ReadLine());

topNumbers(maxNumber);

static int sumOfDigits(int maxNumber) {
    int sumDigits = 0;
    while (maxNumber % 10 != 0) {
        sumDigits += maxNumber % 10;
        maxNumber /= 10;
    }
    return sumDigits;
}

bool checkOddDigit(int maxNumber) {
    while(maxNumber % 10 != 0) {
        int currentDigit = maxNumber % 10;
        if (currentDigit % 2 != 0) {
            return true;
        }
        maxNumber /= 10;
    }
    return false;
}

void topNumbers(int maxNumber) {
    for (int i = 1; i <= maxNumber; i++) {
        if (sumOfDigits(i) % 8 == 0 && checkOddDigit(i)) {
            Console.WriteLine(i);
        }
    }
}
