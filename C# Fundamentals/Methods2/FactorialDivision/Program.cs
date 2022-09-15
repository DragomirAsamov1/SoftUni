int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

double output = Factorial(num1) - Factorial(num2);
Console.WriteLine($"{output:f2}");

static double Factorial(int num) {
    int n = num;
    for (int i = num - 1; i > 0; i--) {
        n *= i;
    }
    return n;
}
