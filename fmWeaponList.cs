using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genshin_sim
{
    public partial class fmWeaponList : Form
    {
        public fmWeaponList(WeaponType type)
        {
            InitializeComponent();
            this.type = type;
        }
        private WeaponType type;
        public Weapon Weapon { get; private set; }
        public Image WeaponImage { get; private set; }
        private int[] images = new int[] { 0 };
        private List<Weapon> weapons;

        private void fmWeaponList_Load(object sender, EventArgs e)
        {
            weapons = WeaponFactory.weapons.Where(x => x.Type == type).ToList();
            for (int i = 0; i < weapons.Count; i++)
            {
                this.lstWeapon.Items.Add(new ListViewItem(weapons[i].Name, images[i]));
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (lstWeapon.SelectedItems.Count > 0)
            {
                fmReturn();
            }
        }

        private void fmReturn()
        {
            this.DialogResult = DialogResult.OK;
            int index = lstWeapon.SelectedItems[0].Index;
            this.Weapon = weapons[index];
            this.WeaponImage = imWeapons.Images[images[index]];
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lstWeapon_DoubleClick(object sender, EventArgs e)
        {
            if (lstWeapon.SelectedItems.Count > 0)
            {
                fmReturn();
            }
        }
    }
}
