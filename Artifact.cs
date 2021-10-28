using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    public enum ArtifactType : int
    {
        FlowerOfLife,
        PlumeOfDeath,
        SandsOfEon,
        GobletOfEonothem,
        CircletOfLogos,
    }

    public class Artifact
    {
        private int level = 0;
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value > 20)
                {
                    this.level = 20;
                }
                else if (value < 0)
                {
                    this.level = 0;
                }
            }
        }
        public ArtifactType Type { get; private set; }
        public ArtifactSetEffect ArtifactSetEffect { get; private set; }
        public string Name {
            get 
            {
                if (this.ArtifactSetEffect == null)
                {
                    return "Unknow";
                }
                return ArtifactFactory.get_artifact_name(Type, this.ArtifactSetEffect.Type);
            }
        }
        public string NickName { get; set; }
        public Affix MainAffix { get; private set; }
        public List<Affix> MinorAffixes { get; private set; }
        private List<Affix> InitAffixes = new List<Affix>();
        public string MainAffixString
        {
            get
            {
                if (MainAffix.Attribute.ToString().StartsWith("p"))
                {
                    return AffixFactory.attr2str(MainAffix.Attribute) + " + " + MainAffix.Value.ToString("0.0%");
                }
                else
                {
                    return AffixFactory.attr2str(MainAffix.Attribute) + " + " + MainAffix.Value.ToString();
                }

            }
        }
        public string MinorAffixesString
        {
            get
            {
                string str = "";
                for (int i = 0; i < 4; i++)
                {
                    AffixAttr attr = InitAffixes[i].Attribute;
                    if (attr.ToString().StartsWith("p"))
                    {
                        str += AffixFactory.attr2str(attr) + " + "
                            + MinorAffixes.Where(x => x.Attribute == attr).Sum(x => x.Value).ToString("0.0%");
                    }
                    else
                    {
                        str += AffixFactory.attr2str(attr) + " + "
                            + MinorAffixes.Where(x => x.Attribute == attr).Sum(x => x.Value).ToString();
                    }
                    str += " \r\n";
                }
                return str;
            }
        }
        public string Description 
        {
            get
            {
                return this.MainAffixString + "\r\n" + this.MinorAffixesString;
            }
            
        }

        public Artifact(ArtifactType type, Affix main, List<Affix> sub, ArtifactSetEffect effect, int lv = 1)
        {
            this.Type = type;
            this.ArtifactSetEffect = effect;
            SetMainAffix(main);
            SetMinorAffix(sub);
            SetLevel(lv);
        }

        public Artifact(ArtifactType type)
        {
            this.Type = type;
            SetMainAffix();
            this.MinorAffixes = new List<Affix>();
            List<AffixAttr> lst = new List<AffixAttr>();
            lst.AddRange(AffixFactory.minor_affix_attr_arr);
            lst.Remove(this.MainAffix.Attribute);
            this.ArtifactSetEffect = ArtifactFactory.UnknowSetEffect;
            for (int i = 0; i < 4; i++)
            {
                int code = AffixFactory.rand.Next(lst.Count);
                Affix line = AffixFactory.pick_minor_affix(lst[code]); ;
                this.MinorAffixes.Add(line);
                this.InitAffixes.Add(line);
                lst.RemoveAt(code);
            }
        }

        public void SetArtifactSetEffect(ArtifactSetEffect effect)
        {
            this.ArtifactSetEffect = effect;
        }

        public void SetMainAffix(Affix affix)
        {
            this.MainAffix = affix;
            this.MainAffix.SetLevel(Level);
        }

        public void SetMinorAffix(List<Affix> affixes)
        {
            this.MinorAffixes = affixes;
            this.InitAffixes = affixes.Take(4).ToList();
        }

        public void SetLevel(int lv)
        {
            this.MainAffix.SetLevel(lv);
            this.level = lv;
        }

        private void SetMainAffix()
        {
            this.MainAffix = AffixFactory.pick_main_affixes(this.Type);
            switch (Type)
            {
                case ArtifactType.FlowerOfLife:
                    this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_hp);
                    break;
                case ArtifactType.PlumeOfDeath:
                    this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_atk);
                    break;
                case ArtifactType.SandsOfEon:
                    switch (MainAffix.Attribute)
                    {
                        case AffixAttr.ELM:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_elm);
                            break;
                        case AffixAttr.pHP:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_hp_pct);
                            break;
                        case AffixAttr.pATK:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_atk_pct);
                            break;
                        case AffixAttr.pDEF:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_def_pct);
                            break;
                        case AffixAttr.pCGR:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_cgr_pct);
                            break;
                    }
                    break;
                case ArtifactType.GobletOfEonothem:
                    switch (MainAffix.Attribute)
                    {
                        case AffixAttr.ELM:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_elm);
                            break;
                        case AffixAttr.pHP:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_hp_pct);
                            break;
                        case AffixAttr.pATK:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_atk_pct);
                            break;
                        case AffixAttr.pDEF:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_def_pct);
                            break;
                        case AffixAttr.pPhysical:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_physical);
                            break;
                        case AffixAttr.pPyro:
                        case AffixAttr.pDendro:
                        case AffixAttr.pHydro:
                        case AffixAttr.pCryo:
                        case AffixAttr.pElectro:
                        case AffixAttr.pAnemo:
                        case AffixAttr.pGeo:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_element);
                            break;
                    }
                    break;
                case ArtifactType.CircletOfLogos:
                    switch (MainAffix.Attribute)
                    {
                        case AffixAttr.ELM:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_elm);
                            break;
                        case AffixAttr.pHP:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_hp_pct);
                            break;
                        case AffixAttr.pATK:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_atk_pct);
                            break;
                        case AffixAttr.pDEF:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_def_pct);
                            break;
                        case AffixAttr.pCGR:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_cgr_pct);
                            break;
                        case AffixAttr.pCRI:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_cri_pct);
                            break;
                        case AffixAttr.pCRD:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_crd_pct);
                            break;
                        case AffixAttr.pHealing:
                            this.MainAffix.SetValueArray(ArtifactFactory.value_array_type_healing);
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        public void LevelUp()
        {
            if (this.Level < 20)
            {
                this.level++;
                this.MainAffix.LevelUp();
                if (this.Level % 4 == 0)
                {
                    int index = AffixFactory.rand.Next(this.InitAffixes.Count);
                    this.MinorAffixes.Add(AffixFactory.pick_minor_affix(InitAffixes[index].Attribute));
                    //this.MinorAffixes[index].Value += AffixFactory.pick_minor_affixes(this.MinorAffixes[index].Attribute);
                }
            }
        }
    }

    public enum ArtifactSetEffectType : int
    {
        Unknow,
        GladiatorsFinale,
        BlizzardStrayer,
    }
    public class SpecialCondEffect
    {
        public int ActiveNumber { get; private set; }
        public AbilityType Type { get; private set; }
        public SpecialCond SpecialCond { get; private set; }
        public WaifuStat BonusBase { get; private set; }
        public Affix Affix { get; private set; }

        public SpecialCondEffect(SpecialCond cond, int active_number, AbilityType type, Affix affix, WaifuStat bonus_base = WaifuStat.HP)
        {
            this.SpecialCond = cond;
            this.ActiveNumber = active_number;
            this.Type = type;
            this.Affix = affix;
            this.BonusBase = bonus_base;
        }
    }

    public class ArtifactSetEffect
    {
        public string Name { get; private set; }
        public ArtifactSetEffectType Type { get; private set; }
        public List<SpecialCondEffect> Effects { get; private set; }
        private string description;
        public string Description
        {
            get
            {
                return String.Format(description, Effects.Select(x => x.Affix.Value.ToString("0.0%")).ToArray());
            }
        }

        public ArtifactSetEffect(string name, ArtifactSetEffectType type, List<SpecialCondEffect> effects, string desc)
        {
            this.Name = name;
            this.Type = type;
            this.Effects = effects;
            this.description = desc;
        }
    }
}
