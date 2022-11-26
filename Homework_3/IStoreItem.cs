namespace Homework_3;

public partial class Program
{
    public interface IStoreItem
    {
        double Price { get; set; }

        void DiscountPrice(int percent)
        {
            Price = Price - Price * percent / 100;
        }
    }
}