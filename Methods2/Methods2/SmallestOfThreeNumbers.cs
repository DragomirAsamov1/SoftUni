
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

getSmallestNumber(num1, num2, num3);

static void getSmallestNumber(int num1, int num2, int num3)
{
    int smallestNumber = num1;
    if (smallestNumber > num2) {
        smallestNumber = num2;
    }  
    if (smallestNumber > num3) {
        smallestNumber = num3;
    }
    Console.WriteLine(smallestNumber);
}
