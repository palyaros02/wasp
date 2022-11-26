namespace Homework_1;

public class Task2_1
{
    public Task2_1()
    {
        Console.Write("Введите целое число: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine(Task2_2.IntToBinary(n));
    }
}
