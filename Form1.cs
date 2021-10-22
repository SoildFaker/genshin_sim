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
        Artifact[] artifacts_now = new Artifact[5];
        Waifu waifu_now;

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
                    waifu_now = fm.Waifu;
                    selCharacterLevel.Value = waifu_now.Level;
                    waifu_now.Artifacts = artifacts_now;
                    refresh_character_info();
                }
            }
        }

        private void refresh_character_info()
        {
            if (waifu_now == null)
            {
                return;
            }
            List<Affix> stat = waifu_now.Stat;
            labCharacterName.Text = $"{waifu_now.Name} (lv.{waifu_now.Level} {waifu_now.Vision})";
            labCharacterBaseStat.Text = ""; 
            foreach (var item in waifu_now.BaseStat)
            {
                labCharacterBaseStat.Text += item.Description + "\r\n";
            }
            labCharacterAttributes.Text = $"{waifu_now.Name}\r\n" +
                $"生命值: {waifu_now.HP}\r\n" +
                $"攻击力: {waifu_now.ATK}\r\n" +
                $"防御力: {waifu_now.DEF}\r\n" +
                $"元素精通: {waifu_now.ELM}\r\n";
            for (int i = 0; i < AffixFactory.waifu_stat_arr.Length; i++)
            {
                AffixAttr attr = AffixFactory.waifu_stat_arr[i];
                if (attr.ToString().StartsWith("p"))
                {
                    labCharacterAttributes.Text += $"{AffixFactory.attr2str(attr)}: \t{stat.Where(x => x.Attribute == attr).Sum(x => x.Value).ToString("0.0%")}\r\n";
                }
                else
                {
                    labCharacterAttributes.Text += $"{AffixFactory.attr2str(attr)}: \t{stat.Where(x => x.Attribute == attr).Sum(x => x.Value)}\r\n";
                }
            }
        }

        private void selCharacterLevel_Scroll(object sender, EventArgs e)
        {
            if (waifu_now != null)
            {
                waifu_now.SetLevel(selCharacterLevel.Value);
                refresh_character_info();
            }
        }

        private void cmdCharacterArtifactFlower_Click(object sender, EventArgs e)
        {
            if (artifacts_now[0] == null)
            {
                artifacts_now[0] = new Artifact(ArtifactType.FlowerOfLife);
            }
            using (var fm = new fmArtifact(artifacts_now[0]))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactFlowerInfo.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    artifacts_now[0] = fm.Artifact;
                    if (waifu_now != null)
                    {
                        waifu_now.Artifacts[0] = fm.Artifact;
                    }
                    refresh_character_info();
                }
            }
        }

        private void cmdCharacterArtifactGoblet_Click(object sender, EventArgs e)
        {
            if (artifacts_now[3] == null)
            {
                artifacts_now[3] = new Artifact(ArtifactType.GobletOfEonothem);
            }
            using (var fm = new fmArtifact(artifacts_now[3]))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactGoblet.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    artifacts_now[3] = fm.Artifact;
                    if (waifu_now != null)
                    {
                        waifu_now.Artifacts[3] = fm.Artifact;
                    }
                    refresh_character_info();
                }
            }
        }

        private void cmdCharacterArtifactPlume_Click(object sender, EventArgs e)
        {
            if (artifacts_now[1] == null)
            {
                artifacts_now[1] = new Artifact(ArtifactType.PlumeOfDeath);
            }
            using (var fm = new fmArtifact(artifacts_now[1]))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactPlume.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    artifacts_now[1] = fm.Artifact;
                    if (waifu_now != null)
                    {
                        waifu_now.Artifacts[1] = fm.Artifact;
                    }
                    refresh_character_info();
                }
            }
        }

        private void cmdCharacterArtifactSands_Click(object sender, EventArgs e)
        {
            if (artifacts_now[2] == null)
            {
                artifacts_now[2] = new Artifact(ArtifactType.SandsOfEon);
            }
            using (var fm = new fmArtifact(artifacts_now[2]))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactSands.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    artifacts_now[2] = fm.Artifact;
                    if (waifu_now != null)
                    {
                        waifu_now.Artifacts[2] = fm.Artifact;
                    }
                    refresh_character_info();
                }
            }

        }

        private void cmdCharacterArtifactCirclet_Click(object sender, EventArgs e)
        {
            if (artifacts_now[4] == null)
            {
                artifacts_now[4] = new Artifact(ArtifactType.CircletOfLogos);
            }
            using (var fm = new fmArtifact(artifacts_now[4]))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactCirclet.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    artifacts_now[4] = fm.Artifact;
                    if (waifu_now != null)
                    {
                        waifu_now.Artifacts[4] = fm.Artifact;
                    }
                    refresh_character_info();
                }
            }
        }
    }
}
