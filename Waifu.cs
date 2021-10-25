using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    public enum ElementType
    {
        Pyro,       // 火
        Hydro,      // 水
        Cryo,       // 冰
        Dendro,     // 草
        Electro,    // 雷
        Anemo,      // 风
        Geo,        // 岩
    }

    public enum WaifuStat
    {
        HP,
        BaseHP,
        ATK,
        DEF,
        ELM,
    }

    public class Waifu
    {
        public string Name { get; private set; }
        public double HP { get { return get_attribute(AffixAttr.HP, AffixAttr.pHP); } }
        public double ATK { get { return get_attribute(AffixAttr.ATK, AffixAttr.pATK); } }
        public double DEF { get { return get_attribute(AffixAttr.DEF, AffixAttr.pDEF); } }
        public double ELM { get { return get_attribute(AffixAttr.ELM); } }
        public double CGR { get { return get_attribute(AffixAttr.pCGR); } }
        public double CRI { get { return get_attribute(AffixAttr.pCRI); } }
        public double CRD { get { return get_attribute(AffixAttr.pCRD); } }
        public double Physical { get { return get_attribute(AffixAttr.pPhysical); } }
        public double Hydro { get { return get_attribute(AffixAttr.pHydro); } }
        public double Cryo { get { return get_attribute(AffixAttr.pCryo); } }
        public double Anemo { get { return get_attribute(AffixAttr.pAnemo); } }
        public double Dendro { get { return get_attribute(AffixAttr.pDendro); } }
        public double Geo { get { return get_attribute(AffixAttr.pGeo); } }
        public double Electro { get { return get_attribute(AffixAttr.pElectro); } }
        public double Pyro { get { return get_attribute(AffixAttr.pPyro); } }
        public double Healing { get { return get_attribute(AffixAttr.pHealing); } }
        public int LevelIndex
        {
            get
            {
                return level;
            }
        }
        public string Level
        {
            get
            {
                return level_str[level];
            }
        }
        private int level = 0;
        private string[] level_str = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "20+", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "40+", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "50+", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "60+", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "70+", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "80+", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90" };
        public ElementType Vision { get; private set; }
        public List<Affix> BaseStat {  get; private set; }
        public Weapon Weapon { get; private set; }
        public WeaponType WeaponType { get; private set; }
        public List<Talent> Talents { get; private set; }
        public Artifact[] Artifacts { get; private set; }
        private List<Affix> stat = new List<Affix>();
        public List<Affix> Stat
        { 
            get
            {
                stat.Clear();
                stat.AddRange(BaseStat);
                for (int i = 0; i < Artifacts.Length; i++)
                {
                    if (Artifacts[i] != null)
                    {
                        stat.Add(Artifacts[i].MainAffix);
                        stat.AddRange(Artifacts[i].MinorAffixes);
                    }
                }
                return stat;
            }
        }

        public double GetStat(WaifuStat stat)
        {
            switch (stat)
            {
                case WaifuStat.HP:
                    return this.HP;
                case WaifuStat.BaseHP:
                    return this.BaseStat.Where(x => x.Attribute == AffixAttr.HP).ToList()[0].Value;
                case WaifuStat.ATK:
                    return this.ATK;
                case WaifuStat.DEF:
                    return this.DEF;
                case WaifuStat.ELM:
                default:
                    return this.ELM;
            }
        }

        public void SetWeapon(Weapon weapon)
        {
            this.Weapon = weapon;
        }
        public void SetAritfacts(Artifact[] artifacts)
        {
            this.Artifacts = artifacts;
        }

        public void SetAritfact(Artifact artifact)
        {
            switch (artifact.Type)
            {
                case ArtifactType.FlowerOfLife:
                    this.Artifacts[0] = artifact;
                    break;
                case ArtifactType.PlumeOfDeath:
                    this.Artifacts[1] = artifact;
                    break;
                case ArtifactType.SandsOfEon:
                    this.Artifacts[2] = artifact;
                    break;
                case ArtifactType.GobletOfEonothem:
                    this.Artifacts[3] = artifact;
                    break;
                case ArtifactType.CircletOfLogos:
                default:
                    this.Artifacts[4] = artifact;
                    break;
            }
        }

        private double get_attribute(AffixAttr attr)
        {
            double val = BaseStat.Where(x => x.Attribute == attr).Sum(x => x.Value);
            // Artifact
            val += this.Artifacts.Where(x => x != null && x.MainAffix.Attribute == attr).Sum(x => x.MainAffix.Value);
            for (int i = 0; i < 5; i++)
            {
                if (this.Artifacts[i] != null)
                {
                    val += this.Artifacts[i].MinorAffixes.Where(x => x.Attribute == attr).Sum(x => x.Value);
                }
            }
            // Weapon
            if (this.Weapon != null)
            {
                if (this.Weapon.BaseATK.Attribute == attr)
                {
                    val += this.Weapon.BaseATK.Value;
                }
                if (this.Weapon.SecondaryStat.Attribute == attr)
                {
                    val += this.Weapon.SecondaryStat.Value;
                }
                foreach (var ability in Weapon.SpecialAbility.Abilities)
                {
                    if (ability.SpecialCond == SpecialCond.Always)
                    {
                        if (ability.Type == AbilityType.Simple)
                        {
                            if (ability.Affix.Attribute == attr)
                            {
                                val+= ability.Affix.Value;
                            }

                        }
                        if (ability.Type == AbilityType.Bonus)
                        {
                            if (ability.Affix.Attribute == attr)
                            {
                                val+= ability.Affix.Value * GetStat(ability.BonusBase);
                            }
                        }
                    }
                }
            }
            return val;
        }

        private double get_attribute(AffixAttr attr_base, AffixAttr attr_pct)
        {
            // Base Stat
            double val_base = BaseStat.Where(x => x.Attribute == attr_base).Sum(x => x.Value);
            double val_base_pct = BaseStat.Where(x => x.Attribute == attr_pct).Sum(x => x.Value);
            // Artifact
            double val_artifact = this.Artifacts.Where(x => x != null && x.MainAffix.Attribute == attr_base).Sum(x => x.MainAffix.Value);
            double val_artifact_pct = this.Artifacts.Where(x => x != null && x.MainAffix.Attribute == attr_pct).Sum(x => x.MainAffix.Value);
            for (int i = 0; i < 5; i++)
            {
                if (this.Artifacts[i] != null)
                {
                    val_artifact += this.Artifacts[i].MinorAffixes.Where(x => x.Attribute == attr_base).Sum(x => x.Value);
                    val_artifact_pct += this.Artifacts[i].MinorAffixes.Where(x => x.Attribute == attr_pct).Sum(x => x.Value);
                }
            }
            // Artifact Set Effect
            double val_set_effect = 0;
            double val_set_effect_pct = 0;
            if (this.Artifacts[0] != null && this.Artifacts[0].ArtifactSetEffect != null)
            {
                foreach (var effect in this.Artifacts[0].ArtifactSetEffect.Effects )
                {
                    if (effect.SpecialCond == SpecialCond.Always)
                    {
                        if (effect.Affix.Attribute == attr_base)
                        {
                            val_set_effect += effect.Affix.Value;
                        }
                        if (effect.Affix.Attribute == attr_pct)
                        {
                            val_set_effect_pct += effect.Affix.Value;
                        }
                    }
                }
            }
            // Weapon
            double val_weapon_base = 0;
            double val_weapon = 0;
            double val_weapon_pct = 0;
            if (this.Weapon != null)
            {
                if (this.Weapon.BaseATK.Attribute == attr_base)
                {
                    val_weapon_base += this.Weapon.BaseATK.Value;
                }
                if (this.Weapon.SecondaryStat.Attribute == attr_base)
                {
                    val_weapon += this.Weapon.SecondaryStat.Value;
                } else if (this.Weapon.SecondaryStat.Attribute == attr_pct)
                {
                    val_weapon_pct += this.Weapon.SecondaryStat.Value;
                }
                foreach (var ability in Weapon.SpecialAbility.Abilities)
                {
                    if (ability.SpecialCond == SpecialCond.Always)
                    {
                        if (ability.Type == AbilityType.Simple)
                        {
                            if (ability.Affix.Attribute == attr_base)
                            {
                                val_weapon += ability.Affix.Value;
                            }
                            if (ability.Affix.Attribute == attr_pct)
                            {
                                val_weapon_pct += ability.Affix.Value;
                            }

                        }
                        if (ability.Type == AbilityType.Bonus)
                        {
                            if (ability.Affix.Attribute == attr_base)
                            {
                                val_weapon += ability.Affix.Value * GetStat(ability.BonusBase);
                            }
                            if (ability.Affix.Attribute == attr_pct)
                            {
                                val_weapon_pct += ability.Affix.Value * GetStat(ability.BonusBase);
                            }
                        }
                    }
                }
            }
            return Math.Round(
                (val_base + val_weapon_base) +
                (val_artifact) +
                (val_base + val_weapon_base) * (val_artifact_pct) +
                (val_set_effect) +
                (val_base + val_weapon_base) * (val_set_effect_pct) +
                (val_weapon) +
                (val_base + val_weapon_base) * (val_weapon_pct)
                );
        }

        public Waifu(string name, ElementType vision, WeaponType weapon_type, List<Affix> stat, List<Talent> talents, int level = 0)
        {
            this.Name = name;
            this.Vision = vision;
            this.WeaponType = weapon_type;
            this.Talents = talents;
            this.BaseStat = stat;
            this.level = level;
            this.Artifacts = new Artifact[5];
        }

        public void SetLevel(int level)
        {
            this.level = level;
            foreach (var item in BaseStat)
            {
                item.SetLevel(level - 1);
            }
        }
    }

    public class Talent
    {
        public string Name { get; private set; }
        public List<double> Actions { get; private set; }

        public Talent(string name)
        {
            this.Name = name;
            this.Actions = new List<double>();
        }

        public Talent(string name, double[] actions)
        {
            this.Name = name;
            this.Actions = new List<double>();
            this.Actions.AddRange(actions);
        }
    }
}
