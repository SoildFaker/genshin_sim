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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Artifact> relics = new List<Artifact>();
        Artifact relic_now;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 20; j++)
            {
                relics.Add(ArtifactFactory.pick());
            }
            relic_now = relics[0];
            refresh_relic_list();
        }

        private void refresh_relic_list()
        {
            lstRelic.Items.Clear();
            for (int i = 0; i < relics.Count; i++)
            {
                lstRelic.Items.Add(i.ToString());
                lstRelic.Items[i].ImageIndex = ((int)relics[i].Type);
                lstRelic.Items[i].SubItems.Add(relics[i].Name);
                lstRelic.Items[i].SubItems.Add(relics[i].Level.ToString());
            }
            get_relic_info();
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            get_relic_info();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            level_up();
        }

        private void get_relic_info()
        {
            lstRelicMinorAffixes.Items.Clear();
            for (int i = 0; i < relic_now.MinorAffixes.Count; i++)
            {
                lstRelicMinorAffixes.Items.Add(relic_now.MinorAffixes[i].Description);
            }
            cmbMainAffix.Text = relic_now.MainAffixString;
            this.labInfo.Text = $"Level: {relic_now.Level}\r\n{relic_now.MainAffixString}\r\n{relic_now.MinorAffixesString}";
        }

        private void level_up()
        {
            relic_now.LevelUp();
           
            lstRelicMinorAffixes.Items.Clear();
            for (int i = 0; i < relic_now.MinorAffixes.Count; i++)
            {
                lstRelicMinorAffixes.Items.Add(relic_now.MinorAffixes[i].Description);
            }
            refresh_relic_list();
        }

        private void cmdLevelUp20_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                level_up();
            }
        }

        private void lstRelic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRelic.SelectedItems.Count > 0)
            {
                relic_now = relics[lstRelic.SelectedItems[0].Index];
                get_relic_info();
            }
        }

        private void cmdCharacterAdd_Click(object sender, EventArgs e)
        {
            using (var fm = new fmCharacterList())
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    cmdCharacterAdd.BackgroundImage = fm.WaifuImage;
                    cmdCharacterAdd.Text = "";
                    labCharacterName.Text = $"Name: {fm.Waifu.Name}";
                }
            }
        }
    }
}
