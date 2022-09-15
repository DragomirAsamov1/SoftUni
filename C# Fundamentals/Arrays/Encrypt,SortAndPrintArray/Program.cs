int n = int.Parse(Console.ReadLine());
string input = String.Empty;

string vowels = "AaEeOoUuIi";

int sumVowels = 0;
int sumConsonant = 0;
int sum = 0;

int[] arrOfSums = new int[n];

for (int i = 0; i < n; i++) {

    input = Console.ReadLine();

    char[] letters = input.ToCharArray();

    foreach (char letter in letters) {
        if (vowels.Contains(letter)) {
            sumVowels += letter * input.Length;
        } else {
            sumConsonant += letter / input.Length;
        }
    }

    sum = sumVowels + sumConsonant;
    arrOfSums[i] = sum;
    sumVowels = 0;
    sumConsonant = 0;
    sum = 0;
}

Array.Sort(arrOfSums);
for (int i = 0; i < arrOfSums.Length; i++) {
    Console.WriteLine(arrOfSums[i]);
}



