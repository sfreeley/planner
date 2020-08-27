using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string Name { get; set; }

        public string Mayor { get; set; }

        public int Year { get; set; }

        public List<Building> Buildings { get; set; }

        public City()
        {
            Buildings = new List<Building>();
        }

        //method
        public void addBuilding(Building aBuilding)
        {
            Buildings.Add(aBuilding);
        }

    }

}