namespace Homework_2;

public class Autopark
{
    public string Name { get; set; }
    public List<Car> Cars { get; set; }
    
    public Autopark(string name, List<Car> cars)
    {
        Name = name;
        Cars = cars;
    }

    public override string ToString()
    {
        string cars = "";
        int i = 1;
        foreach (Car car in Cars)
        {
            cars += $"\n{i}. {car}\n";
            i++;
        }
        return $"Автопарк: {Name}\nМашины: {cars}";
    }
}
