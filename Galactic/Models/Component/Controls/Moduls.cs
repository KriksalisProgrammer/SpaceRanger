using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galactic.Models;

namespace Galactic.Models.Component
{
    static class Moduls
    {
       
        public static List<IModuls> moduls = new List<IModuls>();
        
        static Moduls()
        {
            moduls.Add(Ship.comand);
            moduls.Add(Ship.corpus);
            moduls.Add(Ship.engine);
            moduls.Add(Ship.aKB);
            moduls.Add(Ship.cannon);
            moduls.Add(Ship.collector);
            moduls.Add(Ship.store);
        }
    }
}
