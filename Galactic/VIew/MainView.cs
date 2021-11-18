using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactic.Models;
using Galactic.Models.Map;
using Galactic.VIew;

namespace Galactic.VIew
{
    public partial class MainView : Form
    {
        GenerateMap map = new GenerateMap();
        public MainView()
        {
            InitializeComponent();
            Init();
            map.Init(this);
            Ship.engine.EnergyConsumptionEvent += Map_Move;
            Ship.collector.CollectionMaterialEvent += Collector_CollectionMaterialEvent;
           
        }

       

        private void Collector_CollectionMaterialEvent()
        {
            Init();
        }

        private void Map_Move()
        {
            Init();
        }

        public void Init()
        {
            labelCrypt.Text = "Крипта: "+Resourse.Money.ToString();
            labelEnergy.Text = "Енергия: " + Resourse.Energy.ToString();
            labelMineral.Text = "Ресурсы: " + Resourse.Mineral.ToString();
            labelProtect.Text = "Прочность: " + Ship.Strength.ToString();
        }
        private void buttonBuyComponent_Click(object sender, EventArgs e)
        {
            GalacticShop galacticShop = new GalacticShop();
            if(galacticShop.ShowDialog()==DialogResult.Cancel)
            {
                galacticShop.Init();
                Init();
            }
        }

        private void labelProtect_Click(object sender, EventArgs e)
        {

        }
    }
}
