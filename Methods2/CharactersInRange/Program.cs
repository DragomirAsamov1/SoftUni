using System.Text;

char first = char.Parse(Console.ReadLine());
char second = char.Parse(Console.ReadLine());

PrintCharsInRange(first, second);

void PrintCharsInRange(char first, char second)
{
    StringBuilder sb = new StringBuilder();
    if (first > second)
    {
        char between = second;
        second = first;
        first = between;
    }

    for (int i = first+1; i < second; i++)
    {
        sb.Append((char)i + " ");
    }

    Console.WriteLine(sb.ToString());
}