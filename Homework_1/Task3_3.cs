namespace Homework_1;

public class Task3_3
{
    public Task3_3()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine()!);
        
        int[] array = new int[n];
        Console.WriteLine("Введите элементы массива:");
        string[] input = Console.ReadLine()!.Split(' ');
        for (int i = 0; i < n; i++)
            array[i] = int.Parse(input[i]);
        
        Console.WriteLine("Введите строку вида \"число:число:число\":");
        string[] input2 = Console.ReadLine()!.Split(':');
        int start = int.Parse(input2[0]);
        int end = int.Parse(input2[1]);
        int step = int.Parse(input2[2]);
        
        int[] newArray = new int[end - start + 1];
        for (int i = start; i <= end; i++)
            newArray[i-start] = array[i];
        
        Console.WriteLine("Новый массив:");
        if (step > 0)
            for (int i = 0; i < newArray.Length; i += step)
                Console.Write($"{newArray[i]} ");
        else
            for (int i = newArray.Length - 1; i >= 0; i += step)
                Console.Write($"{newArray[i]} ");
    }
}
