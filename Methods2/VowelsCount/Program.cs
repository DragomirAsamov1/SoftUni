var word = Console.ReadLine().ToLower();

printVowelsCount(word);
anotherVowelsCount(word);

void printVowelsCount(string word)
{
    int counter = 0;
    foreach (char letter in word) {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'y' || letter == 'u')
        {
            counter++;
        }
    }
    Console.WriteLine(counter);
}

void anotherVowelsCount(string word)
{
    int counter = 0;

    for (int i = 0; i < word.Length; i++)
    {
        char currentLetter = word[i];
        if (currentLetter == 'a' ||
            currentLetter == 'e' ||
            currentLetter == 'i' ||
            currentLetter == 'o' ||
            currentLetter == 'y' ||
            currentLetter == 'u')
        {
            counter++;
        }
    }
    Console.WriteLine(counter);
}