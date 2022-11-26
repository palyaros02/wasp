namespace Homework_1;

public class Task2_3
{
    public Task2_3()
    {
        Console.WriteLine("Введите 4 числа типа short");
        Console.Write("1: ");
        short a = short.Parse(Console.ReadLine()!);
        Console.Write("2: ");
        short b = short.Parse(Console.ReadLine()!);
        Console.Write("3: ");
        short c = short.Parse(Console.ReadLine()!);
        Console.Write("4: ");
        short d = short.Parse(Console.ReadLine()!);

        long result = d;
        result <<= 16;
        result += c;
        result <<= 16;
        result += b;
        result <<= 16;
        result += a;

        Console.WriteLine($"Результат упаковки: {result}");
    }
}
