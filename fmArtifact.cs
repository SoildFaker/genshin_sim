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
    public partial class fmArtifact : Form
    {
        public fmArtifact(Artifact artifact)
        {
            InitializeComponent();
            this.artifact = artifact;
            init();
        }
        private Artifact artifact;
        private Affix[] main_affixs;
        private int minor_affix_slot = 4;

        private void init()
        {
            this.gpArtifact.Text = $"Artifact ({artifact.Name})";
            this.main_affixs = AffixFactory.get_artifact_main_affix_array(artifact.Type);
            this.cmbMainAffix.Text = artifact.MainAffixString;
            this.cmbMainAffix.Items.AddRange(main_affixs.Select(x => x.Description).ToArray());
            refresh_list();
            refresh_slot();
            refresh_info();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {

        }

        private void refresh_info()
        {
            gpMainAffix.Text = $"Main Affix (Lv.{artifact.Level})";
            labInfo.Text = $"Available Minor Affix Count: {minor_affix_slot}";
        }

        private void refresh_list()
        {
            this.lstMinorAffixList.Items.Clear();
            this.lstMinorAffixList.Items.AddRange(AffixFactory.minor_affixes_arr.Where(x => x.Attribute != artifact.MainAffix.Attribute).Select(x => x.Description).ToArray());
        }

        private void refresh_slot()
        {
            if (this.lstSelectedMinorAffix.Items.Count != minor_affix_slot)
            {
                this.lstSelectedMinorAffix.Items.Clear();
                for (int i = 0; i < minor_affix_slot; i++)
                {
                    this.lstSelectedMinorAffix.Items.Add($"Slot {i}");
                }
            }
        }

        private void selLevel_Scroll(object sender, EventArgs e)
        {
            this.cmbMainAffix.Items.Clear();
            for (int i = 0; i < main_affixs.Length; i++)
            {
                main_affixs[i].SetLevel(selLevel.Value);
            }
            artifact.SetLevel(selLevel.Value);
            this.cmbMainAffix.Text = artifact.MainAffixString;
            this.cmbMainAffix.Items.AddRange(main_affixs.Select(x => x.Description).ToArray());
            minor_affix_slot = 4 + (int)artifact.Level / 4;
            refresh_info();
            refresh_slot();
        }

        private void cmbMainAffix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMainAffix.SelectedIndex >= 0)
            {
                artifact.SetMainAffix(main_affixs[cmbMainAffix.SelectedIndex]);
                refresh_list();
            }
        }

        private void cmdAddMinorAffix_Click(object sender, EventArgs e)
        {
            lstSelectedMinorAffix.Items[lstSelectedMinorAffix.SelectedIndex] = lstMinorAffixList.SelectedItem;
        }
    }
}
