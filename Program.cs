using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = 545.43;
            FiveOneTwoEigth.Depth = 890.22;
            FiveOneTwoEigth.Stories = 78;
            FiveOneTwoEigth.Design("Frank Lloyd Wright");
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Joe Schmoe");

            Building OneHundredMain = new Building("100 Main Street");
            OneHundredMain.Width = 45.22;
            OneHundredMain.Depth = 90.10;
            OneHundredMain.Stories = 900;
            OneHundredMain.Design("Chewbacca");
            OneHundredMain.Construct();
            OneHundredMain.Purchase("C3PO");

            City springfield = new City();
            springfield.addBuilding(FiveOneTwoEigth);
            springfield.addBuilding(OneHundredMain);

            foreach (Building building in springfield.Buildings)
            {
                Console.WriteLine("\n");
                building.DisplayInfo();

            }

        }
    }
}