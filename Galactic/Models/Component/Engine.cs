using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactic.Models.Component
{
    public class Engine: IModuls
    {
        public delegate void MoveHandler();
        public event MoveHandler EnergyConsumptionEvent;

        public string Name { get; set; }
        public int Protect { get; set; }
        public int Price { get; set; }
        public int Level { get; set; }
        public bool isBuy { get; set; }
        public int EnergyConsMap { get; private set; }
        public int EnergyConsBattle { get; private set; }
        public Image ImageModuls { get; set; }

        public Engine()
        {
            Name = "Двигатель";
            Price = 200;
            Protect = -10;
            Level = 1;
            isBuy = false;
            EnergyConsMap = 50;
            EnergyConsBattle = 10;
            ImageModuls = Properties.Resources.Generator;
        }

        public void Upgrate()
        {
            if (Level == 1)
            {
                Price = 300;
                Protect = -8;
                Level = 2;
                EnergyConsMap = 48;
                EnergyConsBattle = 8;
            }
            else if (Level == 2)
            {
                Price = 450;
                Protect = -5;
                Level = 3;
                EnergyConsMap = 45;
                EnergyConsBattle = 6;
            }
        }
        public void EnergyInit()
        {
            if(isBuy)
            {
                Resourse.Energy = 5000;
            }
        }
        public bool EnergyConsumpMap(int point)
        {
            if (Resourse.Energy >= (point * (EnergyConsMap)))
            {
                Resourse.Energy -= (point * (EnergyConsMap));
                EnergyConsumptionEvent?.Invoke();
                return true;
            }
            else
            {
                MessageBox.Show("Не хватает Енергии!");
                return false;
            }
        }
        public void EnergyConsumpFight(int energy)
        {
            if(energy>=EnergyConsBattle)
            {
                energy -= EnergyConsBattle;
                EnergyConsumptionEvent?.Invoke();
            }
        }
    }
}
