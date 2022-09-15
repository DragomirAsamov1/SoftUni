using System.Text;

string word = Console.ReadLine();

printMiddleChars(word);

void printMiddleChars(string word)
{
    StringBuilder sb = new StringBuilder();

    if(word.Length % 2 == 0)
    {
        sb.Append(word[word.Length/2 - 1]);
        sb.Append(word[word.Length/2]);
    } else
    {
        sb.Append(word[word.Length / 2]);
    }

    Console.WriteLine(sb.ToString());
}