using System;
using System.Linq;

namespace PlayCatch {
    public class Program {
        static void Main(string[] args) {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int counter = 0;
            while (counter < 3) {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                try {
                    switch (input[0]) {
                        case "Replace":
                            int index = ValidateNum(numbers, input[1]);
                            int element = IntParse(input[2]);

                            numbers[index] = element;
                            break;
                        case "Print":
                            int startIndex = ValidateNum(numbers, input[1]);
                            int endIndex = ValidateNum(numbers, input[2]);

                            Console.WriteLine(string.Join(", ", numbers.Skip(startIndex - 1).Take(endIndex - startIndex + 1)));
                            break;
                        case "Show":
                            int index1 = ValidateNum(numbers, input[1]);
                            Console.WriteLine(numbers[index1]);
                            break;
                        default:
                            break;
                    }
                    
                } catch (FormatException ex1) {
                    counter++;
                    Console.WriteLine(ex1.Message);
                } catch (IndexOutOfRangeException ex2) {
                    counter++;
                    Console.WriteLine(ex2.Message);
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
        static int ValidateNum(int[] numbers, string value) {
            if (value.ToCharArray().Any(c => char.IsLetter(c)) || value.Contains(".")) {
                throw new FormatException("The variable is not in the correct format!");
            }

            int intValue = int.Parse(value);

            if (intValue < 0 || intValue > numbers.Length - 1) {
                throw new IndexOutOfRangeException("The index does not exist!");
            }

            return intValue;
        }

        static int IntParse(string value) {

            if (value.ToCharArray().Any(c => char.IsLetter(c)) || value.Contains(".")) {
                throw new FormatException("The variable is not in the correct format!");
            }

            return int.Parse(value);
        }
    }
}
