namespace Homework_1;

public class Task3_1
{
    public Task3_1()
    {
        Console.Write("Введите n, p (через пробел): ");
        string[] input = Console.ReadLine()!.Split(' ');
        int n = int.Parse(input[0]);
        int p = int.Parse(input[1]);
        
        Console.WriteLine("Введите элементы вектора:");
        input = Console.ReadLine()!.Split(' ');
        double[] vector = new double[n];
        for (int i = 0; i < n; i++)
            vector[i] = double.Parse(input[i]);
        
        double norm = 0;
        for (int i = 0; i < n; i++)
            norm += (int)Math.Pow(vector[i], p);

        norm = Math.Pow(norm, 1.0 / p);

        Console.WriteLine(norm);
    }
}
