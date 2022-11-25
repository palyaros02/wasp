public class Task2_5
{
    public Task2_5()
    {
        Console.Write("Введите число типа long: ");
        long n = long.Parse(Console.ReadLine());
        Console.Write("Введите первое число m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число k: ");
        int k = int.Parse(Console.ReadLine());

        ulong mByte = (ulong)((n << m * 8) >> 56 << 56) >> k * 8;
        ulong kByte = (ulong)((n << k * 8) >> 56 << 56) >> m * 8;

        ulong mask = ~((ulong)(0xFF) << (7 - m) * 8 | (ulong)(0xFF) << (7 - k) * 8);

        ulong result = (ulong)n & mask | mByte | kByte;

        Console.WriteLine($"Результат: {result}");
    }
}

