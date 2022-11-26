namespace Homework_1;

public class Task1_3
{    private static bool IsPointInTriangle(int x, int y, int x1, int y1, int x2, int y2, int x3, int y3)
    {
        bool isInside;

        int l1 = (x1 - x) * (y2 - y1) - (x2 - x1) * (y1 - y);
        int l2 = (x2 - x) * (y3 - y2) - (x3 - x2) * (y2 - y);
        int l3 = (x3 - x) * (y1 - y3) - (x1 - x3) * (y3 - y);

        if (l1 == 0 || l2 == 0 || l3 == 0 || (l1 > 0 && l2 > 0 && l3 > 0) || (l1 < 0 && l2 < 0 && l3 < 0))
            isInside = true;
        else
            isInside = false;

        //Console.WriteLine($"x={x}, y={y}, l1={l1}, l2={l2}, l3={l3}, isInside={isInside}");
        return isInside;
    }
    public Task1_3()
    {
        string[] input;

        int x1, y1 = 0;
        int x2, y2 = 0;
        int x3, y3 = 0;

        Console.Write("Координаты точки 1 (через пробел): ");
        input = Console.ReadLine()!.Split();
        x1 = int.Parse(input[0]);
        y1 = int.Parse(input[1]);

        Console.Write("Координаты точки 2 (через пробел): ");
        input = Console.ReadLine()!.Split();
        x2 = int.Parse(input[0]);
        y2 = int.Parse(input[1]);

        Console.Write("Координаты точки 3 (через пробел): ");
        input = Console.ReadLine()!.Split();
        x3 = int.Parse(input[0]);
        y3 = int.Parse(input[1]);

        int maxX = Math.Max(x1, Math.Max(x2, x3));
        int maxY = Math.Max(y1, Math.Max(y2, y3));

        for (int y = 0; y < maxY; y++)
        {
            for (int x = 0; x < maxX; x++)
                Console.Write(IsPointInTriangle(x, y, x1, y1, x2, y2, x3, y3) ? "*" : " ");
            
            Console.WriteLine();
        }
    }
}
