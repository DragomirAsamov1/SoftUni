namespace GenericSwapMethodIntegers {
    internal class StartUp {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> list = new List<Box<int>>();

            for (int i = 0; i < n; i++) {
                list.Add(new Box<int>(int.Parse(Console.ReadLine())));
            }

            int[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            SwapIndexes(list, command[0], command[1]);

            foreach (var item in list) {
                Console.WriteLine(item);
            }

            static void SwapIndexes<T>(List<Box<T>> list, int firstIndex, int secondIndex) {
                Box<T> item = list[firstIndex];
                list[firstIndex] = list[secondIndex];
                list[secondIndex] = item;

            }
        }
    }
}