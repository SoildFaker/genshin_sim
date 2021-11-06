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
            "伤害加成", "普通攻击加成", "蓄力重击加成", "下落攻击加成", "元素伤害加成", "元素战技伤害加成", "元素爆发伤害加成", 
            "超载伤害加成", "燃烧伤害加成", "超导伤害加成", "扩散伤害加成", "感电伤害加成", "碎冰伤害加成", "蒸发反应系数", "融化反应系数", "无效果"
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
            "两件套: 获得{0}冰元素伤害加成。\r\n" + 
            "四件套:	攻击处于冰元素影响状态下的敌人时，暴击率提高{1}；若敌人处于冰冻状态下，暴击率额外提高{2}。"
        );

        public static ArtifactSetEffect CrimsonWitchOfFlames = new ArtifactSetEffect(
            "炽烈的炎之魔女",
            ArtifactSetEffectType.CrimsonWitchOfFlames,
            new List<SpecialCondEffect>()
            {
                new SpecialCondEffect(SpecialCond.Always, 2, AbilityType.Simple, new Affix(AffixAttr.pPyro, 0.15)),
                new SpecialCondEffect(SpecialCond.Always, 4, AbilityType.Simple, new Affix(AffixAttr.pOverload, 0.40)),
                new SpecialCondEffect(SpecialCond.Always, 4, AbilityType.Simple, new Affix(AffixAttr.pBurning, 0.40)),
                new SpecialCondEffect(SpecialCond.Always, 4, AbilityType.Simple, new Affix(AffixAttr.pVaporize, 0.15)),
                new SpecialCondEffect(SpecialCond.Always, 4, AbilityType.Simple, new Affix(AffixAttr.pMelt, 0.15))
            },
            "两件套: 获得{0}火元素伤害加成。\r\n" + 
            "四件套:	超载、燃烧反应造成的伤害提升{1}，蒸发、融化反应的加成系数提高{3}。施放元素战技后的10秒内，二件套的效果提高50%，该效果最多叠加3次。"
        );

        public static ArtifactSetEffect Thundersoother = new ArtifactSetEffect(
            "平息鸣雷的尊者",
            ArtifactSetEffectType.Thundersoother,
            new List<SpecialCondEffect>()
            {
                new SpecialCondEffect(SpecialCond.Ignore, 2, AbilityType.Simple, new Affix(AffixAttr.pNoEffect, 0.4)),
                new SpecialCondEffect(SpecialCond.EnemyTakeElectroElement, 4, AbilityType.Simple, new Affix(AffixAttr.pDMG, 0.35)),
            },
            "两件套: 雷元素抗性提高{0}。\r\n" +
            "四件套: 对处于雷元素影响下的敌人造成的伤害提升{1}。"
        );

        public static ArtifactSetEffect ViridescentVenerer = new ArtifactSetEffect(
            "翠绿之影",
            ArtifactSetEffectType.ViridescentVenerer,
            new List<SpecialCondEffect>()
            {
                new SpecialCondEffect(SpecialCond.Always, 2, AbilityType.Simple, new Affix(AffixAttr.pAnemo, 0.15)),
                new SpecialCondEffect(SpecialCond.Always, 4, AbilityType.Simple, new Affix(AffixAttr.pSwirl, 0.6)),
            },
            "两件套: 获得{0}风元素伤害加成。\r\n" +
            "四件套: 扩散反应造成的伤害提升{1}，根据扩散的元素类型，降低受到影响的敌人40%的对应元素抗性，持续10秒。"
        );

        public static ArtifactSetEffect HeartOfDepth = new ArtifactSetEffect(
            "沉沦之心",
            ArtifactSetEffectType.HeartOfDepth,
            new List<SpecialCondEffect>()
            {
                new SpecialCondEffect(SpecialCond.Always, 2, AbilityType.Simple, new Affix(AffixAttr.pHydro, 0.15)),
                new SpecialCondEffect(SpecialCond.TimeDelay, 4, AbilityType.Simple, new Affix(AffixAttr.pNormalDMG, 0.30)),
                new SpecialCondEffect(SpecialCond.TimeDelay, 4, AbilityType.Simple, new Affix(AffixAttr.pChargedDMG, 0.30)),
            },
            "两件套: 获得{0}水元素伤害加成。\r\n" +
            "四件套: 施放元素战技后的15秒内，普通攻击与重击造成的伤害提高{1}。"
        );

        public static ArtifactSetEffect ThunderingFury = new ArtifactSetEffect(
            "如雷的盛怒",
            ArtifactSetEffectType.ThunderingFury,
            new List<SpecialCondEffect>()
            {
                new SpecialCondEffect(SpecialCond.Always, 2, AbilityType.Simple, new Affix(AffixAttr.pElectro, 0.15)),
                new SpecialCondEffect(SpecialCond.Always, 4, AbilityType.Simple, new Affix(AffixAttr.pSuperconduct, 0.40)),
                new SpecialCondEffect(SpecialCond.Always, 4, AbilityType.Simple, new Affix(AffixAttr.pElectorCharged, 0.40)),
                new SpecialCondEffect(SpecialCond.Always, 4, AbilityType.Simple, new Affix(AffixAttr.pOverload, 0.40)),
            },
            "两件套: 获得{0}雷元素伤害加成。\r\n" +
            "四件套: 超载、感电、超导反应造成的伤害提升{1}。触发这些元素反应时，元素战技冷却时间减少1秒。该效果每0.8秒最多触发一次。"
        );
        
        public static ArtifactSetEffect[] SetEffects = new ArtifactSetEffect[]
        {
            UnknowSetEffect,
            GladiatorsFinale,
            BlizzardStrayer,
            CrimsonWitchOfFlames,
            Thundersoother,
            ViridescentVenerer,
            HeartOfDepth,
            ThunderingFury,
        };

        public static string[,] set_effect_names = new string[,] {
            { "未知的生之花", "未知的死之羽", "未知的时之沙", "未知的空之杯", "未知的理之冠" },
            { "角斗士的留恋", "角斗士的归宿", "角斗士的希冀", "角斗士的酣醉", "角斗士的凯旋" },
            { "历经风雪的思念", "摧冰而行的执望", "冰雪故园的终期", "遍结寒霜的傲骨", "破冰踏雪的回音" },
            { "魔女的炎之花", "魔女的燃之羽", "魔女破灭之时", "魔女的心之火", "焦灼的魔女帽" },
            { "平雷之心", "平雷之羽", "平雷之刻", "平雷之器", "平雷之冠" },
            { "野花记忆的绿野", "猎人青翠的箭羽", "翠绿猎人的笃定", "翠绿猎人的容器", "翠绿的猎人之冠" },
            { "饰金胸花", "追忆之风", "坚铜罗盘", "沉波之盏", "酒渍船帽" },
            { "雷鸟的怜悯", "雷灾的孑遗", "雷霆的时计", "降雷的凶兆", "唤雷的头冠" },
        }; 

        public static string get_artifact_name(ArtifactType artifact_type, ArtifactSetEffectType set_type)
        {
            return set_effect_names[((int)set_type), ((int)artifact_type)];
        }

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
                new Affix(AffixAttr.HP, WaifuData.albedo_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.albedo_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.albedo_base_def, 0),
                new Affix(AffixAttr.pGeo, WaifuData.albedo_geo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.albedo_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.albedo_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Amber = new Waifu(
            "安柏",
            ElementalType.Pyro,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.amber_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.amber_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.amber_base_def, 0),
                new Affix(AffixAttr.pATK, WaifuData.amber_atk, 0),
                new Affix(AffixAttr.pCRD, WaifuData.amber_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.amber_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Keqing = new Waifu(
            "刻晴",
            ElementalType.Electro,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.keqing_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.keqing_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.keqing_base_def, 0),
                new Affix(AffixAttr.pCRD, WaifuData.keqing_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.keqing_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Ayaka = new Waifu(
            "神里绫华",
            ElementalType.Cryo,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.ayaka_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.ayaka_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.ayaka_base_def, 0),
                new Affix(AffixAttr.pCRD, WaifuData.ayaka_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.ayaka_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Aloy = new Waifu(
            "埃洛伊",
            ElementalType.Cryo,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.aloy_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.aloy_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.aloy_base_def, 0),
                new Affix(AffixAttr.pCryo, WaifuData.aloy_cryo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.aloy_cryo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRI, WaifuData.albedo_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Barbara = new Waifu(
            "芭芭拉",
            ElementalType.Hydro,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.barbara_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.barbara_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.barbara_base_def, 0),
                new Affix(AffixAttr.pHP, WaifuData.barbara_hp, 0),
                new Affix(AffixAttr.pCRD, WaifuData.barbara_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.barbara_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Beidou = new Waifu(
            "北斗",
            ElementalType.Electro,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.beidou_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.beidou_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.beidou_base_def, 0),
                new Affix(AffixAttr.pElectro, WaifuData.beidou_electro_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.beidou_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.beidou_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Bennett = new Waifu(
            "班尼特",
            ElementalType.Pyro,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.benne_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.benne_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.benne_base_def, 0),
                new Affix(AffixAttr.pCGR, WaifuData.benne_energy_recharge, 0),
                new Affix(AffixAttr.pCRD, WaifuData.benne_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.benne_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Chongyun = new Waifu(
            "重云",
            ElementalType.Cryo,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.chongyun_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.chongyun_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.chongyun_base_def, 0),
                new Affix(AffixAttr.pATK, WaifuData.chongyun_atk, 0),
                new Affix(AffixAttr.pCRD, WaifuData.chongyun_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.chongyun_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Diluc = new Waifu(
            "迪卢克",
            ElementalType.Pyro,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.diluc_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.diluc_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.diluc_base_def, 0),
                new Affix(AffixAttr.pCRD, WaifuData.diluc_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.diluc_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Diona = new Waifu(
            "迪奥娜",
            ElementalType.Cryo,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.diona_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.diona_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.diona_base_def, 0),
                new Affix(AffixAttr.pPyro, WaifuData.diona_cryo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.diona_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.diona_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Eula = new Waifu(
            "尤拉",
            ElementalType.Cryo,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.eula_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.eula_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.eula_base_def, 0),
                new Affix(AffixAttr.pCRD, WaifuData.eula_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.eula_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Fischl = new Waifu(
            "菲谢尔",
            ElementalType.Electro,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.fisc_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.fisc_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.fisc_base_def, 0),
                new Affix(AffixAttr.pATK, WaifuData.fisc_atk, 0),
                new Affix(AffixAttr.pCRD, WaifuData.fisc_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.fisc_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Ganyu = new Waifu(
            "甘雨",
            ElementalType.Cryo,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.ganyu_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.ganyu_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.ganyu_base_def, 0),
                new Affix(AffixAttr.pCRD, WaifuData.ganyu_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.ganyu_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Hutao = new Waifu(
            "胡桃",
            ElementalType.Pyro,
            WeaponType.Polearm,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.hutao_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.hutao_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.hutao_base_def, 0),
                new Affix(AffixAttr.pCRD, WaifuData.hutao_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.hutao_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Jean = new Waifu(
            "琴",
            ElementalType.Anemo,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.jean_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.jean_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.jean_base_def, 0),
                new Affix(AffixAttr.pHealing, WaifuData.jean_healing_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.jean_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.jean_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Kaedehara = new Waifu(
            "枫原万叶",
            ElementalType.Anemo,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.kazuha_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.kazuha_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.kazuha_base_def, 0),
                new Affix(AffixAttr.ELM, WaifuData.kazuha_elemental_mastery, 0),
                new Affix(AffixAttr.pCRD, WaifuData.kazuha_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.kazuha_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Kaeya = new Waifu(
            "凯亚",
            ElementalType.Cryo,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.kaeya_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.kaeya_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.kaeya_base_def, 0),
                new Affix(AffixAttr.pCGR, WaifuData.kaeya_energy_recharge, 0),
                new Affix(AffixAttr.pCRD, WaifuData.kaeya_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.kaeya_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Klee = new Waifu(
            "可莉",
            ElementalType.Pyro,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.klee_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.klee_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.klee_base_def, 0),
                new Affix(AffixAttr.pPyro, WaifuData.klee_pyro_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.klee_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.klee_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Lisa = new Waifu(
            "丽莎",
            ElementalType.Electro,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.lisa_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.lisa_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.lisa_base_def, 0),
                new Affix(AffixAttr.ELM, WaifuData.lisa_elemental_mastery, 0),
                new Affix(AffixAttr.pCRD, WaifuData.lisa_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.lisa_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Mona = new Waifu(
            "莫娜",
            ElementalType.Hydro,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.mona_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.mona_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.mona_base_def, 0),
                new Affix(AffixAttr.pCGR, WaifuData.mona_energy_recharge, 0),
                new Affix(AffixAttr.pCRD, WaifuData.mona_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.mona_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Ningguang = new Waifu(
            "凝光",
            ElementalType.Geo,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.ningguang_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.ningguang_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.ningguang_base_def, 0),
                new Affix(AffixAttr.pGeo, WaifuData.ningguang_geo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.ningguang_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.ningguang_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Noelle = new Waifu(
            "诺艾尔",
            ElementalType.Geo,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.noelle_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.noelle_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.noelle_base_def, 0),
                new Affix(AffixAttr.pDEF, WaifuData.noelle_def, 0),
                new Affix(AffixAttr.pCRD, WaifuData.noelle_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.noelle_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Qiqi = new Waifu(
            "七七",
            ElementalType.Cryo,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.qiqi_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.qiqi_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.qiqi_base_def, 0),
                new Affix(AffixAttr.pHealing, WaifuData.qiqi_healing_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.qiqi_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.qiqi_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Raiden = new Waifu(
            "雷电将军",
            ElementalType.Electro,
            WeaponType.Polearm,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.shougun_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.shougun_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.shougun_base_def, 0),
                new Affix(AffixAttr.pCGR, WaifuData.shougun_energy_recharge, 0),
                new Affix(AffixAttr.pCRD, WaifuData.shougun_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.shougun_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Razor = new Waifu(
            "雷泽",
            ElementalType.Electro,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.razor_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.razor_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.razor_base_def, 0),
                new Affix(AffixAttr.pPhysical, WaifuData.razor_physical_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.razor_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.razor_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Rosaraia = new Waifu(
            "罗萨莉亚",
            ElementalType.Cryo,
            WeaponType.Polearm,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.rosaria_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.rosaria_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.rosaria_base_def, 0),
                new Affix(AffixAttr.pATK, WaifuData.rosaria_atk, 0),
                new Affix(AffixAttr.pCRD, WaifuData.rosaria_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.rosaria_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Kokomi = new Waifu(
            "珊瑚宫心海",
            ElementalType.Hydro,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.kokomi_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.kokomi_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.kokomi_base_def, 0),
                new Affix(AffixAttr.pHydro, WaifuData.kokomi_hydro_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.kokomi_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.kokomi_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Sayu = new Waifu(
            "早柚",
            ElementalType.Anemo,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.sayu_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.sayu_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.sayu_base_def, 0),
                new Affix(AffixAttr.ELM, WaifuData.sayu_elemental_mastery, 0),
                new Affix(AffixAttr.pCRD, WaifuData.sayu_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.sayu_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Sucrose = new Waifu(
            "砂糖",
            ElementalType.Anemo,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.sucrose_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.sucrose_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.sucrose_base_def, 0),
                new Affix(AffixAttr.pAnemo, WaifuData.sucrose_anemo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.sucrose_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.sucrose_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Tartaglia = new Waifu(
            "公子",
            ElementalType.Hydro,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.tartaglia_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.tartaglia_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.tartaglia_base_def, 0),
                new Affix(AffixAttr.pHydro, WaifuData.tartaglia_hydro_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.tartaglia_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.tartaglia_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Traveler = new Waifu(
            "旅行者",
            ElementalType.None,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.traveler_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.traveler_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.traveler_base_def, 0),
                new Affix(AffixAttr.pATK, WaifuData.traveler_atk, 0),
                new Affix(AffixAttr.pCRD, WaifuData.traveler_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.traveler_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Venti = new Waifu(
            "温蒂",
            ElementalType.Anemo,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.venti_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.venti_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.venti_base_def, 0),
                new Affix(AffixAttr.pCGR, WaifuData.venti_energy_recharge, 0),
                new Affix(AffixAttr.pCRD, WaifuData.venti_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.venti_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Xiangling = new Waifu(
            "香菱",
            ElementalType.Pyro,
            WeaponType.Polearm,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.xiangling_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.xiangling_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.xiangling_base_def, 0),
                new Affix(AffixAttr.ELM, WaifuData.xiangling_elemental_mastery, 0),
                new Affix(AffixAttr.pCRD, WaifuData.xiangling_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.xiangling_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Xiao = new Waifu(
            "魈",
            ElementalType.Anemo,
            WeaponType.Polearm,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.xiao_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.xiao_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.xiao_base_def, 0),
                new Affix(AffixAttr.pCRD, WaifuData.xiao_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.xiao_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Xingqiu = new Waifu(
            "行秋",
            ElementalType.Hydro,
            WeaponType.Sword,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.xingqiu_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.xingqiu_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.xingqiu_base_def, 0),
                new Affix(AffixAttr.pATK, WaifuData.xingqiu_atk, 0),
                new Affix(AffixAttr.pCRD, WaifuData.xingqiu_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.xingqiu_crit_rate, 0),
            } ,
            new List<Talent>()
        );
        
        public static Waifu Xinyan = new Waifu(
            "辛焱",
            ElementalType.Pyro,
            WeaponType.Claymore,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.xinyan_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.xinyan_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.xinyan_base_def, 0),
                new Affix(AffixAttr.pATK, WaifuData.xinyan_atk, 0),
                new Affix(AffixAttr.pCRD, WaifuData.xinyan_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.xinyan_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Yanfei = new Waifu(
            "烟绯",
            ElementalType.Pyro,
            WeaponType.Catalyst,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.feiyan_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.feiyan_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.feiyan_base_def, 0),
                new Affix(AffixAttr.pPyro, WaifuData.feiyan_pyro_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.feiyan_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.feiyan_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Yoimiya = new Waifu(
            "宵宫",
            ElementalType.Pyro,
            WeaponType.Bow,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.yoimiya_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.yoimiya_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.yoimiya_base_def, 0),
                new Affix(AffixAttr.pCRD, WaifuData.yoimiya_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.yoimiya_crit_rate, 0),
            } ,
            new List<Talent>()
        );

        public static Waifu Zhongli = new Waifu(
            "钟离",
            ElementalType.Geo,
            WeaponType.Polearm,
            new List<Affix>()
            {
                new Affix(AffixAttr.HP, WaifuData.zhongli_base_hp, 0),
                new Affix(AffixAttr.ATK, WaifuData.zhongli_base_atk, 0),
                new Affix(AffixAttr.DEF, WaifuData.zhongli_base_def, 0),
                new Affix(AffixAttr.pGeo, WaifuData.zhongli_geo_dmg_bonus, 0),
                new Affix(AffixAttr.pCRD, WaifuData.zhongli_crit_dmg, 0),
                new Affix(AffixAttr.pCRI, WaifuData.zhongli_crit_rate, 0),
            } ,
            new List<Talent>()
        );

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
            ElementalType.Cryo,
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
            new Affix(AffixAttr.ATK, WeaponData.primordial_jade_cutter_base_atk, 0),
            new Affix(AffixAttr.pCRI, WeaponData.primordial_jade_cutter_crit_rate, 0),
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
            new Affix(AffixAttr.ATK, WeaponData.amos_bow_base_atk, 0),
            new Affix(AffixAttr.pCRI, WeaponData.amos_bow_atk, 0),
            new WeaponSpecialAbility(
                "矢志不忘",
                new List<SpecialCondAbility>()
                {
                    new SpecialCondAbility(SpecialCond.OnNormalAttack|SpecialCond.OnChargedAttack, AbilityType.Bonus, new Affix(AffixAttr.pDMG, new double[] { 0.12, 0.15, 0.18, 0.21, 0.24}, 0)),
                    new SpecialCondAbility(SpecialCond.TimeDelay, AbilityType.Bonus, new Affix(AffixAttr.pNormalDMG, new double[] { 0.08, 0.10, 0.12, 0.14, 0.16}, 0), WaifuStat.TimeAfter),
                    new SpecialCondAbility(SpecialCond.TimeDelay, AbilityType.Bonus, new Affix(AffixAttr.pChargedDMG, new double[] { 0.08, 0.10, 0.12, 0.14, 0.16}, 0), WaifuStat.TimeAfter),
                },
                "普通攻击和重击造成的伤害提升{0}。箭矢发射后每经过0.1秒，伤害还会提升{1}。至多提升5次。",
                0
            ),
            1, // image index
            0
        );

        public static Weapon SerpentSpine = new Weapon(
            "螭骨剑",
            WeaponType.Claymore,
            new Affix(AffixAttr.ATK, WeaponData.serpent_spine_base_atk, 0),
            new Affix(AffixAttr.pCRI, WeaponData.serpent_spine_crit_rate, 0),
            new WeaponSpecialAbility(
                "破浪",
                new List<SpecialCondAbility>()
                {
                    new SpecialCondAbility(SpecialCond.Always, AbilityType.Bonus, new Affix(AffixAttr.pDMG, new double[] { 0.06, 0.07, 0.08, 0.09, 0.10}, 0)),
                    new SpecialCondAbility(SpecialCond.TakingDMG, AbilityType.Simple, new Affix(AffixAttr.pNoEffect, new double[] { 0.03, 0.027, 0.024, 0.022, 0.02}, 0)),
                },
                "角色在场上时，每4秒提升{0}造成的伤害，{1}受到的伤害。该效果最多叠加5层，不随角色退场重置，受到伤害后会减少1层效果。",
                0
            ),
            2, // image index
            0
        );

        public static Weapon LostPrayerToTheSacredWinds = new Weapon(
            "四风原典",
            WeaponType.Catalyst,
            new Affix(AffixAttr.ATK, WeaponData.lost_prayer_to_the_sacred_winds_base_atk, 0),
            new Affix(AffixAttr.pCRI, WeaponData.lost_prayer_to_the_sacred_winds_crit_rate, 0),
            new WeaponSpecialAbility(
                "无边际的眷顾",
                new List<SpecialCondAbility>()
                {
                    new SpecialCondAbility(SpecialCond.Always, AbilityType.Bonus, new Affix(AffixAttr.pElementalDMG, new double[] { 0.08, 0.1, 0.12, 0.14, 0.16}, 0)),
                },
                "移动速度提高10%；在场上每4秒获得{0}元素伤害加成。该效果最多叠加4层，角色倒下或离场后清空。",
                0
            ),
            3, // image index
            0
        );

        public static Weapon DragonsBane = new Weapon(
            "匣里灭辰",
            WeaponType.Polearm,
            new Affix(AffixAttr.ATK, WeaponData.dragons_bane_base_atk, 0),
            new Affix(AffixAttr.ELM, WeaponData.dragons_bane_elemental_mastery, 0),
            new WeaponSpecialAbility(
                "踏火止水",
                new List<SpecialCondAbility>()
                {
                    new SpecialCondAbility(SpecialCond.EnemyTakeHydroElement|SpecialCond.EnemyTakePyroElement, AbilityType.Bonus, new Affix(AffixAttr.pDMG, new double[] { 0.2, 0.24, 0.28, 0.32, 0.36 }, 0)),
                },
                "对于处于水元素或火元素影响下的敌人，造成的伤害提高{0}。",
                0
            ),
            4, // image index
            0
        );

        public static Weapon[] Weapons = new Weapon[]
        {
            AmosBow,
            PrimordialJadeCutter,
            SerpentSpine,
            LostPrayerToTheSacredWinds,
            DragonsBane,
        };

        public static string[] type_names = new string[] {"未知", "单手剑", "双手剑", "枪", "弓", "法器" };

        public static string type2str(WeaponType type)
        {
            return type_names[((int)type)];
        }
    }

    public static class EnemyFactory
    {
        public static Enemy Hilichurl = new Enemy("丘丘人", 1, 500, new double[] { 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1 });
        public static Enemy[] Enemies = new Enemy[]
        {
            Hilichurl,
        };

        public static string[] reaction_names = new string[] {"无", "火水蒸发", "水火蒸发", "火冰融化", "冰火融化", "超导", "扩散", "燃烧", "感电", "碎冰", "超载"};
        public static string reaction2str(ElementalReactions reaction)
        {
            return reaction_names[((int)reaction)];
        }
    }
}
