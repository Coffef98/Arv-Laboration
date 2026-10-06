
namespace Arv
{
    public class Motorcycle : Information // Motorcycle ärver från Information och alla dess egenskaper
    {
        public string Engine { get; set; }

        public Motorcycle(int registration, string brand, string model, string description, string engine)
        {
            Registration = registration;
            Brand = brand;
            Model = model;
            Description = description;
            Engine = engine;
        }
        public override void PrintInfo() // Override gör sin egen version av PrintInfo();
        {
            base.PrintInfo(); // Kör basklassens PrintInfo. 
            Console.WriteLine($"Engine: {Engine}");
        }
    }
}
