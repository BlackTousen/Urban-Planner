using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Width = 90.50;
            FiveOneTwoEigth.Depth = 80;
            FiveOneTwoEigth.Stories = 2;
            FiveOneTwoEigth.Purchase("Matthew");
            Building FiveOneTwoSixth = new Building("512 6th Avenue");
            FiveOneTwoSixth.Construct();
            FiveOneTwoSixth.Width = 85.50;
            FiveOneTwoSixth.Depth = 100;
            FiveOneTwoSixth.Stories = 2;
            FiveOneTwoSixth.Purchase("Jasmin");
            Building FiveZeroTwoEigth = new Building("502 8th Avenue");
            FiveZeroTwoEigth.Construct();
            FiveZeroTwoEigth.Width = 90.50;
            FiveZeroTwoEigth.Depth = 100;
            FiveZeroTwoEigth.Stories = 2;
            FiveZeroTwoEigth.Purchase("Kenya");
            Building FiveZeroTwoSixth = new Building("502 6th Avenue");
            FiveZeroTwoSixth.Construct();
            FiveZeroTwoSixth.Width = 85.50;
            FiveZeroTwoSixth.Depth = 110;
            FiveZeroTwoSixth.Stories = 2;
            FiveZeroTwoSixth.Purchase("Michael");
            City centralCity = new City("Central City", "Barry Allen");
            centralCity.AddBuilding(FiveOneTwoEigth);
            centralCity.AddBuilding(FiveZeroTwoEigth);
            centralCity.AddBuilding(FiveOneTwoSixth);
            centralCity.AddBuilding(FiveZeroTwoSixth);
            foreach (var building in centralCity.buildings)
            {
                Console.Write($@"
{building.Address}
---------------
Designed by {building.Designer}
Constructed on {building.Date}
Owned by {building.Owner}
{building.Volume} cubic meters of space
");

            }
        }
    }

}
