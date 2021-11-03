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
            ATK_14, ATK_16, ATK_18, ATK_19,
            ATK_4p1, ATK_4p7, ATK_5p3, ATK_5p8,
            DEF_16, DEF_19, DEF_21, DEF_23,
            DEF_5p1, DEF_5p8, DEF_6p6, DEF_7p3,
            CRD_5p4, CRD_6p2, CRD_7p0, CRD_7p8,
            CRI_2p7, CRI_3p1, CRI_3p5, CRI_3p9,
            CGR_4p5, CGR_5p2, CGR_5p8, CGR_4p5,
            ELM_16, ELM_19, ELM_21, ELM_23,
        };

        public static AffixAttr[] waifu_stat_arr = new AffixAttr[]
        {
            AffixAttr.HP,
            AffixAttr.ATK,
            AffixAttr.DEF,
            AffixAttr.pHP,
            AffixAttr.pATK,
            AffixAttr.pDEF,
            AffixAttr.ELM,
            AffixAttr.pCGR,
            AffixAttr.pCRI,
            AffixAttr.pCRD,
            AffixAttr.pPhysical,
            AffixAttr.pPyro,
            AffixAttr.pHydro,
            AffixAttr.pCryo,
            AffixAttr.pDendro,
            AffixAttr.pElectro,
            AffixAttr.pAnemo,
            AffixAttr.pGeo,
            AffixAttr.pHealing,
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

        public static AffixAttr[] damage_boost_attr = new AffixAttr[]
        {
            AffixAttr.pPhysical,
            AffixAttr.pPyro,
            AffixAttr.pHydro,
            AffixAttr.pCryo,
            AffixAttr.pDendro,
            AffixAttr.pElectro,
            AffixAttr.pAnemo,
            AffixAttr.pGeo,
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
        public static Affix pick_minor_affix()
        {
            return minor_affixes_arr[rand.Next(minor_affixes_arr.Length)];
        }

        public static Affix pick_main_affixes(ArtifactType type)
        {
            switch (type)
            {
                case ArtifactType.FlowerOfLife:
                    return new Affix(AffixAttr.HP, 0);
                case ArtifactType.PlumeOfDeath:
                    return new Affix(AffixAttr.ATK, 0);
                case ArtifactType.SandsOfEon:
                    return new Affix(sands_main_affix_attr_arr[rand.Next(sands_main_affix_attr_arr.Length)], 0);
                case ArtifactType.GobletOfEonothem:
                    return new Affix(goblet_main_affix_attr_arr[rand.Next(goblet_main_affix_attr_arr.Length)], 0);
                case ArtifactType.CircletOfLogos:
                    return new Affix(circlet_main_affix_attr_arr[rand.Next(circlet_main_affix_attr_arr.Length)], 0);
            }
            return new Affix(AffixAttr.HP, 0);
        }

        public static Affix pick_minor_affix(AffixAttr attr)
        {
            Affix[] arr = minor_affixes_arr.Where(x => x.Attribute == attr).ToArray();
            return arr[rand.Next(arr.Length * 100) / 100];
        }

        public static string[] affix_names = new string[] {
            "生命值", "攻击力", "防御力", "生命加成", "攻击加成", "防御加成", "元素精通", "充能效率", "暴击率", "暴击伤害",
            "物理伤害加成", "火属性伤害加成", "水属性伤害加成", "冰属性伤害加成", "草属性伤害加成", "雷属性伤害加成", "风属性伤害加成", "岩属性伤害加成", "治疗效果加成",
            };
        public static string attr2str(AffixAttr attr)
        {
            return affix_names[((int)attr)];
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

        public static ArtifactSetEffect UnknowSetEffect = new ArtifactSetEffect(
            "未选择的套装特效",
            ArtifactSetEffectType.Unknow,
            new List<SpecialCondEffect>()
            {
            },
            "无" 
        );

        public static ArtifactSetEffect GladiatorsFinale = new ArtifactSetEffect(
            "角斗士的终幕礼",
            ArtifactSetEffectType.GladiatorsFinale,
            new List<SpecialCondEffect>()
            {
                new SpecialCondEffect(SpecialCond.Always, 2, AbilityType.Simple, new Affix(AffixAttr.pATK, 0.18)),
                new SpecialCondEffect(SpecialCond.UsingSword|SpecialCond.UsingClaymore|SpecialCond.UsingPolearm, 4, AbilityType.Simple, new Affix(AffixAttr.pNormalDMG, 0.35))
            },
            "两件套: 攻击力提高{0}。\r\n" + 
            "四件套: 装备该圣遗物套装的角色为单手剑、双手剑、长柄武器角色时，角色普通攻击造成的伤害提高{1}。"
        );

        public static ArtifactSetEffect BlizzardStrayer = new ArtifactSetEffect(
            "冰风迷途的勇士",
            ArtifactSetEffectType.BlizzardStrayer,
            new List<SpecialCondEffect>()
            {
                new SpecialCondEffect(SpecialCond.Always, 2, AbilityType.Simple, new Affix(AffixAttr.pCryo, 0.15)),
                new SpecialCondEffect(SpecialCond.EnemyTakeCryoElement, 4, AbilityType.Simple, new Affix(AffixAttr.pCRI, 0.20)),
                new SpecialCondEffect(SpecialCond.EnemyFrozen, 4, AbilityType.Simple, new Affix(AffixAttr.pCRI, 0.20))
            },
            "两件套: 获得{0}冰元素伤害加成\r\n" + 
            "四件套:	攻击处于冰元素影响状态下的敌人时，暴击率提高{1}；若敌人处于冰冻状态下，暴击率额外提高{2}。"
        );

        public static string[,] set_effect_names = new string[,] {
            { "未知的生之花", "未知的死之羽", "未知的时之沙", "未知的空之杯", "未知的理之冠" },
            { "角斗士的留恋", "角斗士的归宿", "角斗士的希冀", "角斗士的酣醉", "角斗士的凯旋" },
            { "历经风雪的思念", "摧冰而行的执望", "冰雪故园的终期", "遍结寒霜的傲骨", "破冰踏雪的回音" },
        }; 

        public static string get_artifact_name(ArtifactType artifact_type, ArtifactSetEffectType set_type)
        {
            return set_effect_names[((int)set_type), ((int)artifact_type)];
        }
        
        public static ArtifactSetEffect[] SetEffects = new ArtifactSetEffect[]
        {
            UnknowSetEffect,
            GladiatorsFinale,
            BlizzardStrayer,
        };

        public static string[] artifact_type_names = new string[]
        {
            "生之花", "死之羽", "时之沙", "空之杯", "理之冠",
        };

        public static string type2str(ArtifactType type)
        {
            return artifact_type_names[((int)type)];
        }

        public static Artifact pick()
        {
            return new Artifact(artifactTypes[rand.Next(artifactTypes.Length)]);
        }
    }

    public static class WaifuFactory
    {
        public static Waifu Albedo = new Waifu(
            "阿贝多",
            ElementalType.Geo,
            WeaponType.Sword,
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
            ElementalType.Pyro,
            WeaponType.Bow,
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
            ElementalType.Electro,
            WeaponType.Sword,
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
            ElementalType.Cryo,
            WeaponType.Sword,
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

        public static Waifu Aloy = new Waifu(
            "埃洛伊",
            ElementalType.Cryo,
            WeaponType.Bow,
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

        public static Waifu Barbara = new Waifu(
            "芭芭拉",
            ElementalType.Hydro,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.barbara_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.barbara_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.barbara_base_def, 0),
                new Affix(AffixAttr.pHP, StatData.barbara_hp, 0),
                new Affix(AffixAttr.pCRD, StatData.barbara_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.barbara_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Beidou = new Waifu(
            "北斗",
            ElementalType.Electro,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.beidou_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.beidou_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.beidou_base_def, 0),
                new Affix(AffixAttr.pElectro, StatData.beidou_electro_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.beidou_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.beidou_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Bennett = new Waifu(
            "班尼特",
            ElementalType.Pyro,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.benne_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.benne_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.benne_base_def, 0),
                new Affix(AffixAttr.pCGR, StatData.benne_energy_recharge, 0),
                new Affix(AffixAttr.pCRD, StatData.benne_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.benne_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Chongyun = new Waifu(
            "重云",
            ElementalType.Cryo,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.chongyun_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.chongyun_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.chongyun_base_def, 0),
                new Affix(AffixAttr.pATK, StatData.chongyun_atk, 0),
                new Affix(AffixAttr.pCRD, StatData.chongyun_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.chongyun_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Diluc = new Waifu(
            "迪卢克",
            ElementalType.Pyro,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.diluc_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.diluc_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.diluc_base_def, 0),
                new Affix(AffixAttr.pCRD, StatData.diluc_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.diluc_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Diona = new Waifu(
            "迪奥娜",
            ElementalType.Cryo,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.diona_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.diona_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.diona_base_def, 0),
                new Affix(AffixAttr.pPyro, StatData.diona_cryo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.diona_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.diona_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Eula = new Waifu(
            "尤拉",
            ElementalType.Cryo,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.eula_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.eula_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.eula_base_def, 0),
                new Affix(AffixAttr.pCRD, StatData.eula_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.eula_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Fischl = new Waifu(
            "菲谢尔",
            ElementalType.Electro,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.fisc_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.fisc_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.fisc_base_def, 0),
                new Affix(AffixAttr.pATK, StatData.fisc_atk, 0),
                new Affix(AffixAttr.pCRD, StatData.fisc_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.fisc_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Ganyu = new Waifu(
            "甘雨",
            ElementalType.Cryo,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.ganyu_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.ganyu_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.ganyu_base_def, 0),
                new Affix(AffixAttr.pCRD, StatData.ganyu_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.ganyu_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Hutao = new Waifu(
            "胡桃",
            ElementalType.Pyro,
            WeaponType.Polearm,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.hutao_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.hutao_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.hutao_base_def, 0),
                new Affix(AffixAttr.pCRD, StatData.hutao_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.hutao_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Jean = new Waifu(
            "琴",
            ElementalType.Anemo,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.jean_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.jean_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.jean_base_def, 0),
                new Affix(AffixAttr.pHealing, StatData.jean_healing_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.jean_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.jean_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Kaedehara = new Waifu(
            "枫原万叶",
            ElementalType.Anemo,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.kazuha_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.kazuha_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.kazuha_base_def, 0),
                new Affix(AffixAttr.ELM, StatData.kazuha_elemental_mastery, 0),
                new Affix(AffixAttr.pCRD, StatData.kazuha_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.kazuha_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Kaeya = new Waifu(
            "凯亚",
            ElementalType.Cryo,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.kaeya_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.kaeya_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.kaeya_base_def, 0),
                new Affix(AffixAttr.pCGR, StatData.kaeya_energy_recharge, 0),
                new Affix(AffixAttr.pCRD, StatData.kaeya_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.kaeya_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Klee = new Waifu(
            "可莉",
            ElementalType.Pyro,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.klee_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.klee_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.klee_base_def, 0),
                new Affix(AffixAttr.pPyro, StatData.klee_pyro_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.klee_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.klee_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Lisa = new Waifu(
            "丽莎",
            ElementalType.Electro,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.lisa_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.lisa_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.lisa_base_def, 0),
                new Affix(AffixAttr.ELM, StatData.lisa_elemental_mastery, 0),
                new Affix(AffixAttr.pCRD, StatData.lisa_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.lisa_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Mona = new Waifu(
            "莫娜",
            ElementalType.Hydro,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.mona_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.mona_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.mona_base_def, 0),
                new Affix(AffixAttr.pCGR, StatData.mona_energy_recharge, 0),
                new Affix(AffixAttr.pCRD, StatData.mona_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.mona_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Ningguang = new Waifu(
            "凝光",
            ElementalType.Geo,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.ningguang_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.ningguang_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.ningguang_base_def, 0),
                new Affix(AffixAttr.pGeo, StatData.ningguang_geo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.ningguang_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.ningguang_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Noelle = new Waifu(
            "诺艾尔",
            ElementalType.Geo,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.noelle_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.noelle_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.noelle_base_def, 0),
                new Affix(AffixAttr.pDEF, StatData.noelle_def, 0),
                new Affix(AffixAttr.pCRD, StatData.noelle_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.noelle_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Qiqi = new Waifu(
            "七七",
            ElementalType.Cryo,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.qiqi_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.qiqi_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.qiqi_base_def, 0),
                new Affix(AffixAttr.pHealing, StatData.qiqi_healing_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.qiqi_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.qiqi_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Raiden = new Waifu(
            "雷电将军",
            ElementalType.Electro,
            WeaponType.Polearm,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.shougun_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.shougun_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.shougun_base_def, 0),
                new Affix(AffixAttr.pCGR, StatData.shougun_energy_recharge, 0),
                new Affix(AffixAttr.pCRD, StatData.shougun_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.shougun_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Razor = new Waifu(
            "雷泽",
            ElementalType.Electro,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.razor_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.razor_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.razor_base_def, 0),
                new Affix(AffixAttr.pPhysical, StatData.razor_physical_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.razor_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.razor_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Rosaraia = new Waifu(
            "罗萨莉亚",
            ElementalType.Cryo,
            WeaponType.Polearm,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.rosaria_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.rosaria_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.rosaria_base_def, 0),
                new Affix(AffixAttr.pATK, StatData.rosaria_atk, 0),
                new Affix(AffixAttr.pCRD, StatData.rosaria_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.rosaria_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Kokomi = new Waifu(
            "珊瑚宫心海",
            ElementalType.Hydro,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.kokomi_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.kokomi_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.kokomi_base_def, 0),
                new Affix(AffixAttr.pHydro, StatData.kokomi_hydro_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.kokomi_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.kokomi_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Sayu = new Waifu(
            "早柚",
            ElementalType.Anemo,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.sayu_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.sayu_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.sayu_base_def, 0),
                new Affix(AffixAttr.ELM, StatData.sayu_elemental_mastery, 0),
                new Affix(AffixAttr.pCRD, StatData.sayu_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.sayu_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Sucrose = new Waifu(
            "砂糖",
            ElementalType.Anemo,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.sucrose_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.sucrose_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.sucrose_base_def, 0),
                new Affix(AffixAttr.pAnemo, StatData.sucrose_anemo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.sucrose_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.sucrose_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Tartaglia = new Waifu(
            "公子",
            ElementalType.Hydro,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.tartaglia_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.tartaglia_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.tartaglia_base_def, 0),
                new Affix(AffixAttr.pHydro, StatData.tartaglia_hydro_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.tartaglia_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.tartaglia_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Traveler = new Waifu(
            "旅行者",
            ElementalType.None,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.traveler_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.traveler_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.traveler_base_def, 0),
                new Affix(AffixAttr.pATK, StatData.traveler_atk, 0),
                new Affix(AffixAttr.pCRD, StatData.traveler_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.traveler_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Venti = new Waifu(
            "温蒂",
            ElementalType.Anemo,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.venti_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.venti_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.venti_base_def, 0),
                new Affix(AffixAttr.pCGR, StatData.venti_energy_recharge, 0),
                new Affix(AffixAttr.pCRD, StatData.venti_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.venti_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Xiangling = new Waifu(
            "香菱",
            ElementalType.Pyro,
            WeaponType.Polearm,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.xiangling_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.xiangling_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.xiangling_base_def, 0),
                new Affix(AffixAttr.ELM, StatData.xiangling_elemental_mastery, 0),
                new Affix(AffixAttr.pCRD, StatData.xiangling_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.xiangling_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Xiao = new Waifu(
            "魈",
            ElementalType.Anemo,
            WeaponType.Polearm,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.xiao_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.xiao_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.xiao_base_def, 0),
                new Affix(AffixAttr.pCRD, StatData.xiao_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.xiao_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Xingqiu = new Waifu(
            "行秋",
            ElementalType.Hydro,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.xingqiu_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.xingqiu_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.xingqiu_base_def, 0),
                new Affix(AffixAttr.pATK, StatData.xingqiu_atk, 0),
                new Affix(AffixAttr.pCRD, StatData.xingqiu_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.xingqiu_crit_rate, 0),
            } ,
            new List<Talent>()
        );
        
        public static Waifu Xinyan = new Waifu(
            "辛焱",
            ElementalType.Pyro,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.xinyan_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.xinyan_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.xinyan_base_def, 0),
                new Affix(AffixAttr.pATK, StatData.xinyan_atk, 0),
                new Affix(AffixAttr.pCRD, StatData.xinyan_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.xinyan_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Yanfei = new Waifu(
            "烟绯",
            ElementalType.Pyro,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.feiyan_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.feiyan_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.feiyan_base_def, 0),
                new Affix(AffixAttr.pPyro, StatData.feiyan_pyro_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, StatData.feiyan_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.feiyan_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Yoimiya = new Waifu(
            "宵宫",
            ElementalType.Pyro,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, StatData.yoimiya_base_hp, 0),
                new Affix(AffixAttr.ATK, StatData.yoimiya_base_atk, 0),
                new Affix(AffixAttr.DEF, StatData.yoimiya_base_def, 0),
                new Affix(AffixAttr.pCRD, StatData.yoimiya_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, StatData.yoimiya_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Zhongli = new Waifu(
            "钟离",
            ElementalType.Geo,
            WeaponType.Polearm,
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

//31=Traveler,Geo,31
        public static Waifu[] Waifus = new Waifu[] 
        {
            Albedo, Aloy, Amber, Barbara, Beidou, Bennett, Chongyun, Diluc, Diona,
            Eula, Fischl, Ganyu, Hutao, Jean, Kaedehara, Kaeya, Ayaka, Keqing, Klee,
            Lisa, Mona, Ningguang, Noelle, Qiqi, Raiden, Razor, Rosaraia, Kokomi,
            Sayu, Sucrose, Tartaglia, Traveler, Venti, Xiangling, Xiao, Xingqiu, Xinyan, Yanfei,
            Yoimiya, Zhongli
        };

        public static ElementalType[] ElementalTypes = new ElementalType[] 
        {
            ElementalType.None,
            ElementalType.Pyro,
            ElementalType.Hydro,
            ElementalType.Cryo,
            ElementalType.Dendro,
            ElementalType.Electro,
            ElementalType.Anemo,
            ElementalType.Geo,
        };

        public static string[] element_names = new string[] {"无", "火", "水", "冰", "草", "雷", "风", "岩" };

        public static string element2str(ElementalType type)
        {
            return element_names[((int)type)];
        }
    }

    public static class WeaponFactory
    {
        public static Weapon PrimordialJadeCutter = new Weapon(
            "磐岩结绿",
            WeaponType.Sword,
            new Affix(AffixAttr.ATK, StatData.primordial_jade_cutter_base_atk, 1),
            new Affix(AffixAttr.pCRI, StatData.primordial_jade_cutter_crit_rate, 1),
            new WeaponSpecialAbility(
                "护国的无垢之心",
                new List<SpecialCondAbility>()
                {
                    new SpecialCondAbility(SpecialCond.Always, AbilityType.Simple, new Affix(AffixAttr.pHP, new double[] { 0.2, 0.25, 0.3, 0.35, 0.4}, 0)),
                    new SpecialCondAbility(SpecialCond.Always, AbilityType.Bonus, new Affix(AffixAttr.ATK, new double[] { 0.012, 0.015, 0.018, 0.021, 0.024}, 0), WaifuStat.HP),
                },
                "生命值提升{0}。此外，基于装备该武器的角色生命值上限的{1}，获得攻击力加成。",
                0
            ),
            0, // image index
            0
        );

        public static Weapon AmosBow = new Weapon(
            "阿莫斯之弓",
            WeaponType.Bow,
            new Affix(AffixAttr.ATK, StatData.primordial_jade_cutter_base_atk, 1),
            new Affix(AffixAttr.pCRI, StatData.primordial_jade_cutter_crit_rate, 1),
            new WeaponSpecialAbility(
                "矢志不忘",
                new List<SpecialCondAbility>()
                {
                    new SpecialCondAbility(SpecialCond.OnNormalAttack|SpecialCond.OnChargedAttack, AbilityType.Simple, new Affix(AffixAttr.pATK, new double[] { 0.12, 0.15, 0.18, 0.21, 0.24}, 0)),
                    new SpecialCondAbility(SpecialCond.TimeDelay, AbilityType.Bonus, new Affix(AffixAttr.pNormalDMG, new double[] { 0.08, 0.10, 0.12, 0.14, 0.16}, 0), WaifuStat.TimeAfter),
                    new SpecialCondAbility(SpecialCond.TimeDelay, AbilityType.Bonus, new Affix(AffixAttr.pChargedDMG, new double[] { 0.08, 0.10, 0.12, 0.14, 0.16}, 0), WaifuStat.TimeAfter),
                },
                "普通攻击和重击造成的伤害提升{0}。箭矢发射后每经过0.1秒，伤害还会提升{1}。至多提升5次。",
                0
            ),
            1, // image index
            0
        );

        public static Weapon[] Weapons = new Weapon[]
        {
            AmosBow,
            PrimordialJadeCutter,
        };
    }

    public static class EnemyFactory
    {
        public static Enemy Hilichurl = new Enemy("丘丘人", 1, 500, new double[] { 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1 });
        public static Enemy[] Enemies = new Enemy[]
        {
            Hilichurl,
        };

        public static string[] reaction_names = new string[] {"无", "火水蒸发", "水火蒸发", "火冰融化", "冰火融化", "超导", "扩散", "感电", "碎冰", "超载"};
        public static string reaction2str(ElementalReactions reaction)
        {
            return reaction_names[((int)reaction)];
        }
    }
}
