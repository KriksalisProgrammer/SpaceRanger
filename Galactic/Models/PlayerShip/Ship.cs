using Galactic.Models.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactic.Models
{
    public  class Ship
    {
        public static int  Strength { get;  set; }
        public static int Damage { get; private set; }
        public static bool isDeath { get; set; } = false;
        public static int NumberButtle { get; set; }

        public static ComandCenter comand = new ComandCenter();
        public static Corpus corpus = new Corpus();
        public static Engine engine = new Engine();
        public static AKB aKB = new AKB();
        public static Cannon cannon = new Cannon();
        public static Collector collector = new Collector();
        public static Store store = new Store();

        static Ship()
        {
            
        }

        

        public static void CalculateStrengthAndAttack()
        {
            for(var i=0;i<Moduls.moduls.Count;i++)
            {
                if(Moduls.moduls[i].isBuy)
                {
                    Strength += Moduls.moduls[i].Protect;
                    Damage = cannon.Damage;
                }
            }
        }
        

    }
}
