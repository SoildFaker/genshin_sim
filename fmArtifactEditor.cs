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
    public partial class fmArtifactEditor : Form
    {
        public fmArtifactEditor(Artifact artifact)
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
        private int affix_slot_fix = 0;
        private int affix_slot_count = 4;

        private void init()
        {
            this.gpArtifact.Text = $"Artifact ({ArtifactFactory.type2str(artifact.Type)})";
            this.txtName.Text = artifact.Name;
            this.txtNickName.Text = artifact.NickName;
            this.main_affixes = AffixFactory.get_artifact_main_affix_array(artifact.Type);
            this.selLevel.Value = artifact.Level;
            this.cmbMainAffix.Text = artifact.MainAffixString;
            this.init_minor_affixes.AddRange(AffixFactory.minor_affixes_arr.Where(x => x.Attribute != artifact.MainAffix.Attribute));
            for (int i = 0; i < artifact.MinorAffixes.Count; i++)
            {
                this.affix_slot[i] = artifact.MinorAffixes[i];
                if (i < 4)
                {
                    this.init_minor_affixes.RemoveAll(x => x.Attribute == affix_slot[i].Attribute);
                    this.lstSelectedMinorAffix.Items.Add($"Slot * [{artifact.MinorAffixes[i].Description}\t]");
                }
                else
                {
                    this.lstSelectedMinorAffix.Items.Add($"Slot   [{artifact.MinorAffixes[i].Description}\t]");
                }
            }
            this.cmbMainAffix.Items.AddRange(main_affixes.Select(x => x.Description).ToArray());
            refresh_list();
            refresh_slot();
            refresh_info();
            //refresh_minor_affix();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.artifact.NickName = txtNickName.Text;
            this.artifact.SetMinorAffix(affix_slot.Take(affix_slot_count).ToList());
            this.Close();
        }

        private void refresh_info()
        {
            gpMainAffix.Text = $"Main Affix (Lv.{artifact.Level})";
        }

        private void refresh_list()
        {
            this.lstMinorAffixList.Items.Clear();
            if (this.lstSelectedMinorAffix.SelectedIndex < 0)
            {
                return;
            }
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
            affix_slot_count = affix_slot_fix + 4 + (int)artifact.Level / 4;
            if (affix_slot_count < 4)
            {
                affix_slot_count = 4;
            }
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
            check_slots();
            labInfo.Text = $"Available Minor Affix Count: {affix_slot_count}";
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
            refresh_slot();
            refresh_info();
        }

        private void cmbMainAffix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMainAffix.SelectedIndex >= 0)
            {
                artifact.SetMainAffix(main_affixes[cmbMainAffix.SelectedIndex]);
                refresh_minor_affix();
                refresh_list();
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
                    refresh_minor_affix();
                    refresh_list();
                }
                else
                {
                    lstSelectedMinorAffix.Items[index] = $"Slot   [{affix.Description}\t]";
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (affix_slot[i] != null)
                {
                    if (affix_slot[i].Attribute == artifact.MainAffix.Attribute)
                    {
                        slot_unplug(i);
                    }
                    if (i >= 4)
                    {
                        if (affix_slot.Take(4).Where(x => x.Attribute == affix_slot[i].Attribute).Count() == 0)
                        {
                            slot_unplug(i);
                        }
                    }
                }
            }
            check_slots();
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
                    refresh_minor_affix();
                    refresh_list();
                }
                else
                {
                    lstSelectedMinorAffix.Items[index] = $"Slot   [\t]";
                }
            }
            check_slots();
        }

        private void check_slots()
        {
            for (int i = 0; i < affix_slot_count; i++)
            {
                if (affix_slot[i] == null)
                {
                    this.cmdOK.Enabled = false;
                    return;
                }
            }
            this.cmdOK.Enabled = true;
        }

        private void lstSelectedMinorAffix_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_minor_affix();
            refresh_list();
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

        private void fmArtifact_Load(object sender, EventArgs e)
        {

        }

        private void selSlot3_CheckedChanged(object sender, EventArgs e)
        {
            if (selSlot3.Checked)
            {
                affix_slot_fix = -1;
                refresh_slot();
            }
        }

        private void selSlot4_CheckedChanged(object sender, EventArgs e)
        {
            if (selSlot4.Checked)
            {
                affix_slot_fix = 0;
                refresh_slot();
            }
        }
    }
}
