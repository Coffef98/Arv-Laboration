
namespace RestaurantArv
{
    public class McFood : Information
    {
        public string Food { get; set; }
        public string Size { get; set; }

        public McFood(string name,double price, int calories, string food, string size)
        {
            Name = name;
            Price = price;
            Calories = calories;
            Food = food;
            Size = size;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Food: {Food}");
            Console.WriteLine($"Size: {Size}");
        }
    }
}
