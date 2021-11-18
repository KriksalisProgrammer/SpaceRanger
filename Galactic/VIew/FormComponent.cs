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
using Galactic.Models.Component;

namespace Galactic.VIew
{
    public partial class FormComponent : UserControl
    {
        
        
        [Category("Custom Props")]
        public Image ImageModuls { get { return ImageModuls; } set { pictureBox1.Image = value; } }
        [Category("Custom Props")]
        public string Level { get { return Level; } set { labelLavel.Text = value; } }
        [Category("Custom Props")]
        public string Name { get { return Name; } set { labelNameComponent.Text = value; } }
        [Category("Custom Props")]
        public string Price { get { return Price; } set { labelPrice.Text = value; } }
        [Category("Custom Props")]
        public string PriceNextLevel { get { return PriceNextLevel; } set { buttonUpgrate.Text = value; } }

        public FormComponent()
        {
            InitializeComponent();
            
        }
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            BuyAndUpgrateControler controler = new BuyAndUpgrateControler();
            IModuls moduls= FindObject();
            controler.ComponentBuy += Controler_ComponentBuy;
            controler.BuyComponent(moduls);
            buttonBuy.Enabled = false;
        }

        private void Controler_ComponentBuy(object sender, EventArgs e)
        {
            Ship.engine.EnergyInit();
            Ship.CalculateStrengthAndAttack();
        }

        private void buttonUpgrate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("В следующих версиях");
        }

        private void labelLavel_Click(object sender, EventArgs e)
        {

        }
       
        private IModuls FindObject()
        {
            IModuls moduls = Moduls.moduls.Find(x => x.Name == labelNameComponent.Text);
            return moduls;
        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
