using Galactic.Models.IO;
using Galactic.VIew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactic.Models.BattleSystem
{
    public class CombatProcessor
    {
        private Pirates Pirates;
        private ShipBattle ship;
        private Random _rand = new Random();
        public delegate void AttackPirats();
        public event AttackPirats AttackPiratsEvent;
        IoController controller = new IoController();
        public CombatProcessor()
        {
            ship = new ShipBattle();
            Pirates = new Pirates();
            Pirates.comand.isBuy=true;
            Pirates.corpus.isBuy = true;
            Pirates.cannon.isBuy = true;
            Pirates.CalculateStrengthAndAttack();
            ship.AttackEvent += Ship_AttackEvent;
            ship.WinBattleEvent += Ship_WinBattleEvent;
            Pirates.AttackPiratesEvent += Pirates_AttackPiratesEvent;
            Pirates.WinBattlePiratesEvent += Pirates_WinBattlePiratesEvent;
        }

        private void Pirates_WinBattlePiratesEvent()
        {
            Logs.LogsList.Add($"Победа протиника.Здоровье протиника: {Pirates.Strength}.Урон протиника: {Pirates.Damage}");
            ship.AttackEvent -= Ship_AttackEvent;
            ship.WinBattleEvent -= Ship_WinBattleEvent;
            Pirates.AttackPiratesEvent -= Pirates_AttackPiratesEvent;
            Pirates.WinBattlePiratesEvent -= Pirates_WinBattlePiratesEvent;
            Console.WriteLine("Вы проиграли!");
            controller.SerializeAndSave(Ship.NumberButtle,Logs.LogsList);
        }

        private void Ship_WinBattleEvent()
        {
            Ship.collector.AddMineral(1000);
            Logs.LogsList.Add($"Победа игрока.Здоровье игрока: {Ship.Strength}.Урон игрока: {Ship.Damage}");
            ship.AttackEvent -= Ship_AttackEvent;
            ship.WinBattleEvent -= Ship_WinBattleEvent;
            Pirates.AttackPiratesEvent -= Pirates_AttackPiratesEvent;
            Pirates.WinBattlePiratesEvent -= Pirates_WinBattlePiratesEvent;
            Console.WriteLine("Вы победили пирата!");
            controller.SerializeAndSave(Ship.NumberButtle, Logs.LogsList);
        }

        private void Pirates_AttackPiratesEvent()
        {
            MessageBox.Show($"Атака противника.{Pirates.Strength}");
            Logs.LogsList.Add($"Атака противника.Здоровье противника: {Pirates.Strength}.Урон противника: {Pirates.Damage}");
        }

        private void Ship_AttackEvent()
        {
            MessageBox.Show($"Атака игрока!{Ship.Strength}");
            Logs.LogsList.Add($"Атака игрока.Здоровье игрока: {Ship.Strength}.Урон игрока: {Ship.Damage}");
        }

        public bool isPiratsAttack { get; set; }
        public void AttackSystems(Pirates pirates)
        {
           
            if (isPiratsAttack)
            {
                while (!Ship.isDeath && !pirates._isDeath)
                {
                    pirates.Attack();
                    ship.Attack(pirates);
                }
            }
        }
        public void Combat()
        {
            int procent = _rand.Next(0, 100);
            if(procent<30)
            {
                Ship.NumberButtle++;
                MessageBox.Show("Нападение пиратов!");
                AttackPiratsEvent?.Invoke();
                isPiratsAttack = true;
                AttackSystems(Pirates);
            }
            
        }
    }
}
