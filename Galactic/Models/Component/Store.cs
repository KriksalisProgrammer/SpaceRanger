using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic.Models.Component
{
    public class Store:IModuls
    {
        public string Name { get; set; }
        public int Protect { get; set; }
        public int Price { get; set; }
        public int Level { get; set; }
        public bool isBuy { get; set; }
        public Image ImageModuls { get; set; }
        public int MaxMineral { get; private set; }
        public Store()
        {
            Name = "Хранилище";
            Price = 50;
            Protect = 10;
            Level = 1;
            isBuy = false;
            ImageModuls = Properties.Resources.Storage;
            MaxMineral = 2000;
        }


        public void Upgrate()
        {
            if (Level == 1)
            {
                Price = 65;
                Protect = 15;
                Level = 2;
                MaxMineral = 3000;
            }
            else if (Level == 2)
            {
                Price = 85;
                Protect = 20;
                Level = 3;
                MaxMineral =4000;
            }
        }
    }
}
