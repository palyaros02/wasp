namespace Homework_3;

public partial class Program
{
    public class Audio : Disk
    {
        public string Artist { get; set; }
        public string RecordingStudio { get; set; }
        public int SongsNumber { get; set; }

        public Audio(
            string name,
            string genre,
            string artist,
            string recordingStudio,
            int songsNumber) : base(name, genre)
        {
            Artist = artist;
            RecordingStudio = recordingStudio;
            SongsNumber = songsNumber;
        }

        public override int DiskSize => SongsNumber * 8;

        public override void Burn(params string[] values)
        {
            Name = values[0];
            Genre = values[1];
            Artist = values[2];
            RecordingStudio = values[3];
            SongsNumber = int.Parse(values[4]);
            BurnCount++;
        }

        public override string ToString()
        {
            return $"Название: {Name}\n" +
                   $"Жанр: {Genre}\n" +
                   $"Исполнитель: {Artist}\n" +
                   $"Студия звукозаписи: {RecordingStudio}\n" +
                   $"Количество песен: {SongsNumber}\n" +
                   $"Количество прожигов: {BurnCount}";
        }
    }
}