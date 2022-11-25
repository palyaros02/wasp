namespace Lesson_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else if (a < b)
            {
                Console.WriteLine("a < b");
            }
            else
            {
                Console.WriteLine("a = b");
            }

            Console.WriteLine(a > b ? "a > b" : a < b ? "a < b" : "a = b");

           switch (a) {
            case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторник");
                break;
            case 3:
                Console.WriteLine("Среда");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятница");
                break;
            case 6:
                Console.WriteLine("Суббота");
                break;
            case 7:
                Console.WriteLine("Воскресенье");
                break;
            default :
                Console.WriteLine("Нет такого дня недели");
                break;
           }
            

            // int a = Convert.ToInt32(Console.ReadLine());
            // int sum = 1;
            // while (a > 0)
            // {
            //     sum *= a;
            //     a--;
            // } факториал
            // Console.WriteLine(sum);

            // int a = 0;
            // int sum = 0;
            // do
            // {
            //     sum += a;
            //     a--;
            // } while (a != -1);

            // Console.WriteLine(sum); -- посмотреть в записи

            // int l = Convert.ToInt32(Console.ReadLine());
            // int r = Convert.ToInt32(Console.ReadLine());
            // int step = Convert.ToInt32(Console.ReadLine());

            // for (int i = l; i <= r; i += step)
            // {
            //     Console.Write(i + " ");
            // }

            // битовые операции

            // uint a = Convert.ToUInt32(Console.ReadLine());
            // uint b = Convert.ToUInt32(Console.ReadLine());
            //
            // Console.WriteLine(a & b);
            // Console.WriteLine(a | b);
            // Console.WriteLine(a ^ b);
            //
            // if (a & 1 != 0)
            //     Console.WriteLine("a - нечетное");
            // else
            //     Console.WriteLine("a - четное");
        }
    }
    //     public static void Main(string[] args)
    //     {
    //         byte b = 1; // 8 bit 0-255
    //         short s = 2; // 16 bit -32,768 to 32,767
    //         int a = int.Parse(Console.ReadLine()); // 32 bit
    //         long l = Convert.ToInt64(Console.ReadLine()); // 64 bit -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

    //         // 2^n-1 - диапазон значений

    //         float f = 0.0f; // 32 bit, f обязательно
    //         double d = 0.0; // 64 bit

    //         decimal dc = 15M; // 128 bit, M обязательно

    //         bool bl = true; // true or false
    //         bl = false;

    //         char c = 'a'; // 16 bit, одиночные кавычки
    //         string str = $"{a} + {l} = {a+l}"; // двойные кавычки

    //         /* многострочный
    //         комментарий */


    //         Console.WriteLine("Hello World!");
    //         Console.Write(a);
    //         Console.WriteLine(dc);

    //         Console.ReadLine();
    //         Console.ReadKey();
    //     }
}
