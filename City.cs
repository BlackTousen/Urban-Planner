using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        private string _name;
        private string _mayor;
        private DateTime _established = new DateTime(1771, 02, 12);
        public List<Building> buildings { get; set; } = new List<Building>();
        public City(string name, string mayor)
        {
            _name = name;
            _mayor = mayor;
        }
        public DateTime Established()
        {
            return this._established;
        }
        public string Mayor()
        {
            return this._mayor;
        }
        public string Name()
        {
            return this._name;
        }
        public void AddBuilding(Building test)
        {
            buildings.Add(test);
        }

    }
}