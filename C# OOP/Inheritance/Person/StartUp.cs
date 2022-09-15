namespace Person {
    public class StartUp {
        static void Main(string[] args) {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age > 15) {
                Person person = new Person(name, age);
                Console.WriteLine(person);
            } else {
                Child person = new Child(name, age);
                Console.WriteLine(person);
                
            }
        }
    }
}