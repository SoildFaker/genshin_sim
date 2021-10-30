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
    public partial class fmEnemyList : Form
    {
        public fmEnemyList()
        {
            InitializeComponent();
        }

        public Enemy Enemy { get; private set; }
        public Image EnemyImage { get; private set; }

        private int[] images_index = new int[] { 0 };

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (lstEnemies.SelectedItems.Count > 0)
            {
                fmReturn();
            }
        }

        private void fmReturn()
        {
            this.DialogResult = DialogResult.OK;
            int index = lstEnemies.SelectedItems[0].Index;
            this.Enemy = EnemyFactory.Enemies[index];
            this.EnemyImage = imEnemies.Images[images_index[index]];
            this.Close();
        }

        private void fmEnemyList_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < EnemyFactory.Enemies.Length; i++)
            {
                this.lstEnemies.Items.Add(new ListViewItem(EnemyFactory.Enemies[i].Name, images_index[i]));
            }
        }

        private void lstEnemies_DoubleClick(object sender, EventArgs e)
        {
            if (lstEnemies.SelectedItems.Count > 0)
            {
                fmReturn();
            }
        }
    }
}
