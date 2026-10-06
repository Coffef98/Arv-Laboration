

namespace Hired
{
    public class Developer : Roller
    {
        public string Programmeringsspråk { get; set; }

        public Developer(string namn, int anställningsnummer, double lön, string programmeringsspråk)
        {
            Namn = namn;
            Anställningsnummer = anställningsnummer;
            Lön = lön;
            Programmeringsspråk = programmeringsspråk;

        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Programmeringsspråk: {Programmeringsspråk}");
        }
    }
}
