namespace GenericSwapMethodStrings {
    internal class StartUp {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            List<Box<string>> list = new List<Box<string>>();

            for (int i = 0; i < n; i++) {
                list.Add(new Box<string>(Console.ReadLine()));
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