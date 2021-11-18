using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic.Models.Component
{
    internal interface IModuls
    {
        Image ImageModuls { get; set; }
        string Name { get; set; }
        int Protect { get; set; }
        int Price { get; set; }
        int Level { get; set; }
        bool isBuy { get; set; }
        void Upgrate();

    }
}
