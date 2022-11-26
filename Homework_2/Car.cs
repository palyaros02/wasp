namespace Homework_2;

public class Car
{
    public string Model { get; set; }
    public string Power { get; set; }
    public string Year { get; set; }

    public Car(string model, string power, string year)
    {
        Model = model;
        Power = power;
        Year = year;
    }
    
    public Car()
    {
        Model = "Unknown";
        Power = "Unknown";
        Year = "Unknown";
    }
    
    public override string ToString()
    {
        return $"Модель: {Model}\n" +
               $"Мощность: {Power} л.с.\n" +
               $"Год пр-ва: {Year}";
    }
}
