namespace Homework_1;

public class Task1_4
{
    public Task1_4()
    {
        Console.Write("Введите количество строк треугольника Паскаля: ");
        int n = int.Parse(Console.ReadLine()!);
        int[][] pascalTriangle = new int[n][];
        
        for (int i = 0; i < n; i++)
        {
            pascalTriangle[i] = new int[i + 1];
            pascalTriangle[i][0] = 1;
            pascalTriangle[i][i] = 1;
            for (int j = 1; j < i; j++)
                pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];            
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < pascalTriangle[i].Length; j++)
                Console.Write(pascalTriangle[i][j] + " ");
            Console.WriteLine();
        }
    }
}
