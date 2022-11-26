namespace Homework_1;

public class Task2_4
{
    public Task2_4()
    {
        Console.Write("Введите число типа long: ");
        long result = long.Parse(Console.ReadLine()!);
        
        short d = (short)(result >> 16 *3 );
        short c = (short)(result << 16 >> 16 * 3);
        short b = (short)(result << 16 * 2 >> 16 * 3);
        short a = (short)(result << 16 * 4);

        Console.WriteLine($"Результат распаковки: {a}, {b}, {c}, {d}");
    }
}
