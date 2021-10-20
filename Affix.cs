using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    public enum AffixAttr
    {
        HP,
        ATK,
        DEF,
        ELM,
        pHP,
        pATK,
        pDEF,
        pCGR,
        pCRI,
        pCRD,
        pPhysical,
        pHydro,
        pCryo,
        pElectro,
        pAnemo,
        pGeo,
        pHealing,
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

        public static Affix CGR_4p5 = new Affix(AffixAttr.pCGR, 4.5);
        public static Affix CGR_5p2 = new Affix(AffixAttr.pCGR, 5.2);
        public static Affix CGR_5p8 = new Affix(AffixAttr.pCGR, 5.8);
        public static Affix CGR_6p5 = new Affix(AffixAttr.pCGR, 6.5);

        public static Affix DEF_5p1 = new Affix(AffixAttr.pDEF, 5.1);
        public static Affix DEF_5p8 = new Affix(AffixAttr.pDEF, 5.8);
        public static Affix DEF_6p6 = new Affix(AffixAttr.pDEF, 6.6);
        public static Affix DEF_7p3 = new Affix(AffixAttr.pDEF, 7.3);

        public static Affix HP_4p1 = new Affix(AffixAttr.pHP, 4.1);
        public static Affix HP_4p7 = new Affix(AffixAttr.pHP, 4.7);
        public static Affix HP_5p3 = new Affix(AffixAttr.pHP, 5.3);
        public static Affix HP_5p8 = new Affix(AffixAttr.pHP, 5.8);

        public static Affix ATK_4p1 = new Affix(AffixAttr.pATK, 4.1);
        public static Affix ATK_4p7 = new Affix(AffixAttr.pATK, 4.7);
        public static Affix ATK_5p3 = new Affix(AffixAttr.pATK, 5.3);
        public static Affix ATK_5p8 = new Affix(AffixAttr.pATK, 5.8);

        public static Affix CRI_2p7 = new Affix(AffixAttr.pCRI, 2.7);
        public static Affix CRI_3p1 = new Affix(AffixAttr.pCRI, 3.1);
        public static Affix CRI_3p5 = new Affix(AffixAttr.pCRI, 3.5);
        public static Affix CRI_3p9 = new Affix(AffixAttr.pCRI, 3.9);

        public static Affix CRD_5p4 = new Affix(AffixAttr.pCRD, 5.4);
        public static Affix CRD_6p2 = new Affix(AffixAttr.pCRD, 6.2);
        public static Affix CRD_7p0 = new Affix(AffixAttr.pCRD, 7.0);
        public static Affix CRD_7p8 = new Affix(AffixAttr.pCRD, 7.8);

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
            AffixAttr.pHydro,
            AffixAttr.pCryo,
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
                    return new double[4]{4.1, 4.7, 5.3, 5.8}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.DEF:
                    return new double[4]{16, 19, 21, 23}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.pDEF:
                    return new double[4]{5.1, 5.8, 6.6, 7.3}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.ATK:
                    return new double[4]{14, 16, 18, 19}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.pATK:
                    return new double[4]{4.1, 4.7, 5.3, 5.8}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.pCGR:
                    return new double[4]{4.5, 5.2, 5.8, 6.5}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.pCRD:
                    return new double[4]{5.4, 6.2, 7.0, 7.8}[AffixFactory.rand.Next(0,4)];
                case AffixAttr.pCRI:
                    return new double[4]{2.7, 3.1, 3.5, 3.9}[AffixFactory.rand.Next(0,4)];
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
                case AffixAttr.pHydro: return "火属性伤害加成";
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

        public string Description
        {
            get
            {
                return AffixFactory.attr2str(Attribute) + " + " + Value.ToString() + (Attribute.ToString().StartsWith("p") ? "%" : "");
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

    }
}
