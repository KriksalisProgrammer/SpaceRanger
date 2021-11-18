using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic.Models.Map
{
    public enum TypePoint
    {
        StartPosition = 0,
        EmptySpace = -1,
        Destination = -2,
        Path = -3,
        Barrier = -4,
        Ship = -5,
        Station = -6,
        Planet = -7,
        Asteroid=-8
    }
}
