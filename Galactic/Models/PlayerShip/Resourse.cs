using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic.Models
{
    public static class Resourse
    {
        public static int Money { get;  set; }
        public static long Energy { get;  set; }
        public static int Mineral { get;  set; }
        static Resourse()
        {
            Money = 2500;
            Energy = 0;
            Mineral = 0;
        }
    }
}
