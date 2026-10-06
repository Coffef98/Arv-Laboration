
namespace Arv
{
    public class Information
    {
        public int Registration { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public virtual void PrintInfo() // Virtual betyder att Car & Motorcycle får göra sin egen version av PrintInfo()
        {
            Console.WriteLine($"Registration: {Registration}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Description: {Description}");
        }
       
    }
}
