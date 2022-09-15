namespace CustomLinkedList {
    public class Program {
        static void Main(string[] args) {
            CustomList<string> list = new CustomList<string>();
            list.Add("Kolio");
            list.Add("Gosho");
            list.Swap(0, 1);
            Console.WriteLine(list.Count);
            Console.WriteLine(String.Join(' ', list));
        }
    }
}