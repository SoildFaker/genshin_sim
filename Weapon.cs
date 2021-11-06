using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    public enum WeaponType
    {
        Unknow,
        Sword,
        Claymore,
        Polearm,
        Bow,
        Catalyst
    }

    public class Weapon
    {
        public int ImageIndex { get; private set; }
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

        public Weapon(string name, WeaponType type, Affix base_atk, Affix secondary, WeaponSpecialAbility ability, int image_index, int lv = 0)
        {
            this.Name = name;
            this.Type = type;
            this.level = lv;
            this.BaseATK = base_atk;
            this.SecondaryStat = secondary;
            this.SpecialAbility = ability;
            this.ImageIndex = image_index;
        }

        public void SetLevel(int lv)
        {
            this.level = lv;
            this.BaseATK.SetLevel(lv);
            this.SecondaryStat.SetLevel(lv);
        }
    }

    public enum SpecialCond : ulong
    {
        Always = ((ulong)1 << 0),
        ClearWeapon = (0xffffffffffffffc1),
        UsingSword = ((ulong)1 << 1),
        UsingClaymore = ((ulong)1 << 2),
        UsingBow = ((ulong)1 << 3),
        UsingPolearm = ((ulong)1 << 4),
        UsingCatalyst = ((ulong)1 << 5),
        ClearAttack = (0xfffffffffffff83f),
        OnNormalAttack = ((ulong)1 << 6),
        OnChargedAttack = ((ulong)1 << 7),
        OnPlungingAttack = ((ulong)1 << 8),
        OnElementSkill = ((ulong)1 << 9),
        OnElementBurst = ((ulong)1 << 10),
        TakingDMG = ((ulong)1 << 11),
        ClearElement = (0xfffffffffff00fff),
        EnemyTakeCryoElement = ((ulong)1 << 12),
        EnemyTakePyroElement = ((ulong)1 << 13),
        EnemyTakeHydroElement = ((ulong)1 << 14),
        EnemyTakeAnemoElement = ((ulong)1 << 15),
        EnemyTakeElectroElement = ((ulong)1 << 16),
        EnemyTakeGeoElement = ((ulong)1 << 17),
        EnemyTakeDendroElement = ((ulong)1 << 18),
        EnemyFrozen = ((ulong)1 << 19),
        TimeDelay = ((ulong)1 << 20),
        Ignore = ((ulong)1 << 63),
    }

    public enum AbilityType
    {
        Simple,
        Bonus,
    }

    public class SpecialCondAbility
    {
        public AbilityType Type { get; private set; }
        public SpecialCond SpecialCond { get; private set; }
        public WaifuStat BonusBase { get; private set; }
        public Affix Affix { get; private set; }

        public SpecialCondAbility(SpecialCond cond, AbilityType type, Affix affix, WaifuStat bonus_base = WaifuStat.HP)
        {
            this.SpecialCond = cond;
            this.Type = type;
            this.Affix = affix;
            this.BonusBase = bonus_base;
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
                return String.Format(description, Abilities.Select(x => x.Affix.Attribute.ToString().StartsWith("p") ? x.Affix.Value.ToString("0.0%") : x.Affix.Value.ToString()).ToArray());
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
            this.Level = lv > 4 ? 4 : (lv < 0 ? 0 : lv);
            for (int i = 0; i < Abilities.Count; i++)
            {
                Abilities[i].Affix.SetLevel(this.Level);
            }
        }
    }
}
