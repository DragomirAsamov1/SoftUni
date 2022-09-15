string[] arr1 = Console.ReadLine().Split().ToArray();

string[] arr2 = Console.ReadLine().Split().ToArray();

string[] result = new string[arr1.Length];

string target = string.Empty;
int counter = 0;

for (int i = 0; i < arr2.Length; i++) {
    target = arr2[i];

    if (arr1.Contains(target)) {
        result[counter] = target;
        counter++;
    }
}

Console.WriteLine(string.Join(' ', result));