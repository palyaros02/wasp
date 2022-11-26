namespace Homework_1;

public class Task3_2
{
    public Task3_2()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] array = new int[n];

        Console.WriteLine("Введите массив (через пробел):");
        string[] input = Console.ReadLine()!.Split(' ');
        for (int i = 0; i < n; i++)
            array[i] = int.Parse(input[i]);

        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine()!);
        
        
        int[] mins = new int[k];
        for (int i = 0; i < k; i++)
        {
            int min = Int32.MaxValue;
            for (int j = 0; j < n; j++)
                if (array[j] < min && CheckMinNotInMins(array[j], mins))
                    min = array[j];

            mins[i] = min;
        }
        bool CheckMinNotInMins(int min, int[] mins)
        {
            for (int y = 0; y < mins.Length; y++)
                if (min == mins[y])
                    return false;
            return true;
        }


        Console.WriteLine($"{k}-ый минимум: {mins[k - 1]}");
    }
}
