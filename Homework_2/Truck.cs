namespace Homework_2;

public class Truck : Car
{
    public int LoadCapacity { get; set; }
    public string DriverName { get; set; }
    public Dictionary<string, int> Cargo { get; set; } // <name, weight>
    
    public Truck(
        string model, 
        string power, 
        string year, 
        int loadCapacity, 
        string driverName, 
        Dictionary<string, int> cargo
        ) : base(model, power, year)
    {
        LoadCapacity = loadCapacity;
        DriverName = driverName;
        Cargo = cargo;
    }

    public Truck() : base()
    {
        LoadCapacity = 0;
        DriverName = "Unknown";
        Cargo = new Dictionary<string, int>();
    }
    
    public void ChangeDriver(string newDriverName)
    {
        DriverName = newDriverName;
    }
    
    private int _getCarryingCapacity()
    {
        int carryingCapacity = 0;
        foreach (var item in Cargo)
        {
            carryingCapacity += item.Value;
        }
        return carryingCapacity;
    }
    
    public bool AddCargo(string name, int weight)
    {
        if (weight + _getCarryingCapacity() > LoadCapacity)
        {
            Console.WriteLine("Машина перегружена");
            return false;
        }
        
        if (Cargo.ContainsKey(name))
        {
            Console.WriteLine("Такой груз есть, добавляем вес");
            Cargo[name] += weight;
        }
        else
            return Cargo.TryAdd(name, weight);
        return true;
    }
    
    public bool RemoveCargo(string name, int weight)
    {
        if (!Cargo.ContainsKey(name))
        {
            Console.WriteLine("Такого груза нет");
            return false;
        }
        
        if (Cargo[name] < weight)
        {
            Console.WriteLine("Недостаточно груза");
            return false;
        }
        
        Cargo[name] -= weight;
        
        if (Cargo[name] == 0)
            Cargo.Remove(name);
        return true;
    }
    
    public bool RemoveCargo(string name) // по наименованию
    {
        if (!Cargo.ContainsKey(name))
        {
            Console.WriteLine("Такого груза нет");
            return false;
        }
        
        Cargo.Remove(name);
        return true;
    }

    private string _GetCargo()
    {
        string result = "";
        foreach (KeyValuePair<string, int> cargo in Cargo)
            result += $"\n\t{cargo.Key} : {cargo.Value} кг.";
        return result;
    }
    
    public void PrintCargo()
    {
        Console.Write($"Груз в машине {Model}:");
        Console.WriteLine(_GetCargo());
    }

    public override string ToString()
    {
        return base.ToString() + "\n" +
               $"Водитель: {DriverName}\n" +
               $"Грузоподъемность: {LoadCapacity} кг.\n" +
               $"Груз в машине: {(_GetCargo() == "" ? "нет" : _GetCargo())}";
    }
}
