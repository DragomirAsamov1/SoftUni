string password = Console.ReadLine();

rulesChecker(password);
counterChecker(password);
isLetterOrDigit(password);
isContains2Digits(password);

void isContains2Digits(string password)
{
    if (password.Count(char.IsDigit) < 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}

void isLetterOrDigit(string password)
{
    if (!password.All(char.IsLetterOrDigit))
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }
}

void rulesChecker(string password)
{
    if (password.Length > 6 && password.Length <= 10 && password.All(char.IsLetterOrDigit) && password.Count(char.IsDigit) >= 2)
    {
        Console.WriteLine("Password is valid");
    }
}

void counterChecker(string password)
{
    if (password.Length < 6 && password.Length > 10)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }
}