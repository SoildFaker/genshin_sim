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
        public int Level { get; private set; }
        public ElementType Vision { get; private set; }
        public List<Affix> BaseStat {  get; private set; }
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
        public Weapon Weapon { get; set; }

        private double get_attribute(AffixAttr attr)
        {
            double val = BaseStat.Where(x => x.Attribute == attr).Sum(x => x.Value);
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
            val += this.Artifacts.Where(x => x != null && x.MainAffix.Attribute == attr_base).Sum(x => x.MainAffix.Value);
            for (int i = 0; i < 5; i++)
            {
                if (this.Artifacts[i] != null)
                {
                    val += this.Artifacts[i].MinorAffixes.Where(x => x.Attribute == attr_base).Sum(x => x.Value);
                }
            }
            double val_pct = BaseStat.Where(x => x.Attribute == attr_pct).Sum(x => x.Value);
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

        public Waifu(string name, ElementType vision, List<Affix> stat, List<Talent> talents, int level = 1)
        {
            this.Name = name;
            this.Vision = vision;
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
