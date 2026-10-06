
namespace RestaurantArv
{
    internal class McDrinks : Information
    {
        public string Drinks { get; set; }
        public bool Carbonated { get; set; }

        public McDrinks(string name,double price, int calories, string drinks, bool carbonated)
        {
            Name = name;
            Price = price;
            Calories = calories;
            Drinks = drinks;
            Carbonated = carbonated;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Drinks: {Drinks}");
            Console.WriteLine($"Carbonated: {Carbonated}");
        }
    }
}
