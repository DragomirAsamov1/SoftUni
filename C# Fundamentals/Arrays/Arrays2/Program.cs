string[] days = new string[] {
"Monday",
"Tuesday",
"Wednesday",
"Thursday",
"Friday",
"Saturday",
"Sunday"
};

int chosenDay = int.Parse(Console.ReadLine());

if (chosenDay < 1 || chosenDay > 7) {
    Console.WriteLine("Invalid day!");
} else {
    Console.WriteLine(days[chosenDay - 1]);
}