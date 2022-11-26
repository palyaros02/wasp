namespace Homework_1;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задачу для проверки");
        Console.WriteLine("Доступные задачи: 1_1, 1_2, 1_3, 1_4, " +
                          "2_1, 2_2, 2_3, 2_4, 2_5, " +
                          "3_1, 3_2, 3_3");
        Console.WriteLine("Для выхода введите exit");
        while (true)
        {
            Console.Write("Задача: ");
            string? task = Console.ReadLine();
            switch (task)
            {
                case "1_1":
                    _ = new Task1_1();
                    break;
                case "1_2":
                    _ = new Task1_2();
                    break;
                case "1_3":
                    _ = new Task1_3();
                    break;
                case "1_4":
                    _ = new Task1_4();
                    break;
                case "2_1":
                    _ = new Task2_1();
                    break;
                case "2_2":
                    _ = new Task2_2();
                    break;
                case "2_3":
                    _ = new Task2_3();
                    break;
                case "2_4":
                    _ = new Task2_4();
                    break;
                case "2_5":
                    _ = new Task2_5();
                    break;
                case "3_1":
                    _ = new Task3_1();
                    break;
                case "3_2":
                    _ = new Task3_2();
                    break;
                case "3_3":
                    _ = new Task3_3();
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("Задачи с таким именем не существует");
                    break;
            }
            Console.WriteLine();
        }
    }
}
