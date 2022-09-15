namespace GenericScale {
    internal class StartUp {
        static void Main(string[] args) {
            EqualitytScale<int> scale = new EqualitytScale<int>(5, 5);
            Console.WriteLine(scale.AreEqual());
        }
    }
}