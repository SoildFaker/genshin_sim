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
            this.lstArtifacts.LargeImageList = imageList;
            this.lstArtifacts.SmallImageList = imageList;
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
            if (lstArtifacts.SelectedItems.Count > 0)
            {
                this.Artifact = artifacts[lstArtifacts.SelectedItems[0].Index];
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
            if (lstArtifacts.SelectedItems.Count > 0)
            {
                this.artifacts.RemoveAt(lstArtifacts.SelectedItems[0].Index);
                lstArtifacts.Items.RemoveAt(lstArtifacts.SelectedItems[0].Index);
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
            lstArtifacts.Items.Add($"{artifact.Name} ({artifact.Level})");
            lstArtifacts.Items[lstArtifacts.Items.Count - 1].SubItems.Add($"{artifact.MainAffixString}");
            lstArtifacts.Items[lstArtifacts.Items.Count - 1].SubItems.Add($"{artifact.MinorAffixesString}");
            lstArtifacts.Items[lstArtifacts.Items.Count - 1].ImageIndex = ((int)artifact.Type);
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            if (lstArtifacts.SelectedItems.Count > 0)
            {
                using (var fm = new fmArtifactEditor(artifacts[lstArtifacts.SelectedItems[0].Index]))
                {
                    if (fm.ShowDialog() == DialogResult.OK)
                    {
                        artifacts[lstArtifacts.SelectedItems[0].Index] = fm.Artifact;
                    }
                }
            }

        }
    }
}
