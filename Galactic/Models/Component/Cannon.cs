using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic.Models.Component
{
    public class Cannon:IModuls
    {
        public string Name { get; set; }
        public int Protect { get; set; }
        public int Price { get; set; }
        public int Level { get; set; }
        public bool isBuy { get; set; }
        public Image ImageModuls { get; set; }
        public int Damage { get; private set; }
        public Cannon()
        {
            Name = "Пушка";
            Price = 150;
            Protect = -5;
            Level = 1;
            isBuy = false;
            Damage = 50;
            ImageModuls = Properties.Resources.Сannon;
        }


        public void Upgrate()
        {
            if (Level == 1)
            {
                Price = 270;
                Protect = -3;
                Level = 2;
                Damage = 60;
            }
            else if (Level == 2)
            {
                Price = 486;
                Protect = -1;
                Level = 3;
                Damage = 75;
            }
        }
    }
}
