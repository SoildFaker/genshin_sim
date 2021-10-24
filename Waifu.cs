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
        public int Level { get; private set; }
        public ElementType Vision { get; private set; }
        public List<Affix> BaseStat {  get; private set; }
        public Weapon Weapon { get; set; }
        public WeaponType WeaponType { get; private set; }
        public List<Talent> Talents { get; private set; }
        public Artifact[] Artifacts = new Artifact[5];
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

        private double get_attribute(AffixAttr attr)
        {
            double val = BaseStat.Where(x => x.Attribute == attr).Sum(x => x.Value);
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
                    if (ability.SpecialCond == SpecialCond.Always && ability.Affix.Attribute == attr)
                    {
                        val += ability.Affix.Value;
                    }
                }
            }
            // Artifact
            val += this.Artifacts.Where(x => x != null && x.MainAffix.Attribute == attr).Sum(x => x.MainAffix.Value);
            for (int i = 0; i < 5; i++)
            {
                if (this.Artifacts[i] != null)
                {
                    val += this.Artifacts[i].MinorAffixes.Where(x => x.Attribute == attr).Sum(x => x.Value);
                }
            }
            return val;
        }

        private double get_attribute(AffixAttr attr_base, AffixAttr attr_pct)
        {
            double val = BaseStat.Where(x => x.Attribute == attr_base).Sum(x => x.Value);
            // Weapon
            if (this.Weapon != null)
            {
                if (this.Weapon.BaseATK.Attribute == attr_base)
                {
                    val += this.Weapon.BaseATK.Value;
                }
                if (this.Weapon.SecondaryStat.Attribute == attr_base)
                {
                    val += this.Weapon.SecondaryStat.Value;
                }
                foreach (var ability in Weapon.SpecialAbility.Abilities)
                {
                    if (ability.SpecialCond == SpecialCond.Always && ability.Affix.Attribute == attr_base)
                    {
                        val += ability.Affix.Value;
                    }
                }
            }
            // Artifact
            val += this.Artifacts.Where(x => x != null && x.MainAffix.Attribute == attr_base).Sum(x => x.MainAffix.Value);
            for (int i = 0; i < 5; i++)
            {
                if (this.Artifacts[i] != null)
                {
                    val += this.Artifacts[i].MinorAffixes.Where(x => x.Attribute == attr_base).Sum(x => x.Value);
                }
            }
            double val_pct = BaseStat.Where(x => x.Attribute == attr_pct).Sum(x => x.Value);
            // Weapon
            if (this.Weapon != null)
            {
                if (this.Weapon.SecondaryStat.Attribute == attr_pct)
                {
                    val_pct += this.Weapon.SecondaryStat.Value;
                }
                foreach (var ability in Weapon.SpecialAbility.Abilities)
                {
                    if (ability.SpecialCond == SpecialCond.Always && ability.Affix.Attribute == attr_pct)
                    {
                        val_pct += ability.Affix.Value;
                    }
                }
            }
            // Artifact
            val_pct += this.Artifacts.Where(x => x != null && x.MainAffix.Attribute == attr_pct).Sum(x => x.MainAffix.Value);
            for (int i = 0; i < 5; i++)
            {
                if (this.Artifacts[i] != null)
                {
                    val_pct += this.Artifacts[i].MinorAffixes.Where(x => x.Attribute == attr_pct).Sum(x => x.Value);
                }
            }
            return Math.Round(val * (1 + val_pct));
        }

        public Waifu(string name, ElementType vision, WeaponType weapon_type, List<Affix> stat, List<Talent> talents, int level = 1)
        {
            this.Name = name;
            this.Vision = vision;
            this.WeaponType = weapon_type;
            this.Talents = talents;
            this.BaseStat = stat;
            this.Level = level;
        }

        public void SetLevel(int level)
        {
            this.Level = level;
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
