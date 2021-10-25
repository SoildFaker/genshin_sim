using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    public enum AffixAttr : int
    {
        HP,         // 生命加成
        ATK,        // 攻击加成
        DEF,        // 防御加成
        pHP,        // 生命百分比加成
        pATK,       // 攻击百分比加成
        pDEF,       // 防御百分比加成
        ELM,        // 元素精通
        pCGR,       // 充能效率
        pCRI,       // 暴击率
        pCRD,       // 暴击伤害
        pPhysical,  // 物理伤害加成
        pPyro,      // 火属性伤害加成
        pHydro,     // 水属性伤害加成
        pCryo,      // 冰属性伤害加成
        pDendro,    // 草属性伤害加成
        pElectro,   // 雷属性伤害加成
        pAnemo,     // 风属性伤害加成
        pGeo,       // 岩属性伤害加成
        pHealing,   // 治疗效果加成
    }

    public class Affix
    {
        public AffixAttr Attribute { get; private set; }
        public double Value { get; set; }
        private int level = 0;
        private List<double> value_arr = new List<double>();
        public string Description
        {
            get
            {
                if (Attribute.ToString().StartsWith("p"))
                {
                    return AffixFactory.attr2str(Attribute) + " + " + Value.ToString("0.0%");
                }
                else
                {
                    return AffixFactory.attr2str(Attribute) + " + " + Value.ToString();
                }
            }
        }

        public Affix(AffixAttr attr, double val)
        {
            this.Attribute = attr;
            this.Value = val;
        }
        public Affix(AffixAttr attr)
        {
            this.Attribute = attr;
            this.Value = AffixFactory.pick_minor_affix_value(attr);
        }

        public Affix(AffixAttr attr, double[] vals, int lv)
        {
            this.Attribute = attr;
            this.Value = vals[lv];
            this.value_arr.AddRange(vals);
        }

        public void SetValueArray(double[] vals, int lv = 0)
        {
            value_arr.Clear();
            value_arr.AddRange(vals);
            SetLevel(lv);
        }

        public void SetLevel(int lv)
        {
            if (lv > 0 && lv < value_arr.Count)
            {
                this.level = lv;
                this.Value = value_arr[level];
            }
            else
            {
                this.level = 0;
            }
        }

        public void LevelUp()
        {
            if (level < value_arr.Count - 1)
            {
                level++;
                this.Value = value_arr[level];
            }
        }

    }
}
