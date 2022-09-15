List<string> courses = Console.ReadLine().Split(", ").ToList();

string[] command = Console.ReadLine().Split(':');

while (command[0] != "course start") {

    switch (command[0]) {
        case "Add": add(courses, command[1]);
            break;
        case "Insert": insert(courses, command[1], int.Parse(command[2]));
            break;
        case "Remove": remove(courses, command[1]);
            break;
        case "Swap": swap(courses, command[1], command[2]);
            break;
        case "Exercise": exercise(courses, command[1]);
            break;
        default:
            break;
    }

    command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
}

for (int i = 0; i < courses.Count; i++) {
    Console.WriteLine($"{i + 1}.{courses[i]}");
}

static void add(List<string> courses, string name) {
    if (!courses.Contains(name)) {
        courses.Add(name);
    }
}

static void insert(List<string> courses, string name, int index) {
    if (!courses.Contains(name)) {
        courses.Insert(index, name);
    }
}

static void remove(List<string> courses, string name) {
    string exercise = name + "-Exercise";
    if (courses.Contains(name)) {
        if (courses.Contains(exercise) && courses.IndexOf(exercise) == courses.IndexOf(name) + 1) {
            courses.Remove(exercise);
        }
        courses.Remove(name);
    }

    
}

static void swap (List<string> courses, string firstCourse, string secondCourse) {
    string firstExercise = firstCourse + "-Exercise";
    string secondExercise = secondCourse + "-Exercise";
    if (courses.Contains(firstCourse) && courses.Contains(secondCourse)) {
        if(courses.Contains(firstExercise) && courses.Contains(secondExercise) && courses.IndexOf(firstExercise) == courses.IndexOf(firstCourse) + 1
            && courses.IndexOf(secondExercise) == courses.IndexOf(secondCourse) + 1) {
            int tmpExcerciseIndex = courses.IndexOf(secondExercise);
            courses[courses.IndexOf(firstExercise)] = secondExercise;
            courses[tmpExcerciseIndex] = firstExercise;
        }
        int tmpCourseIndex = courses.IndexOf(secondCourse);
        courses[courses.IndexOf(firstCourse)] = secondCourse;
        courses[tmpCourseIndex] = firstCourse;
    }
}

static void exercise(List<string> courses, string name) {
    if (courses.Contains(name)) {
        courses.Insert(courses.IndexOf(name) + 1, name + "-Exercise");
    } else {
        courses.Add(name);
        courses.Add(name + "-Exercise");
    }
}