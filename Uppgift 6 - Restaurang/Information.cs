
namespace RestaurantArv
{
    public class Information
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Calories { get; set; }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Calories: {Calories}");
        }

    }
}
