using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInfo_GetValue
{
    public class Planet
    {
        private string planetName;
        private double distanceFromEarth;

        public Planet(string name, double distance)
        {
            planetName = name;
            distanceFromEarth = distance;
        }

        public string Name
        {
            get
            {
                return planetName;
            }
        }

        public double Distance
        {
            get
            {
                return distanceFromEarth;
            }
            set
            {
                distanceFromEarth = value;
            }
        }
    }
}
