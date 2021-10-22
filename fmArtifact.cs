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
        public Artifact Artifact {
            get
            {
                return this.artifact;
            }
        }
        private Artifact artifact;
        private Affix[] main_affixes;
        private Affix[] affix_slot = new Affix[9];
        private List<Affix> init_minor_affixes = new List<Affix>();
        private List<Affix> sub_minor_affixes = new List<Affix>();
        private int affix_slot_count = 4;

        private void init()
        {
            this.gpArtifact.Text = $"Artifact ({artifact.Name})";
            this.main_affixes = AffixFactory.get_artifact_main_affix_array(artifact.Type);
            this.cmbMainAffix.Text = artifact.MainAffixString;
            this.cmbMainAffix.Items.AddRange(main_affixes.Select(x => x.Description).ToArray());
            refresh_list();
            refresh_slot();
            refresh_info();
            refresh_minor_affix();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.artifact.SetInitMinorAffix(affix_slot.Take(4).ToList());
            this.artifact.SetMinorAffix(affix_slot.Take(affix_slot_count).ToList());
            this.Close();
        }

        private void refresh_info()
        {
            gpMainAffix.Text = $"Main Affix (Lv.{artifact.Level})";
            labInfo.Text = $"Available Minor Affix Count: {affix_slot_count}";
        }

        private void refresh_list()
        {
            if (this.lstSelectedMinorAffix.SelectedIndex < 0)
            {
                return;
            }
            this.lstMinorAffixList.Items.Clear();
            if (lstSelectedMinorAffix.SelectedIndex < 4)
            {
                this.lstMinorAffixList.Items.AddRange(this.init_minor_affixes.Select(x => x.Description).ToArray());
            }
            else
            {
                this.lstMinorAffixList.Items.AddRange(this.sub_minor_affixes.Select(x => x.Description).ToArray());
            }
        }

        private void refresh_slot()
        {
            if (this.lstSelectedMinorAffix.Items.Count < affix_slot_count)
            {
                for (int i = lstSelectedMinorAffix.Items.Count; i < affix_slot_count; i++)
                {
                    if (i < 4)
                    {
                        this.lstSelectedMinorAffix.Items.Add($"Slot * [\t]");
                    }
                    else
                    {
                        if (affix_slot[i] != null)
                        {
                            lstSelectedMinorAffix.Items.Add($"Slot   [{affix_slot[i].Description}\t]");
                        }
                        else
                        {
                            lstSelectedMinorAffix.Items.Add($"Slot   [\t]");
                        }
                    }
                }
            }
            else
            {
                for (int i = affix_slot_count; i < lstSelectedMinorAffix.Items.Count; i++)
                {
                    lstSelectedMinorAffix.Items.RemoveAt(i);
                }
            }
            refresh_minor_affix();
            for (int i = 0; i < affix_slot_count; i++)
            {
                if (affix_slot[i] == null)
                {
                    this.cmdOK.Enabled = false;
                    return;
                }
            }
        }

        private void refresh_minor_affix()
        {
            this.init_minor_affixes.Clear();
            this.init_minor_affixes.AddRange(AffixFactory.minor_affixes_arr.Where(x => x.Attribute != artifact.MainAffix.Attribute));
            this.sub_minor_affixes.Clear();
            for (int i = 0; i < 4; i++)
            {
                if (affix_slot[i] != null)
                {
                    this.init_minor_affixes.RemoveAll(x => x.Attribute == affix_slot[i].Attribute);
                    this.sub_minor_affixes.AddRange(AffixFactory.minor_affixes_arr.Where(x => x.Attribute == affix_slot[i].Attribute));
                }
            }

        }

        private void selLevel_Scroll(object sender, EventArgs e)
        {
            this.cmbMainAffix.Items.Clear();
            for (int i = 0; i < main_affixes.Length; i++)
            {
                main_affixes[i].SetLevel(selLevel.Value);
            }
            artifact.SetLevel(selLevel.Value);
            this.cmbMainAffix.Text = artifact.MainAffixString;
            this.cmbMainAffix.Items.AddRange(main_affixes.Select(x => x.Description).ToArray());
            affix_slot_count = 4 + (int)artifact.Level / 4;
            refresh_info();
            refresh_slot();
        }

        private void cmbMainAffix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMainAffix.SelectedIndex >= 0)
            {
                artifact.SetMainAffix(main_affixes[cmbMainAffix.SelectedIndex]);
                refresh_list();
                refresh_minor_affix();
            }
        }

        private void cmdAddMinorAffix_Click(object sender, EventArgs e)
        {
            if (lstSelectedMinorAffix.SelectedIndex < 0 || lstMinorAffixList.SelectedIndex < 0)
            {
                return;
            }
            slot_plug(lstSelectedMinorAffix.SelectedIndex, this.init_minor_affixes[lstMinorAffixList.SelectedIndex]);
        }

        private void slot_plug(int index, Affix affix)
        {
            if (index < 0)
            {
                return;
            }
            if (index < affix_slot_count)
            {
                affix_slot[index] = affix;
                if (index < 4)
                {
                    lstSelectedMinorAffix.Items[index] = $"Slot * [{affix.Description}\t]";
                    refresh_list();
                }
                else
                {
                    lstSelectedMinorAffix.Items[index] = $"Slot   [{affix.Description}\t]";
                }
            }
            for (int i = 0; i < affix_slot_count; i++)
            {
                if (affix_slot[i] == null)
                {
                    return;
                }
            }
            this.cmdOK.Enabled = true;
        }
        private void slot_unplug(int index)
        {
            if (index < 0)
            {
                return;
            }
            if (index < affix_slot_count)
            {
                affix_slot[index] = null;
                if (index < 4)
                {
                    lstSelectedMinorAffix.Items[index] = $"Slot * [\t]";
                    refresh_list();
                }
                else
                {
                    lstSelectedMinorAffix.Items[index] = $"Slot   [\t]";
                }
            }
            for (int i = 0; i < affix_slot_count; i++)
            {
                if (affix_slot[i] == null)
                {
                    this.cmdOK.Enabled = false;
                    return;
                }
            }
        }

        private void lstSelectedMinorAffix_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_list();
            refresh_minor_affix();
        }

        private void lstMinorAffixList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstMinorAffixList_DoubleClick(object sender, EventArgs e)
        {
            if (lstSelectedMinorAffix.SelectedIndex < 0 || lstMinorAffixList.SelectedIndex < 0)
            {
                return;
            }
            if (lstSelectedMinorAffix.SelectedIndex < 4)
            {
                slot_plug(lstSelectedMinorAffix.SelectedIndex, this.init_minor_affixes[lstMinorAffixList.SelectedIndex]);
            }
            else
            {
                slot_plug(lstSelectedMinorAffix.SelectedIndex, this.sub_minor_affixes[lstMinorAffixList.SelectedIndex]);
            }
            if (lstSelectedMinorAffix.SelectedIndex < lstSelectedMinorAffix.Items.Count - 1)
            {
                lstSelectedMinorAffix.SelectedIndex++;
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            slot_unplug(lstSelectedMinorAffix.SelectedIndex);
        }

        private void lstSelectedMinorAffix_DoubleClick(object sender, EventArgs e)
        {
            slot_unplug(lstSelectedMinorAffix.SelectedIndex);
        }

        private void cmdCamcel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
