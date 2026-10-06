
namespace Hired
{
    public class ProjectManager : Roller
    {
        public int Projects { get; set; }
        public ProjectManager(string namn, int anställingsnummer, double lön, int projects)
        {
            Namn = namn;
            Anställningsnummer = anställingsnummer;
            Lön = lön;
            Projects = projects;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Projects: {Projects}");
        }
    }
}
