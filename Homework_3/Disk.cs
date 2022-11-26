namespace Homework_3;

public partial class Program
{
    public class Disk : IStoreItem
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int BurnCount { get; set; }

        public Disk(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }

        public double Price { get; set; }
        public virtual int DiskSize { get; }

        public virtual void Burn(params string[] values)
        {
        }

        public void DiscountPrice(int percent)
        {
            Price = Price - Price * percent / 100;
        }
    }
}