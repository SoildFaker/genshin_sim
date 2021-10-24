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
    public partial class fmArtifactList : Form
    {
        public fmArtifactList(List<Artifact> artifacts, ImageList imageList, ArtifactType type)
        {
            InitializeComponent();
            this.artifacts = artifacts;
            this.ImageList = imageList;
            this.type = type;
            this.lstArtifact.LargeImageList = imageList;
            this.lstArtifact.SmallImageList = imageList;
            for (int i = 0; i < artifacts.Count; i++)
            {
                artifact_list_add(artifacts[i]);
            }
        }

        ArtifactType type;
        ImageList ImageList;
        List<Artifact> artifacts;
        public Artifact Artifact;

        private void cmdOK_Click(object sender, EventArgs e)
        {
            dialog_return();
        }

        private void dialog_return()
        {
            if (lstArtifact.SelectedItems.Count > 0)
            {
                this.Artifact = artifacts[lstArtifact.SelectedItems[0].Index];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstRelic_DoubleClick(object sender, EventArgs e)
        {
            dialog_return();
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (lstArtifact.SelectedItems.Count > 0)
            {
                this.artifacts.RemoveAt(lstArtifact.SelectedItems[0].Index);
                lstArtifact.Items.RemoveAt(lstArtifact.SelectedItems[0].Index);
            }
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            using (var fm = new fmArtifactEditor(new Artifact(type)))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    this.artifacts.Add(fm.Artifact);
                    artifact_list_add(fm.Artifact);
                }
            }
        }

        private void artifact_list_add(Artifact artifact)
        {
            lstArtifact.Items.Add($"{artifact.Name} ({artifact.Level})");
            lstArtifact.Items[lstArtifact.Items.Count - 1].SubItems.Add($"{artifact.MainAffixString}");
            lstArtifact.Items[lstArtifact.Items.Count - 1].SubItems.Add($"{artifact.MinorAffixesString}");
            lstArtifact.Items[lstArtifact.Items.Count - 1].SubItems.Add($"{artifact.NickName}");
            lstArtifact.Items[lstArtifact.Items.Count - 1].ImageIndex = ((int)artifact.Type);
        }

        private void artifact_list_insert(Artifact artifact, int pos)
        {
            lstArtifact.BeginUpdate();
            lstArtifact.Items.Insert(pos, $"{artifact.Name} ({artifact.Level})");
            lstArtifact.Items[pos].SubItems.Add($"{artifact.MainAffixString}");
            lstArtifact.Items[pos].SubItems.Add($"{artifact.MinorAffixesString}");
            lstArtifact.Items[pos].SubItems.Add($"{artifact.NickName}");
            lstArtifact.Items[pos].ImageIndex = ((int)artifact.Type);
            lstArtifact.Items[pos].Selected = true;
            lstArtifact.Items[pos].EnsureVisible();
            lstArtifact.Select();
            lstArtifact.EndUpdate();
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            if (lstArtifact.SelectedItems.Count > 0)
            {
                using (var fm = new fmArtifactEditor(artifacts[lstArtifact.SelectedItems[0].Index]))
                {
                    if (fm.ShowDialog() == DialogResult.OK)
                    {
                        int index = lstArtifact.SelectedItems[0].Index;
                        artifacts[index] = fm.Artifact;
                        lstArtifact.Items.RemoveAt(index);
                        artifact_list_insert(fm.Artifact, index);
                    }
                }
            }

        }
    }
}
