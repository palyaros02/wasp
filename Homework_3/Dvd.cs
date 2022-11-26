namespace Homework_3;

public partial class Program
{
    public class Dvd : Disk
    {
        public string Producer { get; set; }
        public string FilmCompany { get; set; }
        public int MinutesCount { get; set; }

        public Dvd(
            string name,
            string genre,
            string producer,
            string filmCompany,
            int minutesCount) : base(name, genre)
        {
            Producer = producer;
            FilmCompany = filmCompany;
            MinutesCount = minutesCount;
        }

        public override int DiskSize => MinutesCount / 64 * 2;

        public override void Burn(params string[] values)
        {
            Name = values[0];
            Genre = values[1];
            Producer = values[2];
            FilmCompany = values[3];
            MinutesCount = int.Parse(values[4]);
            BurnCount++;
        }

        public override string ToString()
        {
            return $"Название: {Name}\n" +
                   $"Жанр: {Genre}\n" +
                   $"Режиссер: {Producer}\n" +
                   $"Кинокомпания: {FilmCompany}\n" +
                   $"Количество минут: {MinutesCount}\n" +
                   $"Количество прожигов: {BurnCount}";
        }
    }
}