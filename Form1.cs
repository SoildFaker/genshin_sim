using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

        string file_artifact_data = @"artifacts.dat";
        int[] version = new int[4] { 0, 1, 0, 0};
        List<Artifact> artifacts_inventory = new List<Artifact>();
        Artifact[] waifu_artifacts = new Artifact[5];
        Waifu waifu_now;
        Artifact artifact_now;

        private void Form1_Load(object sender, EventArgs e)
        {
            read_artifacts_from_file();
            artifact_now = artifacts_inventory[0];
            refresh_relic_list();
        }

        private void refresh_relic_list()
        {
            lstRelic.Items.Clear();
            for (int i = 0; i < artifacts_inventory.Count; i++)
            {
                lstRelic.Items.Add($"{artifacts_inventory[i].Name} ({artifacts_inventory[i].Level})");
                lstRelic.Items[i].SubItems.Add($"{artifacts_inventory[i].MainAffixString}");
                lstRelic.Items[i].SubItems.Add($"{artifacts_inventory[i].MinorAffixesString}");
                lstRelic.Items[i].ImageIndex = ((int)artifacts_inventory[i].Type);
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
            this.labInfo.Text = $"Level: {artifact_now.Level}\r\n{artifact_now.MainAffixString}\r\n{artifact_now.MinorAffixesString}";
        }

        private void level_up()
        {
            artifact_now.LevelUp();
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
                artifact_now = artifacts_inventory[lstRelic.SelectedItems[0].Index];
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
                    waifu_now.Artifacts = waifu_artifacts;
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
            if (waifu_artifacts[0] == null)
            {
                waifu_artifacts[0] = new Artifact(ArtifactType.FlowerOfLife);
            }
            using (var fm = new fmArtifactEditor(waifu_artifacts[0]))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactFlowerInfo.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    gpCharacterArtifactFlower.Text = $"Flower of Life (Lv.{fm.Artifact.Level})";
                    waifu_artifacts[0] = fm.Artifact;
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
            if (waifu_artifacts[3] == null)
            {
                waifu_artifacts[3] = new Artifact(ArtifactType.GobletOfEonothem);
            }
            using (var fm = new fmArtifactEditor(waifu_artifacts[3]))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactGoblet.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    gpCharacterArtifactGoblet.Text = $"Goblet of Eonothem (Lv.{fm.Artifact.Level})";
                    waifu_artifacts[3] = fm.Artifact;
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
            if (waifu_artifacts[1] == null)
            {
                waifu_artifacts[1] = new Artifact(ArtifactType.PlumeOfDeath);
            }
            using (var fm = new fmArtifactEditor(waifu_artifacts[1]))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactPlume.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    gpCharacterArtifactPlume.Text = $"Plume of Death (Lv.{fm.Artifact.Level})";
                    waifu_artifacts[1] = fm.Artifact;
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
            if (waifu_artifacts[2] == null)
            {
                waifu_artifacts[2] = new Artifact(ArtifactType.SandsOfEon);
            }
            using (var fm = new fmArtifactEditor(waifu_artifacts[2]))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactSands.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    gpCharacterArtifactSands.Text = $"Sands of Eon (Lv.{fm.Artifact.Level})";
                    waifu_artifacts[2] = fm.Artifact;
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
            if (waifu_artifacts[4] == null)
            {
                waifu_artifacts[4] = new Artifact(ArtifactType.CircletOfLogos);
            }
            using (var fm = new fmArtifactEditor(waifu_artifacts[4]))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactCirclet.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    gpCharacterArtifactCirclet.Text = $"Circlet of Logos (Lv.{fm.Artifact.Level})";
                    waifu_artifacts[4] = fm.Artifact;
                    if (waifu_now != null)
                    {
                        waifu_now.Artifacts[4] = fm.Artifact;
                    }
                    refresh_character_info();
                }
            }
        }

        private void labGithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/SoildFaker/genshin_sim");
            }
            catch 
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void cmdArtifactEdit_Click(object sender, EventArgs e)
        {
            using (var fm = new fmArtifactEditor(artifacts_inventory[lstRelic.SelectedItems[0].Index]))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    artifacts_inventory[lstRelic.SelectedItems[0].Index] = fm.Artifact;
                }
            }
        }

        private void cmdArtifactSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"version = {version[0]}.{version[1]}.{version[2]}.{version[3]}\n");

            for (int i = 0; i < artifacts_inventory.Count; i++)
            {
                sb.Append($"{ArtifactFactory.artifactTypes.ToList().IndexOf(artifacts_inventory[i].Type)},"); // 0 -- Artifact Type
                sb.Append($"{artifacts_inventory[i].Level},"); // 1 -- Level
                sb.Append($"{artifacts_inventory[i].NickName},"); // 2 -- Nick Name
                sb.Append($"{AffixFactory.get_artifact_main_affix_array(artifacts_inventory[i].Type).Select(x => x.Attribute).ToList().IndexOf(artifacts_inventory[i].MainAffix.Attribute)},"); // 3 -- Main Affix Type
                sb.Append($"{artifacts_inventory[i].MinorAffixes.Count},"); // 4 -- Minor Affix Count
                for (int j = 0; j < artifacts_inventory[i].MinorAffixes.Count; j++)
                {
                    sb.Append($"{AffixFactory.minor_affixes_arr.Select(x => x.Attribute).ToList().IndexOf(artifacts_inventory[i].MinorAffixes[j].Attribute)},");
                }
                sb.Append("\n");
            }

            File.WriteAllText(file_artifact_data, sb.ToString());
        }

        private void read_artifacts_from_file()
        {
            if (File.Exists(file_artifact_data))
            {
                string[] lines = File.ReadAllLines(file_artifact_data);
                // skip first line(version info)
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] item = lines[i].Split(',');
                    List<Affix> minor_affix = new List<Affix>();
                    for (int j = 0; j < Convert.ToInt32(item[4]); j++)
                    {
                        minor_affix.Add(AffixFactory.minor_affixes_arr[Convert.ToInt32(item[5 + j])]);
                    }
                    ArtifactType type = ArtifactFactory.artifactTypes[Convert.ToInt32(item[0])];
                    Artifact tmp = new Artifact(type, AffixFactory.get_artifact_main_affix_array(type)[Convert.ToInt32(item[3])], minor_affix, Convert.ToInt32(item[1]));
                    tmp.NickName = item[2];
                    artifacts_inventory.Add(tmp);
                }
            }
            else
            {
                artifacts_inventory.Add(ArtifactFactory.pick());
            }
        }
    }
}
