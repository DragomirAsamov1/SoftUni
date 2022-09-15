namespace Tuple {
    public class StartUp {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Tuple<string, string> firstTuple = new Tuple<string, string>(input[0] + " " + input[1], input[2]);
            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Tuple<string, int> secondTuple = new Tuple<string, int>(input[0], int.Parse(input[1]));
            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(int.Parse(input[0]), double.Parse(input[1]));

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
            
            
        }
    }
}