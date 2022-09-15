namespace GenericCountMethodStrings {
    public class Box<T> where T: IComparable {
        public Box(T value) {
            Value = value;
        }
        public T Value { get; set; }
    }
}
