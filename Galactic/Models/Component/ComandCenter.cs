using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic.Models.Component
{
    public class ComandCenter : IModuls
    {

        public string Name { get; set; }
        public int Protect { get; set; }
        public int Price { get; set; }
        public int Level { get; set; }
        public bool isBuy { get; set; }
        public Image ImageModuls { get; set; }

        private int _limCorpus;
        
        public ComandCenter()
        {
            Name = "Командный центр";
            Price = 100;
            Protect = 10;
            Level = 1;
            _limCorpus = 4;
            isBuy = false;
            ImageModuls = Properties.Resources.Command_Center;
        }

        public void Upgrate()
        {
            if (Level==1)
            {
                Price = 300;
                Protect = 20;
                Level = 2;
                _limCorpus = 8;
            }
            else if(Level==2)
            {
                Price = 900;
                Protect = 30;
                Level = 3;
                _limCorpus = 12;
            }
        }
    }
}
