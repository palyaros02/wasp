namespace Homework_2;

public class PassengerCar : Car
{
    public int NumberOfPassengers { get; set; }
    public Dictionary<string, int> TechnicalPassport { get; set; } // <detail_ame, year_of_repair>

    public PassengerCar(
        string model, 
        string power, 
        string year, 
        int numberOfPassengers, 
        Dictionary<string, int> technicalPassport
        ) : base(model, power, year)
    {
        NumberOfPassengers = numberOfPassengers;
        TechnicalPassport = technicalPassport;
    }

    public PassengerCar() : base()
    {
        NumberOfPassengers = 0;
        TechnicalPassport = new Dictionary<string, int>();
    }

    public override string ToString()
    {
        return base.ToString() + "\n" +
               $"Количество пассажиров: {NumberOfPassengers}\n" +
               $"Ремонтная книжка: {(_GetTechnicalPassport() == "" ? "отсутствует" : _GetTechnicalPassport())}";
    }
    
    public bool AddRepairedDetail(string detail, int year)
    {
        return TechnicalPassport.TryAdd(detail, year);
    }
    
    public int GetYearOfRepairedDetail(string detail)
    {
        return TechnicalPassport[detail];
    }
    
    private string _GetTechnicalPassport()
    {
        string result = "";
        foreach (KeyValuePair<string, int> item in TechnicalPassport)
            result += $"\n\t{item.Key} : {item.Value} г.";
        return result;
    }
    
    public void PrintTechnicalPassport()
    {
        Console.Write($"Ремонтная книжка машины {Model}:");
        Console.WriteLine(_GetTechnicalPassport());
    }
}
