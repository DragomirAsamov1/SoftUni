int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int addedNums = addNums(num1, num2);
int finalNum = subtractNums(addedNums, num3);
Console.WriteLine(finalNum);

static int subtractNums(int addedNums, int num3)
{
    return addedNums - num3;
}

static int addNums(int num1, int num2)
{
    return num1 + num2;
}