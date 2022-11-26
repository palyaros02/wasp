namespace Homework_3;

public partial class Program
{
    public class Store
    {
        public string StoreName { get; set; }
        public string Address { get; set; }
        public List<Audio> Audios { get; set; }
        public List<Dvd> Dvds { get; set; }

        public Store(string storeName, string address)
        {
            StoreName = storeName;
            Address = address;
            Audios = new List<Audio>();
            Dvds = new List<Dvd>();
        }

        public static Store operator +(Store store, Audio audio)
        {
            store.Audios.Add(audio);
            return store;
        }

        public static Store operator -(Store store, Audio audio)
        {
            store.Audios.Remove(audio);
            return store;
        }

        public static Store operator +(Store store, Dvd dvd)
        {
            store.Dvds.Add(dvd);
            return store;
        }

        public static Store operator -(Store store, Dvd dvd)
        {
            store.Dvds.Remove(dvd);
            return store;
        }

        public override string ToString()
        {
            string audios = "";
            int i = 1;
            foreach (Audio audio in Audios)
            {
                audios += $"\n{i}. {audio}";
                i++;
            }

            string dvds = "";
            i = 1;
            foreach (Dvd dvd in Dvds)
            {
                dvds += $"\n{i}. {dvd}";
                i++;
            }

            return $"Магазин: {StoreName}, " +
                   $"Адрес: {Address}, " +
                   $"\nАудиодиски:{audios} " +
                   $"\nФильмы:{dvds}";
        }
    }
}
