using Galactic.Models.BattleSystem;
using Galactic.Models.Component;
using System.Windows.Forms;

namespace Galactic.Models
{
    public class Pirates
    {
        public delegate void CombatHandle();
        public event CombatHandle AttackPiratesEvent;
        public event CombatHandle WinBattlePiratesEvent;
        private ShipBattle ship1;
        public  int Strength { get; set; }
        public  int Damage { get; set; }
        public bool _isDeath { get; set; } = false;

        public ComandCenter comand = new ComandCenter();
        public  Corpus corpus = new Corpus();
        public  Engine engine = new Engine();
        public  AKB aKB = new AKB();
        public  Cannon cannon = new Cannon();
        public Collector collector = new Collector();
        public  Store store = new Store();
        public Pirates()
        {
            CalculateStrengthAndAttack();
        }
        public  void CalculateStrengthAndAttack()
        {
            for (var i = 0; i < Moduls.moduls.Count; i++)
            {
                if (Moduls.moduls[i].isBuy)
                {
                    Strength += Moduls.moduls[i].Protect;
                    Damage = cannon.Damage;
                }
            }
        }
        public void Attack()
        {
            if (Ship.Strength > Damage)
            {
                Ship.Strength -= Damage;
                AttackPiratesEvent?.Invoke(); 
            }
            else
            {
                Ship.isDeath = true;
                WinBattlePiratesEvent?.Invoke();
            }
        }

    }
}
