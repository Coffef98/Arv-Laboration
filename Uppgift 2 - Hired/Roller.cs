
namespace Hired
{
    public class Roller
    {
        public string Namn { get; set; }
        public int Anställningsnummer { get; set; }
        public double Lön { get; set; }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Namn: {Namn}");
            Console.WriteLine($"Anställningsnummer: {Anställningsnummer}");
            Console.WriteLine($"Lön: {Lön}");
           
        }
    }
}
