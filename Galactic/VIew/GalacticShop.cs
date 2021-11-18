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
    public partial class GalacticShop : Form
    {
        
        BuyAndUpgrateControler controler = new BuyAndUpgrateControler();
        public GalacticShop()
        {
            InitializeComponent();
            Init();
            populateItems();
           
        }
        public void Init()
        {
            labelMoney.Text = Resourse.Money.ToString();
        }
        private void populateItems()
        {
            flowLayoutPanel1.Controls.Clear();
            FormComponent[] formComponents = new FormComponent[10];
            for(var i=0;i<Moduls.moduls.Count;i++)
            {
                formComponents[i] = new FormComponent();
                formComponents[i].ImageModuls = Moduls.moduls[i].ImageModuls;
                formComponents[i].Name = Moduls.moduls[i].Name;
                formComponents[i].Level =Moduls.moduls[i].Level.ToString();
                formComponents[i].Price = Moduls.moduls[i].Price.ToString();
                if(flowLayoutPanel1.Controls.Count<0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                flowLayoutPanel1.Controls.Add(formComponents[i]);
            }
            
        }
    }
}
