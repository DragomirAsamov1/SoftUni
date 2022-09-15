namespace ListyIterator {
    public class StartUp {
        static void Main(string[] args) {
            List<string> items = Console.ReadLine().Split(" ").Skip(1).ToList();

            ListyIterator<string> list = new ListyIterator<string>(items);

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END") {
                switch (command) {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "Print":
                        try {
                            list.Print();
                        } catch (InvalidOperationException ex) {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "PrintAll":
                        Console.WriteLine(String.Join(" ", list));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}