using Songs;

int n = int.Parse(Console.ReadLine());

List<Song> songs = new List<Song>();

for (int i = 0; i < n; i++) {
    string[] data = Console.ReadLine().Split('_');

    string type = data[0];
    string name = data[1];
    string time = data[2];

    Song song = new Song();

    song.TypeList = type;
    song.Name = name;
    song.Time = time;

    songs.Add(song);
}

string typeList = Console.ReadLine();

if (typeList == "all") {
    foreach (Song song in songs) {
        Console.WriteLine(song.Name);
    }
} else {

    List<Song> filteredSongs = songs.Where(n => n.TypeList == typeList).ToList();
    foreach (Song song in filteredSongs) {
        Console.WriteLine(song.Name);
    }
}