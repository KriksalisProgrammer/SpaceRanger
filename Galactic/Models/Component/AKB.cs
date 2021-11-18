using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactic.Models.Component;

namespace Galactic.Models.Component
{
    public class AKB:IModuls
    {
        public string Name { get; set; }
        public int Protect { get; set; }
        public int Price { get; set; }
        public int Level { get; set; }
        public bool isBuy { get; set; }
        public Image ImageModuls { get; set; }
        public int MaxEnergy { get; private set; }

        public AKB()
        {
            Name = "Акумулятор";
            Price = 150;
            Protect = 10;
            Level = 1;
            isBuy = false;
            ImageModuls = Properties.Resources.Acum;
            MaxEnergy = 1000;
        }
       

        

        public void Upgrate()
        {
            if (Level == 1)
            {
                Price = 300;
                Protect = 15;
                Level = 2;
                MaxEnergy = 2000;
            }
            else if (Level == 2)
            {
                Price = 450;
                Protect = 20;
                Level = 3;
                MaxEnergy = 3000;
            }
        }
    }
}
