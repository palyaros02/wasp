namespace Homework_3;

public partial class Program
{
    public static void Main(string[] args)
    {
        Store store = new Store("Рога и Копыта", "Москва, ул. Ленина, д. 1");
        
        store += new Audio("Классика для души", "Классика", "Моцарт В.А.", "Мелодия", 10);
        store += new Audio("Большая сборка", "Рок", "AC/DC", "Sony", 15);
        store += new Audio("Хиты 90-х", "Поп", "Баста", "Sony", 12);
        
        store += new Dvd("Красавица и Чудовище", "Фэнтези", "Дисней", "Disney", 120);
        store += new Dvd("Мстители", "Фантастика", "Марвел", "Sony", 210);
        store += new Dvd("Матрица", "Фантастика", "Вин Дизель", "Sony", 190);
        
        Console.WriteLine(store);
        
        Console.WriteLine("\nЗаменим Классику для души");
        store.Audios[0].Burn("Популярная музыка", "Поп", "ABBA", "неSony", "15");
        Console.WriteLine(store.Audios[0]);
        
        
        Console.WriteLine("\nВывод аудио:");
        foreach (Audio audio in store.Audios)
            Console.WriteLine($"{audio.Name} -> {audio.DiskSize}");
        
        Console.WriteLine("\nВывод DVD:");
        foreach (Dvd dvd in store.Dvds)
            Console.WriteLine($"{dvd.Name} -> {dvd.DiskSize}");
    }
}
