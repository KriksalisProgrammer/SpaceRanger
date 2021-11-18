using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic.Models.Planet
{
    public class PlanetInMap
    {
        public string Name { get; private set; }
        private Random rand = new Random();
        public PlanetInMap()
        {
            Name = (string)Enum.Parse(typeof(NamePlanet), rand.Next(1, 9).ToString());
            
        }
    }
}
