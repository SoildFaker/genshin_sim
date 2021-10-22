using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
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

        public static Affix[] flower_main_affix_arr = new Affix[]
        {
            new Affix(AffixAttr.HP, ArtifactFactory.value_array_type_hp, 0),
        };

        public static Affix[] plume_main_affix_arr = new Affix[]
        {
            new Affix(AffixAttr.ATK, ArtifactFactory.value_array_type_atk, 0),
        };

        public static Affix[] sands_main_affix_arr = new Affix[]
        {
            new Affix(AffixAttr.ELM, ArtifactFactory.value_array_type_elm, 0),
            new Affix(AffixAttr.pHP, ArtifactFactory.value_array_type_hp_pct, 0),
            new Affix(AffixAttr.pATK, ArtifactFactory.value_array_type_atk_pct, 0),
            new Affix(AffixAttr.pDEF, ArtifactFactory.value_array_type_def_pct, 0),
            new Affix(AffixAttr.pCGR, ArtifactFactory.value_array_type_cgr_pct, 0),
        };

        public static Affix[] goblet_main_affix_arr = new Affix[]
        {
            new Affix(AffixAttr.ELM, ArtifactFactory.value_array_type_elm, 0),
            new Affix(AffixAttr.pHP, ArtifactFactory.value_array_type_hp_pct, 0),
            new Affix(AffixAttr.pATK, ArtifactFactory.value_array_type_atk_pct, 0),
            new Affix(AffixAttr.pDEF, ArtifactFactory.value_array_type_def_pct, 0),
            new Affix(AffixAttr.pPhysical, ArtifactFactory.value_array_type_physical, 0),
            new Affix(AffixAttr.pPyro, ArtifactFactory.value_array_type_element, 0),
            new Affix(AffixAttr.pHydro, ArtifactFactory.value_array_type_element, 0),
            new Affix(AffixAttr.pCryo, ArtifactFactory.value_array_type_element, 0),
            new Affix(AffixAttr.pDendro, ArtifactFactory.value_array_type_element, 0),
            new Affix(AffixAttr.pAnemo, ArtifactFactory.value_array_type_element, 0),
            new Affix(AffixAttr.pGeo, ArtifactFactory.value_array_type_element, 0),
            new Affix(AffixAttr.pElectro, ArtifactFactory.value_array_type_element, 0),
        };

        public static Affix[] circlet_main_affix_arr = new Affix[]
        {
            new Affix(AffixAttr.ELM, ArtifactFactory.value_array_type_elm, 0),
            new Affix(AffixAttr.pHP, ArtifactFactory.value_array_type_hp_pct, 0),
            new Affix(AffixAttr.pATK, ArtifactFactory.value_array_type_atk_pct, 0),
            new Affix(AffixAttr.pDEF, ArtifactFactory.value_array_type_def_pct, 0),
            new Affix(AffixAttr.pCRI, ArtifactFactory.value_array_type_cri_pct, 0),
            new Affix(AffixAttr.pCRD, ArtifactFactory.value_array_type_crd_pct, 0),
            new Affix(AffixAttr.pHealing, ArtifactFactory.value_array_type_healing, 0),
        };

        public static Random rand = new Random();

        public static Affix[] get_artifact_main_affix_array(ArtifactType type)
        {
            switch (type)
            {
                case ArtifactType.FlowerOfLife: return flower_main_affix_arr;
                case ArtifactType.PlumeOfDeath: return plume_main_affix_arr;
                case ArtifactType.SandsOfEon: return sands_main_affix_arr;
                case ArtifactType.GobletOfEonothem: return goblet_main_affix_arr;
                case ArtifactType.CircletOfLogos: return circlet_main_affix_arr;
                default: return flower_main_affix_arr;
            }
        }
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
    public static class ArtifactFactory
    {
        public static Random rand = new Random();
        public static double[] value_array_type_hp = new double[21]{ 717, 920, 1123, 1326, 1530, 1733, 1936, 2139, 2342, 2545, 2749, 2952, 3155, 3358, 3561, 3764, 3967, 4171, 4374, 4577, 4780 };
        public static double[] value_array_type_atk = new double[21]{ 47, 60, 73, 86, 100, 113, 126, 139, 152, 166, 179, 192, 205, 219, 232, 245, 258, 272, 285, 298, 311 };
        public static double[] value_array_type_elm = new double[21]{ 28, 36, 44, 52, 60, 68, 76, 84, 91, 99, 107, 115, 123, 131, 139, 147, 155, 163, 171, 179, 187 };
        public static double[] value_array_type_hp_pct = new double[21]{ 0.07, 0.09, 0.11, 0.129, 0.149, 0.169, 0.189, 0.209, 0.228, 0.248, 0.268, 0.288, 0.308, 0.328, 0.347, 0.367, 0.387, 0.407, 0.427, 0.446, 0.466 };
        public static double[] value_array_type_atk_pct = new double[21]{ 0.07, 0.09, 0.11, 0.129, 0.149, 0.169, 0.189, 0.209, 0.228, 0.248, 0.268, 0.288, 0.308, 0.328, 0.347, 0.367, 0.387, 0.407, 0.427, 0.446, 0.466 };
        public static double[] value_array_type_def_pct = new double[21]{ 0.087, 0.112, 0.137, 0.162, 0.186, 0.211, 0.236, 0.261, 0.286, 0.31, 0.335, 0.36, 0.385, 0.409, 0.434, 0.459, 0.484, 0.508, 0.533, 0.558, 0.583 };
        public static double[] value_array_type_cgr_pct = new double[21]{ 0.078, 0.1, 0.122, 0.144, 0.166, 0.188, 0.21, 0.232, 0.254, 0.276, 0.298, 0.32, 0.342, 0.364, 0.386, 0.408, 0.43, 0.452, 0.474, 0.496, 0.518 };
        public static double[] value_array_type_cri_pct = new double[21]{ 0.047, 0.06, 0.073, 0.086, 0.099, 0.113, 0.126, 0.139, 0.152, 0.166, 0.179, 0.192, 0.205, 0.218, 0.232, 0.245, 0.258, 0.271, 0.284, 0.298, 0.311 };
        public static double[] value_array_type_crd_pct = new double[21]{ 0.093, 0.12, 0.146, 0.173, 0.199, 0.225, 0.252, 0.278, 0.305, 0.331, 0.357, 0.384, 0.41, 0.437, 0.463, 0.49, 0.516, 0.542, 0.569, 0.595, 0.622 };
        public static double[] value_array_type_healing = new double[21]{ 0.054, 0.069, 0.084, 0.1, 0.115, 0.13, 0.145, 0.161, 0.176, 0.191, 0.206, 0.221, 0.237, 0.252, 0.267, 0.282, 0.298, 0.313, 0.328, 0.343, 0.359 };
        public static double[] value_array_type_physical = new double[21]{ 0.087, 0.112, 0.137, 0.162, 0.186, 0.211, 0.236, 0.261, 0.286, 0.31, 0.335, 0.36, 0.385, 0.409, 0.434, 0.459, 0.484, 0.508, 0.533, 0.558, 0.583 };
        public static double[] value_array_type_element = new double[21]{ 0.07, 0.09, 0.11, 0.129, 0.149, 0.169, 0.189, 0.209, 0.228, 0.248, 0.268, 0.288, 0.308, 0.328, 0.347, 0.367, 0.387, 0.407, 0.427, 0.446, 0.466 };

        public static ArtifactType[] artifactTypes = new ArtifactType[]
        {
            ArtifactType.FlowerOfLife,
            ArtifactType.PlumeOfDeath,
            ArtifactType.SandsOfEon,
            ArtifactType.GobletOfEonothem,
            ArtifactType.CircletOfLogos,
        };

        public static Artifact pick()
        {
            return new Artifact(artifactTypes[rand.Next(artifactTypes.Length)]);
        }
    }

    public static class WaifuFactory
    {
        public static Waifu Albedo = new Waifu(
            "阿贝多",
            ElementType.Geo,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.albedo_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.albedo_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.albedo_base_def, 0),
                new Affix(AffixAttr.pGeo, StatData.albedo_geo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.albedo_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.albedo_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Amber = new Waifu(
            "安柏",
            ElementType.Pyro,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.amber_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.amber_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.amber_base_def, 0),
                new Affix(AffixAttr.pATK, StatData.amber_atk, 0),
                new Affix(AffixAttr.pCRD, StatData.amber_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.amber_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Keqing = new Waifu(
            "刻晴",
            ElementType.Electro,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.keqing_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.keqing_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.keqing_base_def, 0),
                new Affix(AffixAttr.pCRD, StatData.keqing_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.keqing_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Ayaka = new Waifu(
            "神里绫华",
            ElementType.Cryo,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.ayaka_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.ayaka_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.ayaka_base_def, 0),
                new Affix(AffixAttr.pCRD, StatData.ayaka_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.ayaka_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Zhongli = new Waifu(
            "钟离",
            ElementType.Geo,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.zhongli_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.zhongli_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.zhongli_base_def, 0),
                new Affix(AffixAttr.pGeo, StatData.zhongli_geo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.zhongli_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.zhongli_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Aloy = new Waifu(
            "埃洛伊",
            ElementType.Cryo,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.aloy_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.aloy_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.aloy_base_def, 0),
                new Affix(AffixAttr.pCryo, StatData.aloy_cryo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.aloy_cryo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRI, StatData.albedo_crit_rate, 0),
            } ,
            new List<Talent>()
        );
        public static Waifu[] Waifus = new Waifu[] 
        {
            Albedo, Aloy, Amber, Keqing, Ayaka, Zhongli
        };
    }
}
