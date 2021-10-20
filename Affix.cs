using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    public enum AffixAttr
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

    public static class AffixFactory
    {
        public static Affix HP_209 = new Affix(AffixAttr.HP, 209);
        public static Affix HP_239 = new Affix(AffixAttr.HP, 239);
        public static Affix HP_269 = new Affix(AffixAttr.HP, 269);
        public static Affix HP_299 = new Affix(AffixAttr.HP, 299);

        public static Affix ATK_14 = new Affix(AffixAttr.ATK, 14);
        public static Affix ATK_16 = new Affix(AffixAttr.ATK, 16);
        public static Affix ATK_18 = new Affix(AffixAttr.ATK, 18);
        public static Affix ATK_19 = new Affix(AffixAttr.ATK, 19);

        public static Affix DEF_16 = new Affix(AffixAttr.DEF, 16);
        public static Affix DEF_19 = new Affix(AffixAttr.DEF, 19);
        public static Affix DEF_21 = new Affix(AffixAttr.DEF, 21);
        public static Affix DEF_23 = new Affix(AffixAttr.DEF, 23);

        public static Affix ELM_16 = new Affix(AffixAttr.ELM, 16);
        public static Affix ELM_19 = new Affix(AffixAttr.ELM, 19);
        public static Affix ELM_21 = new Affix(AffixAttr.ELM, 21);
        public static Affix ELM_23 = new Affix(AffixAttr.ELM, 23);

        public static Affix CGR_4p5 = new Affix(AffixAttr.pCGR, 0.045);
        public static Affix CGR_5p2 = new Affix(AffixAttr.pCGR, 0.052);
        public static Affix CGR_5p8 = new Affix(AffixAttr.pCGR, 0.058);
        public static Affix CGR_6p5 = new Affix(AffixAttr.pCGR, 0.065);

        public static Affix DEF_5p1 = new Affix(AffixAttr.pDEF, 0.051);
        public static Affix DEF_5p8 = new Affix(AffixAttr.pDEF, 0.058);
        public static Affix DEF_6p6 = new Affix(AffixAttr.pDEF, 0.066);
        public static Affix DEF_7p3 = new Affix(AffixAttr.pDEF, 0.073);

        public static Affix HP_4p1 = new Affix(AffixAttr.pHP, 0.041);
        public static Affix HP_4p7 = new Affix(AffixAttr.pHP, 0.047);
        public static Affix HP_5p3 = new Affix(AffixAttr.pHP, 0.053);
        public static Affix HP_5p8 = new Affix(AffixAttr.pHP, 0.058);

        public static Affix ATK_4p1 = new Affix(AffixAttr.pATK, 0.041);
        public static Affix ATK_4p7 = new Affix(AffixAttr.pATK, 0.047);
        public static Affix ATK_5p3 = new Affix(AffixAttr.pATK, 0.053);
        public static Affix ATK_5p8 = new Affix(AffixAttr.pATK, 0.058);

        public static Affix CRI_2p7 = new Affix(AffixAttr.pCRI, 0.027);
        public static Affix CRI_3p1 = new Affix(AffixAttr.pCRI, 0.031);
        public static Affix CRI_3p5 = new Affix(AffixAttr.pCRI, 0.035);
        public static Affix CRI_3p9 = new Affix(AffixAttr.pCRI, 0.039);

        public static Affix CRD_5p4 = new Affix(AffixAttr.pCRD, 0.054);
        public static Affix CRD_6p2 = new Affix(AffixAttr.pCRD, 0.062);
        public static Affix CRD_7p0 = new Affix(AffixAttr.pCRD, 0.070);
        public static Affix CRD_7p8 = new Affix(AffixAttr.pCRD, 0.078);

        public static Affix[] minor_affixes_arr = new Affix[40] 
        {
            HP_209, HP_239, HP_269, HP_299,
            HP_4p1, HP_4p7, HP_5p3, HP_5p8,
            ATK_14, ATK_14, ATK_18, ATK_19,
            ATK_4p1, ATK_4p7, ATK_5p3, ATK_5p8,
            DEF_16, DEF_19, DEF_21, DEF_23,
            DEF_5p1, DEF_5p8, DEF_6p6, DEF_7p3,
            CRD_5p4, CRD_6p2, CRD_7p0, CRD_7p8,
            CRI_2p7, CRI_3p1, CRI_3p5, CRI_3p9,
            CGR_4p5, CGR_5p2, CGR_5p8, CGR_4p5,
            ELM_16, ELM_19, ELM_21, ELM_23,
        };

        public static AffixAttr[] minor_affix_attr_arr = new AffixAttr[]
        {
            AffixAttr.HP,
            AffixAttr.ATK,
            AffixAttr.DEF,
            AffixAttr.ELM,
            AffixAttr.pHP,
            AffixAttr.pATK,
            AffixAttr.pDEF,
            AffixAttr.pCGR,
            AffixAttr.pCRI,
            AffixAttr.pCRD,
        };

        public static AffixAttr[] goblet_main_affix_attr_arr = new AffixAttr[]
        {
            AffixAttr.ELM,
            AffixAttr.pHP,
            AffixAttr.pATK,
            AffixAttr.pDEF,
            AffixAttr.pPhysical,
            AffixAttr.pPyro,
            AffixAttr.pHydro,
            AffixAttr.pCryo,
            AffixAttr.pDendro,
            AffixAttr.pAnemo,
            AffixAttr.pGeo,
            AffixAttr.pElectro,
        };

        public static AffixAttr[] sands_main_affix_attr_arr = new AffixAttr[]
        {
            AffixAttr.ELM,
            AffixAttr.pHP,
            AffixAttr.pATK,
            AffixAttr.pDEF,
            AffixAttr.pCGR,
        };

        public static AffixAttr[] circlet_main_affix_attr_arr = new AffixAttr[]
        {
            AffixAttr.ELM,
            AffixAttr.pHP,
            AffixAttr.pATK,
            AffixAttr.pDEF,
            AffixAttr.pCRI,
            AffixAttr.pCRD,
            AffixAttr.pHealing,
        };

        public static Random rand = new Random();
        public static Affix pick_minor_affixes()
        {
            return minor_affixes_arr[rand.Next(minor_affixes_arr.Length)];
        }

        public static Affix pick_main_affixes(ArtifactType type)
        {
            switch (type)
            {
                case ArtifactType.FlowerOfLife:
                    return new Affix(AffixAttr.HP);
                case ArtifactType.PlumeOfDeath:
                    return new Affix(AffixAttr.ATK);
                case ArtifactType.SandsOfEon:
                    return new Affix(sands_main_affix_attr_arr[rand.Next(sands_main_affix_attr_arr.Length)]);
                case ArtifactType.GobletOfEonothem:
                    return new Affix(goblet_main_affix_attr_arr[rand.Next(goblet_main_affix_attr_arr.Length)]);
                case ArtifactType.CircletOfLogos:
                    return new Affix(circlet_main_affix_attr_arr[rand.Next(circlet_main_affix_attr_arr.Length)]);
            }
           return new Affix(AffixAttr.HP);
        }

        public static double pick_minor_affix_value(AffixAttr attr)
        {
            switch (attr)
            {
                case AffixAttr.HP:
                    return new double[4]{209, 239, 269, 299}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.pHP:
                    return new double[4]{0.041, 0.047, 0.053, 0.058}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.DEF:
                    return new double[4]{16, 19, 21, 23}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.pDEF:
                    return new double[4]{0.051, 0.058, 0.066, 0.073}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.ATK:
                    return new double[4]{14, 16, 18, 19}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.pATK:
                    return new double[4]{0.041, 0.047, 0.053, 0.058}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.pCGR:
                    return new double[4]{0.045, 0.052, 0.058, 0.065}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.pCRD:
                    return new double[4]{0.054, 0.062, 0.070, 0.078}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.pCRI:
                    return new double[4]{0.027, 0.031, 0.035, 0.039}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.ELM:
                    return new double[4]{16, 19, 21, 23}[AffixFactory.rand.Next(0,4)];
            }
            return -1;
        }
        public static string attr2str(AffixAttr attr)
        {
            switch (attr)
            {
                case AffixAttr.HP: return "生命值";
                case AffixAttr.ATK: return "攻击力";
                case AffixAttr.DEF: return "防御力";
                case AffixAttr.pHP: return "生命值";
                case AffixAttr.pATK: return "攻击力";
                case AffixAttr.pDEF: return "防御力";
                case AffixAttr.ELM: return "元素精通";
                case AffixAttr.pCGR: return "充能效率";
                case AffixAttr.pCRI: return "暴击率";
                case AffixAttr.pCRD: return "暴击伤害";
                case AffixAttr.pPhysical: return "物理伤害加成";
                case AffixAttr.pPyro: return "火属性伤害加成";
                case AffixAttr.pHydro: return "水属性伤害加成";
                case AffixAttr.pDendro: return "草属性伤害加成";
                case AffixAttr.pCryo: return "冰属性伤害加成";
                case AffixAttr.pElectro: return "雷属性伤害加成";
                case AffixAttr.pAnemo: return "风属性伤害加成";
                case AffixAttr.pGeo: return "岩属性伤害加成";
                case AffixAttr.pHealing: return "治疗效果加成";
                default: return "？？？";
            }
        }
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
            if (lv < value_arr.Count)
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
            if (level < value_arr.Count)
            {
                level++;
                this.Value = value_arr[level];
            }
        }

    }
}
