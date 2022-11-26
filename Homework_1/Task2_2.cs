namespace Homework_1;

public class Task2_2
{
    public static int IntToBinary(int n)
    {
        int[] binary = new int[32];
        for (int i = 0; i < 32; i++)
        {
            binary[i] = n & 1;
            n >>= 1;
        }
        bool isStarted = false;
        int result = 0;
        for (int i = 31; i >= 0; i--)
        {
            if (binary[i] == 1)
                isStarted = true;
            if (isStarted)
            {
                result += binary[i] * (int)Math.Pow(10, i);
            }
        }
        return result;
    }
    public Task2_2()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine()!);

        int s = n + m;
        
        n = IntToBinary(n);
        m = IntToBinary(m);
        s = IntToBinary(s);
        
        int len = s.ToString().Length; 
        for (int i = 0; i < len - n.ToString().Length; i++)
            Console.Write(" ");
        Console.WriteLine(n);
        for (int i = 0; i < len - m.ToString().Length; i++)
            Console.Write(" ");
        Console.WriteLine(m);
        for (int i = 0; i < len; i++)
            Console.Write(".");
        Console.WriteLine();
        Console.WriteLine(s);
    }
}
