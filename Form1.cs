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
        int artifact_list_select_index = 0;
        Artifact[] waifu_artifacts = new Artifact[5];
        Waifu waifu_now;

        private void Form1_Load(object sender, EventArgs e)
        {
            read_artifacts_from_file();
            refresh_artifact_list();
        }

        private void refresh_artifact_list()
        {
            lstArtifact.BeginUpdate();
            lstArtifact.Items.Clear();
            for (int i = 0; i < artifacts_inventory.Count; i++)
            {
                lstArtifact.Items.Add($"{artifacts_inventory[i].Name} ({artifacts_inventory[i].Level})");
                lstArtifact.Items[i].SubItems.Add($"{artifacts_inventory[i].MainAffixString}");
                lstArtifact.Items[i].SubItems.Add($"{artifacts_inventory[i].MinorAffixesString}");
                lstArtifact.Items[i].SubItems.Add($"{artifacts_inventory[i].NickName}");
                lstArtifact.Items[i].ImageIndex = ((int)artifacts_inventory[i].Type);
            }
            get_relic_info();
            lstArtifact.EndUpdate();
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
            Artifact tmp = this.artifacts_inventory[artifact_list_select_index];
            this.labInfo.Text = $"Level: {tmp.Level}\r\n{tmp.MainAffixString}\r\n{tmp.MinorAffixesString}";
        }

        private void level_up()
        {
            artifacts_inventory[artifact_list_select_index].LevelUp();
            lstArtifact.Items.RemoveAt(artifact_list_select_index);
            artifact_list_insert(artifacts_inventory[artifact_list_select_index], artifact_list_select_index);
        }

        private void cmdLevelUp20_Click(object sender, EventArgs e)
        {
            int gap = 20 - artifacts_inventory[artifact_list_select_index].Level;
            for (int i = 0; i < gap; i++)
            {
                artifacts_inventory[artifact_list_select_index].LevelUp();
            }
            lstArtifact.Items.RemoveAt(artifact_list_select_index);
            artifact_list_insert(artifacts_inventory[artifact_list_select_index], artifact_list_select_index);
        }

        private void lstRelic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstArtifact.SelectedItems.Count > 0)
            {
                artifact_list_select_index = lstArtifact.SelectedItems[0].Index;
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
                    selCharacterLevel.Value = waifu_now.LevelIndex;
                    waifu_now.SetAritfacts(waifu_artifacts);
                    refresh_character_info();
                    clear_weapon_info();
                }
            }
        }

        private void clear_weapon_info()
        {
            waifu_now.SetWeapon(null);
            this.cmdWeaponAdd.BackgroundImage = imUserIcons.Images[0];
            this.labWeaponName.Text = "Name";
            this.labWeaponStat.Text = "Stat";
            this.selWeaponLevel.Value = 0;
        }

        private void refresh_character_info()
        {
            if (waifu_now == null)
            {
                return;
            }
            List<Affix> stat = waifu_now.Stat;
            labCharacterName.Text = $"{waifu_now.Name} (lv.{waifu_now.Level} {WaifuFactory.element2str(waifu_now.Vision)})";
            // Artifact
            if (waifu_now.Effects != null)
            {
                gpCharacterArtifactSetEffect.Text = $"套装加成";
                labCharacterArtifactSetEffect.Text = "";
                for (int i = 0; i < waifu_now.Effects.Count; i++)
                {
                    if (waifu_now.Effects[i].SpecialCond == SpecialCond.Always)
                    {
                        labCharacterArtifactSetEffect.Text += $"{waifu_now.Effects[i].Affix.Description}\r\n";
                    }
                }
            }
            // Weapon
            if (waifu_now.Weapon != null)
            {
                labWeaponName.Text = $"{waifu_now.Weapon.Name} (Lv.{waifu_now.Weapon.Level} {waifu_now.Weapon.Type})";
                labWeaponStat.Text = $"{waifu_now.Weapon.BaseATK.Description}\r\n{waifu_now.Weapon.SecondaryStat.Description}";
                labWeaponStat.Text += $"\r\n\r\n{waifu_now.Weapon.SpecialAbility.Name}:\r\n{waifu_now.Weapon.SpecialAbility.Description}";
            }
            labCharacterBaseStat.Text = ""; 
            foreach (var item in waifu_now.BaseStat)
            {
                labCharacterBaseStat.Text += item.Description + "\r\n";
            }
            labCharacterAttributes.Text = $"[{waifu_now.Name}]\r\n\r\n" +
                $"生命值: {waifu_now.HP}\r\n" +
                $"攻击力: {waifu_now.ATK}\r\n" +
                $"防御力: {waifu_now.DEF}\r\n" +
                $"元素精通: {waifu_now.ELM}\r\n" +
                $"暴击率: {waifu_now.CRI.ToString("0.0%")}\r\n" +
                $"暴击伤害: {waifu_now.CRD.ToString("0.0%")}\r\n" +
                $"物理伤害加成: {waifu_now.Physical.ToString("0.0%")}\r\n" +
                $"火属性伤害加成: {waifu_now.Pyro.ToString("0.0%")}\r\n" +
                $"水属性伤害加成: {waifu_now.Hydro.ToString("0.0%")}\r\n" +
                $"岩属性伤害加成: {waifu_now.Geo.ToString("0.0%")}\r\n" +
                $"雷属性伤害加成: {waifu_now.Electro.ToString("0.0%")}\r\n" +
                $"冰属性伤害加成: {waifu_now.Cryo.ToString("0.0%")}\r\n" +
                $"草属性伤害加成: {waifu_now.Dendro.ToString("0.0%")}\r\n" +
                $"风属性伤害加成: {waifu_now.Anemo.ToString("0.0%")}\r\n" +
                $"治疗加成: {waifu_now.Healing.ToString("0.0%")}\r\n";
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
            using (var fm = new fmArtifactList(artifacts_inventory.Where(x => x.Type == ArtifactType.FlowerOfLife).ToList(), this.imArtifacts, ArtifactType.FlowerOfLife))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactFlowerInfo.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    gpCharacterArtifactFlower.Text = $"{fm.Artifact.Name} (Lv.{fm.Artifact.Level})";
                    waifu_artifacts[0] = fm.Artifact;
                    if (waifu_now != null)
                    {
                        waifu_now.SetAritfact(fm.Artifact);
                    }
                    cmdCharacterArtifactFlower.ImageIndex = ((int)fm.Artifact.Type) + ((int)fm.Artifact.ArtifactSetEffect.Type) * 5;
                    refresh_character_info();
                }
            }
        }

        private void cmdCharacterArtifactGoblet_Click(object sender, EventArgs e)
        {
            using (var fm = new fmArtifactList(artifacts_inventory.Where(x => x.Type == ArtifactType.GobletOfEonothem).ToList(), this.imArtifacts, ArtifactType.GobletOfEonothem))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactGoblet.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    gpCharacterArtifactGoblet.Text = $"{fm.Artifact.Name} (Lv.{fm.Artifact.Level})";
                    waifu_artifacts[3] = fm.Artifact;
                    if (waifu_now != null)
                    {
                        waifu_now.SetAritfact(fm.Artifact);
                    }
                    cmdCharacterArtifactGoblet.ImageIndex = ((int)fm.Artifact.Type) + ((int)fm.Artifact.ArtifactSetEffect.Type) * 5;
                    refresh_character_info();
                }
            }
        }

        private void cmdCharacterArtifactPlume_Click(object sender, EventArgs e)
        {
            using (var fm = new fmArtifactList(artifacts_inventory.Where(x => x.Type == ArtifactType.PlumeOfDeath).ToList(), this.imArtifacts, ArtifactType.PlumeOfDeath))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactPlume.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    gpCharacterArtifactPlume.Text = $"{fm.Artifact.Name} (Lv.{fm.Artifact.Level})";
                    waifu_artifacts[1] = fm.Artifact;
                    if (waifu_now != null)
                    {
                        waifu_now.SetAritfact(fm.Artifact);
                    }
                    cmdCharacterArtifactPlume.ImageIndex = ((int)fm.Artifact.Type) + ((int)fm.Artifact.ArtifactSetEffect.Type) * 5;
                    refresh_character_info();
                }
            }
        }

        private void cmdCharacterArtifactSands_Click(object sender, EventArgs e)
        {
            using (var fm = new fmArtifactList(artifacts_inventory.Where(x => x.Type == ArtifactType.SandsOfEon).ToList(), this.imArtifacts, ArtifactType.SandsOfEon))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactSands.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    gpCharacterArtifactSands.Text = $"{fm.Artifact.Name} (Lv.{fm.Artifact.Level})";
                    waifu_artifacts[2] = fm.Artifact;
                    if (waifu_now != null)
                    {
                        waifu_now.SetAritfact(fm.Artifact);
                    }
                    cmdCharacterArtifactSands.ImageIndex = ((int)fm.Artifact.Type) + ((int)fm.Artifact.ArtifactSetEffect.Type) * 5;
                    refresh_character_info();
                }
            }
        }

        private void cmdCharacterArtifactCirclet_Click(object sender, EventArgs e)
        {
            using (var fm = new fmArtifactList(artifacts_inventory.Where(x => x.Type == ArtifactType.CircletOfLogos).ToList(), this.imArtifacts, ArtifactType.CircletOfLogos))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    labCharacterArtifactCirclet.Text = $"{fm.Artifact.MainAffixString}\r\n{fm.Artifact.MinorAffixesString}";
                    gpCharacterArtifactCirclet.Text = $"{fm.Artifact.Name} (Lv.{fm.Artifact.Level})";
                    waifu_artifacts[4] = fm.Artifact;
                    if (waifu_now != null)
                    {
                        waifu_now.SetAritfact(fm.Artifact);
                    }
                    cmdCharacterArtifactCirclet.ImageIndex = ((int)fm.Artifact.Type) + ((int)fm.Artifact.ArtifactSetEffect.Type) * 5;
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
            artifact_edit();
        }

        private void cmdArtifactSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"version = {version[0]}.{version[1]}.{version[2]}.{version[3]}\n");

            for (int i = 0; i < artifacts_inventory.Count; i++)
            {
                sb.Append($"{ArtifactFactory.artifactTypes.ToList().IndexOf(artifacts_inventory[i].Type)},"); // 0 -- Artifact Type
                sb.Append($"{artifacts_inventory[i].Level},"); // 1 -- Level
                sb.Append($"{ArtifactFactory.SetEffects.ToList().IndexOf(artifacts_inventory[i].ArtifactSetEffect)},"); // 2 -- Set Effect
                sb.Append($"{artifacts_inventory[i].NickName},"); // 3 -- Nick Name
                sb.Append($"{AffixFactory.get_artifact_main_affix_array(artifacts_inventory[i].Type).Select(x => x.Attribute).ToList().IndexOf(artifacts_inventory[i].MainAffix.Attribute)},"); // 4 -- Main Affix Type
                sb.Append($"{artifacts_inventory[i].MinorAffixes.Count},"); // 5 -- Minor Affix Count
                for (int j = 0; j < artifacts_inventory[i].MinorAffixes.Count; j++)
                {
                    sb.Append($"{AffixFactory.minor_affixes_arr.ToList().IndexOf(artifacts_inventory[i].MinorAffixes[j])},");
                }
                sb.Append("\n");
            }
            try
            {
                File.WriteAllText(file_artifact_data, sb.ToString());
                MessageBox.Show("保存成功！", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败！\r\n{ex.Message}", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
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
                    for (int j = 0; j < Convert.ToInt32(item[5]); j++)
                    {
                        minor_affix.Add(AffixFactory.minor_affixes_arr[Convert.ToInt32(item[6 + j])]);
                    }
                    ArtifactType type = ArtifactFactory.artifactTypes[Convert.ToInt32(item[0])];
                    Artifact tmp = new Artifact(type, AffixFactory.get_artifact_main_affix_array(type)[Convert.ToInt32(item[4])], minor_affix, ArtifactFactory.SetEffects[Convert.ToInt32(item[2])], Convert.ToInt32(item[1]));
                    tmp.NickName = item[3];
                    artifacts_inventory.Add(tmp);
                }
            }
            else
            {
                artifacts_inventory.Add(ArtifactFactory.pick());
            }
        }

        private void lstRelic_DoubleClick(object sender, EventArgs e)
        {
            artifact_edit();
        }

        private void cmdArtifactAdd_Click(object sender, EventArgs e)
        {
            artifact_add();
        }

        private void cmdArtifactDelete_Click(object sender, EventArgs e)
        {
            artifact_delete();
        }

        private void menuArtifactEdit_Click(object sender, EventArgs e)
        {
            artifact_edit();
        }

        private void menuArtifactAdd_Click(object sender, EventArgs e)
        {
            artifact_add();
        }

        private void menuArtifactDelete_Click(object sender, EventArgs e)
        {
            artifact_delete();
        }

        private void artifact_delete()
        {
            if (lstArtifact.SelectedItems.Count > 0)
            {
                this.artifacts_inventory.RemoveAt(lstArtifact.SelectedItems[0].Index);
                lstArtifact.Items.RemoveAt(lstArtifact.SelectedItems[0].Index);
            }
        }

        private void artifact_add()
        {
            using (var fm = new fmSelectArtifactType(this.imArtifacts))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    int index = lstArtifact.Items.Count;
                    this.artifacts_inventory.Add(fm.Artifact);
                    artifact_list_insert(fm.Artifact, index);
                }
            }
        }

        private void artifact_edit()
        {
            if (lstArtifact.SelectedItems.Count > 0)
            {
                using (var fm = new fmArtifactEditor(artifacts_inventory[lstArtifact.SelectedItems[0].Index]))
                {
                    if (fm.ShowDialog() == DialogResult.OK)
                    {
                        int index = lstArtifact.SelectedItems[0].Index;
                        artifacts_inventory[index] = fm.Artifact;
                        lstArtifact.Items.RemoveAt(index);
                        artifact_list_insert(fm.Artifact, index);
                    }
                }
            }
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

        private void cmdWeaponAdd_Click(object sender, EventArgs e)
        {
            if (waifu_now == null)
            {
                return;
            }
            using (var fm = new fmWeaponList(waifu_now.WeaponType))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    cmdWeaponAdd.BackgroundImage = fm.WeaponImage;
                    waifu_now.SetWeapon(fm.Weapon);
                    selWeaponLevel.Value = waifu_now.Weapon.LevelIndex;
                    refresh_character_info();
                }
            }
        }

        private void selWeaponLevel_Scroll(object sender, EventArgs e)
        {
            if (waifu_now != null && waifu_now.Weapon != null)
            {
                waifu_now.Weapon.SetLevel(selWeaponLevel.Value);
                refresh_character_info();
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 1)
            {
                refresh_artifact_list();
            }
        }

        private void cmdCharacterArtifactClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < waifu_artifacts.Length; i++)
            {
                waifu_artifacts[i] = null;
            }
            gpCharacterArtifactFlower.Text = ArtifactFactory.type2str(ArtifactType.FlowerOfLife);
            gpCharacterArtifactPlume.Text = ArtifactFactory.type2str(ArtifactType.PlumeOfDeath);
            gpCharacterArtifactSands.Text = ArtifactFactory.type2str(ArtifactType.SandsOfEon);
            gpCharacterArtifactGoblet.Text = ArtifactFactory.type2str(ArtifactType.GobletOfEonothem);
            gpCharacterArtifactCirclet.Text = ArtifactFactory.type2str(ArtifactType.CircletOfLogos);
            labCharacterArtifactFlowerInfo.Text = "(Empty)";
            labCharacterArtifactPlume.Text = "(Empty)";
            labCharacterArtifactGoblet.Text = "(Empty)";
            labCharacterArtifactSands.Text = "(Empty)";
            labCharacterArtifactCirclet.Text = "(Empty)";
            refresh_character_info();
        }

        private void cmdWeaponRefine_Click(object sender, EventArgs e)
        {
            if (waifu_now != null && waifu_now.Weapon != null)
            {
                int level = waifu_now.Weapon.SpecialAbility.Level;
                level = level < 4 ? level + 1 : 0;
                waifu_now.Weapon.SpecialAbility.SetLevel(level);
                cmdWeaponRefine.Text = $"Refine: {level + 1}";
                refresh_character_info();
            }
        }
    }
}
