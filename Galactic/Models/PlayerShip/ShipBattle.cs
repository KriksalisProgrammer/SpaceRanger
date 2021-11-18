using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactic.Models
{
     public class ShipBattle:Ship
    {
        public delegate void CombatHandle();
        public  event CombatHandle AttackEvent;
        public  event CombatHandle WinBattleEvent;
        public ShipBattle()
        {
        }
        public void Attack(Pirates pirates)
        {
            if (pirates.Strength > Damage)
            {
                pirates.Strength -= Damage;
                AttackEvent?.Invoke();
            }
            else
            {
                pirates._isDeath = true;
                WinBattleEvent?.Invoke();
            }
        }

    }
}
