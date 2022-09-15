namespace GenericCountMethodStrings {
    public class StartUp {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++) {
                boxes.Add(new Box<double>(double.Parse(Console.ReadLine())));
            }

            Box<double> elementForComparrison = new Box<double>(double.Parse(Console.ReadLine()));

            Console.WriteLine(CountBiggerElements(boxes, elementForComparrison));

            static int CountBiggerElements<T>(List<Box<T>> list, Box<T> comparer) where T : IComparable {
                int counter = 0;
                foreach (var item in list) {
                    if (item.Value.CompareTo(comparer.Value) > 0) {
                        counter++;
                    }
                }

                return counter;
            }
        }
    }
}