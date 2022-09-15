using System.Text;

List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

while (command[0] != "3:1") {
    switch (command[0]) {
        case "merge": 
            merge(names, int.Parse(command[1]), int.Parse(command[2]));
            break;
        case "divide": 
            divide(names, int.Parse(command[1]), int.Parse(command[2]));
            break;
        default:
            break;
    }
    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
}

Console.WriteLine(String.Join(' ', names));

static void merge(List<string> names, int startIndex, int endIndex) {

    if (startIndex < 0) {
        startIndex = 0;
    }

    if (endIndex > names.Count - 1) {
        endIndex = names.Count - 1;
    }
    
    for (int i = startIndex + 1; i <= endIndex; i++) {
        names[startIndex] += names[startIndex + 1];
        names.RemoveAt(startIndex + 1);
    }
}

static void divide(List<string> names, int index, int parts) {

    string partitionData = names[index];

    names.RemoveAt(index);

    int partSize = partitionData.Length / parts;
    int reminder = partitionData.Length % parts;

    List<string> tmpData = new List<string>();

    StringBuilder tmpString = new StringBuilder();

    for (int i = 0; i < parts; i++) {

        for (int j = 0; j < partSize; j++) {
            tmpString.Append(partitionData[i * partSize + j]);
        }

        if (i == parts - 1 && reminder != 0) {
            tmpString.Append(partitionData.Substring(partitionData.Length - reminder));
        }
        tmpData.Add(tmpString.ToString());
        tmpString.Clear();
    }

    names.InsertRange(index, tmpData);
}