namespace Lesson_4;

/*
 * В интерфейсе можно определять константы, которые будут доступны в классе, который реализует этот интерфейс
 * и список методов
 *
 * Все методы должны быть переопределены в классе, который реализует интерфейс
 * Можно наследовать несколько интерфейсов
 *
 * В интерфейсе может быть реализация по-умолчанию, для нее не обязательно переопределять метод в классе
 */

internal static class Program
{
    static void Main(string[] args)
    {
        IMovable movable = new Vehicle();
        movable.Move();
        Vehicle vehicle = movable as Vehicle;
        vehicle.Move();

        Man man = new Man();
        man.Work();
        IEmployee employee = man;
        employee.Work();
        IEmployer employer = man;
        employer.Work();
    }
}

public interface IMovable
{
    protected const int _speed = 0;
    int Speed { get; set; }

    void Move()
    {
        
    }
}

public interface ISwimmable
{

}

public class Vehicle : IMovable
{
    public int Speed { get; set; }

    public void Move()
    {
        int x = IMovable._speed;
        Console.WriteLine("Реализация объекта");
    }
    
    void IMovable.Move()
    {
        Console.WriteLine("Реализация по-умолчанию IMovable");
    }
    
    public Vehicle()
    {
    }
}

public class Car : Vehicle
{
    public new void Move() { }
}

public class Boat : Vehicle
{
    public new void Move() { }
}

public class Person : IMovable, ISwimmable
{
    public int Speed { get; set; }

    // public void Move() { } // использование реализации по-умолчанию

    public void Swim() { } 
}


// Несколько интерфейсов с одинаковыми методами
public interface IEmployee
{
    void Work();
}

public interface IEmployer
{
    void Work();
}

public class Man : IEmployee, IEmployer
{
    public void Work() => Console.WriteLine("Работаю как человек");
    void IEmployee.Work() => Console.WriteLine("Работаю как сотрудник");
    void IEmployer.Work() => Console.WriteLine("Работаю как работодатель");
}
