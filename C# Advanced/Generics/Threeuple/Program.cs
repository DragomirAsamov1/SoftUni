namespace Threeuple {
    internal class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ', 4, StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>(input[0] + " " + input[1], input[2], input[3]);
            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, int, bool> secondTuple = new Threeuple<string, int, bool>(input[0], int.Parse(input[1]), input[2] == "drunk" ? true : false);
            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, double, string> thirdTuple = new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}