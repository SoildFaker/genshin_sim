using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    public enum WeaponType
    {
        Sword,
        Claymore,
        Polearm,
        Bow,
        Catalyst
    }

    public class Weapon
    {
        public WeaponType Type {  get; private set; }
        public string Name { get; private set; }
        private int level = 0;
        public int LevelIndex
        {
            get { return level; }
        }
        private string[] level_str = new string[] { "1", "5", "10", "15", "20", "20+", "25", "30", "35", "40", "40+", "45", "50", "50+", "55", "60", "60+", "65", "70", "70+", "75", "80", "80+", "85", "90"};
        public string Level
        {
            get
            {
                return level_str[level];
            }
        }
        public string Description { get; private set; }
        public Affix BaseATK { get; private set; }
        public Affix SecondaryStat { get; private set; }

        public WeaponSpecialAbility SpecialAbility { get; private set; }

        public Weapon(string name, WeaponType type, Affix base_atk, Affix secondary, WeaponSpecialAbility ability, int lv = 0)
        {
            this.Name = name;
            this.Type = type;
            this.level = lv;
            this.BaseATK = base_atk;
            this.SecondaryStat = secondary;
            this.SpecialAbility = ability;
        }

        public void SetLevel(int lv)
        {
            this.level = lv;
            this.BaseATK.SetLevel(lv);
            this.SecondaryStat.SetLevel(lv);
        }
    }

    public enum SpecialCond
    {
        Always,
        TakingDMG,
    }

    public class SpecialCondAbility
    {
        public SpecialCond SpecialCond { get; private set; }
        public Affix Affix { get; private set; }

        public SpecialCondAbility(SpecialCond cond, Affix affix)
        {
            this.SpecialCond = cond;
            this.Affix = affix;
        }
    }

    public class WeaponSpecialAbility
    {
        public int Level { get; private set; }
        public string Name { get; private set; }
        public List<SpecialCondAbility> Abilities { get; private set; }
        private string description;
        public string Description
        {
            get
            {
                return String.Format(description, Abilities.Select(x => x.Affix.Value.ToString("0.0%")).ToArray());
            }
        }
        public WeaponSpecialAbility(string name, List<SpecialCondAbility> abilities, string desc, int lv = 0)
        {
            this.Name = name;
            this.Abilities = abilities;
            this.description = desc;
            this.Level = lv;
        }

        public void SetLevel(int lv)
        {
            this.Level = lv < 5 ? (lv >= 0 ? lv : 0) : 4;
            for (int i = 0; i < Abilities.Count; i++)
            {
                Abilities[i].Affix.SetLevel(this.Level);
            }
        }
    }
}
