using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooMag.Controller;

namespace ZooMag.View
{
    public partial class WeaponShopView : Form
    {
        WeaponShopController controller = new WeaponShopController();
        public WeaponShopView()
        {
            InitializeComponent();
        }

        private void WeaponShopView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'weaponsDBDataSet.Weapon' table. You can move, or remove it, as needed.
            this.weaponTableAdapter.Fill(this.weaponsDBDataSet.Weapon);
            dgvWeapons.DataSource = controller.GetWeapons();


        }
    }
}
