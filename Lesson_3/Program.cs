using ConsoleApp;
using WaspTutorial;

// ООП

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Red", "BMW", 4);
            Car car2 = new();
            Car car3 = new Car("Black");
            Car car4 = new Car() { 
                Name = "Audi", 
                Color = "White", 
                NumberOfWheels = 4 
            }; // инициализатор объекта

            Console.WriteLine(car1.ToString());

            //car.SetName("BMW");
            //Console.WriteLine(car.GetName());

            //car.Name = "BMW";
            //Console.WriteLine(car.Name);
            Console.WriteLine();

            Human h1 = new Oldman(20, 100, 180, 80);
            Oldman oldman = h1 as Oldman; // приведение типов
            oldman.Pension(34);
        }
    }
}