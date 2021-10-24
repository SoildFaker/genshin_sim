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
    public partial class fmSelectArtifactType : Form
    {
        public fmSelectArtifactType(ImageList imageList)
        {
            InitializeComponent();
            this.cmdCharacterArtifactFlower.Image = imageList.Images[0];
            this.cmdCharacterArtifactPlume.Image = imageList.Images[1];
            this.cmdCharacterArtifactSands.Image = imageList.Images[2];
            this.cmdCharacterArtifactGoblet.Image = imageList.Images[3];
            this.cmdCharacterArtifactCirclet.Image = imageList.Images[4];
        }

        ArtifactType type = ArtifactType.SandsOfEon;
        public Artifact Artifact;
        bool isSelected = false;

        private void cmdCharacterArtifactFlower_Click(object sender, EventArgs e)
        {
            type = ArtifactType.FlowerOfLife;
            isSelected = true;
            this.Close();
        }

        private void fmSelectArtifactType_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSelected)
            {
                using (var fm = new fmArtifactEditor(new Artifact(type)))
                {
                    if (fm.ShowDialog() == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Artifact = fm.Artifact;
                    }
                }
            }

        }

        private void cmdCharacterArtifactPlume_Click(object sender, EventArgs e)
        {
            type = ArtifactType.PlumeOfDeath;
            isSelected = true;
            this.Close();
        }

        private void cmdCharacterArtifactSands_Click(object sender, EventArgs e)
        {
            type = ArtifactType.SandsOfEon;
            isSelected = true;
            this.Close();
        }

        private void cmdCharacterArtifactGoblet_Click(object sender, EventArgs e)
        {
            type = ArtifactType.GobletOfEonothem;
            isSelected = true;
            this.Close();
        }

        private void cmdCharacterArtifactCirclet_Click(object sender, EventArgs e)
        {
            type = ArtifactType.CircletOfLogos;
            isSelected = true;
            this.Close();
        }
    }
}
