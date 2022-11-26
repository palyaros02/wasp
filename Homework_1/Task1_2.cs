namespace Homework_1;

public class Task1_2
{
    public Task1_2()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{Math.Min(i, j) - Math.Max(i, j) + n} ");
            }
            Console.WriteLine();
        }        
    }
}
