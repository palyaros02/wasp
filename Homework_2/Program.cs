namespace Homework_2;

internal class Program
{
    public static void Main(string[] args)
    {
        PassengerCar passengerCar1 = new PassengerCar(
            "BMW", 
            "200", 
            "2015", 
            5, 
            new Dictionary<string, int>()
            {
                {"detail_1", 2022},
                {"detail_2", 2020}
            });
        passengerCar1.AddRepairedDetail("detail_3", 2021);

        PassengerCar passengerCar2 = new PassengerCar();
        passengerCar2.Model = "Audi";
        passengerCar2.Year = "2016";
        passengerCar2.Power = "100";
        passengerCar2.NumberOfPassengers = 4;
        passengerCar2.AddRepairedDetail("detail_1", 2022);
        passengerCar2.AddRepairedDetail("detail_2", 2020);
        Console.WriteLine("Вторая машина:\n" + passengerCar2);
        Console.WriteLine("\nДеталь 1: " + passengerCar2.GetYearOfRepairedDetail("detail_1"));
        
        Truck truck1 = new Truck(
            "Kamaz", 
            "500", 
            "2010", 
            1000, 
            "Федоров И.И.",
            new Dictionary<string, int>(){}
            );
        
        Truck truck2 = new Truck();
        truck2.Model = "Belaz";
        truck2.Year = "2015";
        truck2.Power = "1000";
        truck2.LoadCapacity = 2000;
        truck2.ChangeDriver("Иванов И.И.");
        
        Console.WriteLine("\nПервый грузовик:\n" + truck1);
        Console.WriteLine("Изменим грузы");
        truck2.AddCargo("Песок", 300);
        truck2.AddCargo("Гравий", 1000);
        truck2.PrintCargo();
        Console.WriteLine("Добавим песок");
        truck2.AddCargo("Песок", 500); // тут добавим песка
        truck2.PrintCargo();
        Console.WriteLine("Добавим тонну щебня");
        truck2.AddCargo("Щебень", 1000); // тут будет ошибка
        truck2.PrintCargo();
        Console.WriteLine("Уберем 200 кг песка и весь гравий");
        truck2.RemoveCargo("Песок", 200); // уберем 200кг песка
        truck2.RemoveCargo("Гравий"); // уберем весь гравий
        truck2.PrintCargo();
        
        Autopark autopark = new Autopark(
            "Автопарк №1", 
            new List<Car>()
            {
                passengerCar1, passengerCar2, truck1, truck2
            });
        
        Console.WriteLine(autopark);

    }
}
