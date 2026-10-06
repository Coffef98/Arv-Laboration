
using System.Threading.Channels;

namespace Arv
{
    public class Car : Information // Car ärver från Information och alla dess egenskaper
    {
        public int Doors { get; set; }

        public Car(int registration, string brand, string model, string description, int doors)
        {
            Registration = registration;
            Brand = brand;
            Model = model;
            Description = description;
            Doors = doors;
        }

        public override void PrintInfo() // Override gör sin egen version av PrintInfo();
        {
            base.PrintInfo(); // Kör basklassens PrintInfo. 
            Console.WriteLine($"Doors: {Doors}");
        }
       
    }
}
