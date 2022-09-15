using Students;

List<Student> students = new List<Student>();

string[] command = Console.ReadLine().Split(' ');

while (command[0] != "end") {
    string firstName = command[0];
    string lastName = command[1];
    int age = int.Parse(command[2]);
    string city = command[3];

    Student student = students.FirstOrDefault(n => n.FirstName == firstName && n.LastName == lastName);

    if (student == null) {
        students.Add(new Student() {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            City = city
        });
    } else {
        student.FirstName = firstName;
        student.LastName = lastName;
        student.Age = age;
        student.City = city;
    }

    command = Console.ReadLine().Split(' ');
}

string filterCity = Console.ReadLine();

List<Student> filteredStudents = students.Where(n => n.City == filterCity).ToList();

foreach (Student student in filteredStudents) {
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}