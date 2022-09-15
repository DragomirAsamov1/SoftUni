using System;
using System.Linq;

namespace _22._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0].ToLower() != "end")
            {
                switch (command[0])
                {
                    case "exchange":
                        int index = int.Parse(command[1]);
                        if (index >= 0 && index <= arr.Length - 1)
                        {
                            ExchangeArray(arr, index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "max":
                        string evenOrOdd = command[1].ToLower();
                        Console.WriteLine(GetMax(evenOrOdd, arr));
                        break;
                    case "min":
                        string oddOrEven = command[1].ToLower();
                        Console.WriteLine(GetMin(oddOrEven, arr));
                        break;
                    case "first":
                        int count = int.Parse(command[1]);
                        string firstEvenOrOdd = command[2].ToLower();

                        break;
                    default:
                        break;
                }
                command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }
        static void ExchangeArray(int[] arr, int index)
        {
            int[] temp = new int[index + 1];

            for (int i = 0; i <= index; i++)
            {
                temp[i] = arr[i];
            }

            for (int i = 0; i <= index; i++)
            {
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    arr[k] = arr[k + 1];
                }
            }

            int counter = 0;

            for (int i = arr.Length - 1 - index; i < arr.Length; i++)
            {
                arr[i] = temp[counter];
                counter++;
            }
            Console.WriteLine(string.Join(' ', arr));
        }
        static string GetMax(string evenOrOdd, int[] arr)
        {

            int max = int.MinValue;
            int indexPosition = -1;
            bool check = false;
            if (evenOrOdd == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] >= max)
                        {
                            max = arr[i];
                            indexPosition = i;
                            check = true;
                        }
                    }
                }
                if (check)
                {
                    return indexPosition.ToString();
                }
            }
            else if (evenOrOdd == "odd")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] >= max)
                        {
                            max = arr[i];
                            indexPosition = i;
                            check = true;
                        }
                    }
                }
                if (check)
                {
                    return indexPosition.ToString();
                }
            }
            return "No matches";
        }
        static string GetMin(string evenOrOdd, int[] arr)
        {
            int min = int.MaxValue;
            int indexPosition = -1;
            bool check = false;
            if (evenOrOdd == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] <= min)
                        {
                            min = arr[i];
                            indexPosition = i;
                            check = true;
                        }
                    }
                }
                if (check)
                {
                    return indexPosition.ToString();
                }
            }
            else if (evenOrOdd == "odd")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] <= min)
                        {
                            min = arr[i];
                            indexPosition = i;
                            check = true;
                        }
                    }
                }
                if (check)
                {
                    return indexPosition.ToString();
                }
            }
            return "No matches";
        }
        static void PrintFirstEvenOrOdd(int[] arr, int count, string evenOrOdd)
        {
            int[] temp = new int[count];
            int counter = 0;
            int counterOfEvenDigits = 0;
            int zeroDigitCounter = 0;
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (evenOrOdd == "even")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            if (arr[i]==0)
                            {
                                zeroDigitCounter++;
                            }
                            temp[counterOfEvenDigits] = arr[i];
                            counterOfEvenDigits++;

                            if (counterOfEvenDigits>=count)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
