namespace Homework_1;

public class Task1_1
{
    public Task1_1()
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int j = i+1; j <= 9; j++)
            {
                for (int k = j+1; k <= 9; k++)
                {
                    for (int l = k+1; l <= 9; l++)
                    {
                        Console.WriteLine($"{i}{j}{k}{l}");
                    }
                }
            }
        }
    }
}