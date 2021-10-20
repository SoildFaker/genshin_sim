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

    public static class ArtifactFactory
    {
        public static Random rand = new Random();

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

    public class Artifact
    {
        private int level = 1;
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
                else if (value < 1)
                {
                    this.level = 1;
                }
            }
        }
        public ArtifactType Type { get; private set; }
        public string Name { get; private set; }
        public Affix MainAffix { get; private set; }
        private double[] MainAffixValues;
        public List<Affix> MinorAffixes { get; private set; }
        private List<Affix> InitSentence = new List<Affix>();
        public string MainAffixString
        {
            get
            {
                return AffixFactory.attr2str(MainAffix.Attribute) + " + " + MainAffix.Value.ToString("0")
                    + (MainAffix.Attribute.ToString("").StartsWith("p") ? "%\r\n" : "\r\n");

            }
        }
        public string MinorAffixesString
        {
            get
            {
                string str = "";
                for (int i = 0; i < 4; i++)
                {
                    AffixAttr attr = InitSentence[i].Attribute;
                    str += AffixFactory.attr2str(attr) + " + " 
                        + MinorAffixes.Where(x => x.Attribute == attr).Sum(x => x.Value).ToString()
                        + (attr.ToString().StartsWith("p") ? "%" : "");
                    str += "\r\n";
                }
                return str;
            }
        }
        public string Description { get; private set; }

        public Artifact(Affix main, List<Affix> sub, int lv = 1)
        {
            this.MainAffix = main;
            this.MinorAffixes = sub;
            this.Level = lv;
        }

        public Artifact(ArtifactType type)
        {
            this.Type = type;
            SetMainAffix();
            this.MainAffix.Value = this.MainAffixValues[0];
            this.MinorAffixes = new List<Affix>();
            List<AffixAttr> lst = new List<AffixAttr>();
            lst.AddRange(AffixFactory.minor_affix_attr_arr);
            lst.Remove(this.MainAffix.Attribute);
            
            for (int i = 0; i < 4; i++)
            {
                int code = AffixFactory.rand.Next(lst.Count);
                Affix line = new Affix(lst[code]);
                this.MinorAffixes.Add(line);
                this.InitSentence.Add(line);
                lst.RemoveAt(code);
            }
        }

        private void SetMainAffix()
        {
            this.MainAffix = AffixFactory.pick_main_affixes(this.Type);
            switch (Type)
            {
                case ArtifactType.FlowerOfLife:
                    this.Name = "Flower of Life";
                    this.MainAffixValues = new double[20]{ 717, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4780};
                    break;
                case ArtifactType.PlumeOfDeath:
                    this.Name = "Plume of Death";
                    this.MainAffixValues = new double[20]{ 47, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 311};
                    break;
                case ArtifactType.SandsOfEon:
                    this.Name = "Sands of Eon";
                    switch (MainAffix.Attribute)
                    {
                        case AffixAttr.ELM:
                            this.MainAffixValues = new double[20]{ 28, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 186.5};
                            break;
                        case AffixAttr.pHP:
                            this.MainAffixValues = new double[20]{ 7.0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 46.6};
                            break;
                        case AffixAttr.pATK:
                            this.MainAffixValues = new double[20]{ 7.0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 46.6};
                            break;
                        case AffixAttr.pDEF:
                            this.MainAffixValues = new double[20]{ 8.7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 58.3};
                            break;
                        case AffixAttr.pCGR:
                            this.MainAffixValues = new double[20]{ 7.8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 51.8};
                            break;
                    }
                    break;
                case ArtifactType.GobletOfEonothem:
                    this.Name = "Goblet of Eonothem";
                    switch (MainAffix.Attribute)
                    {
                        case AffixAttr.ELM:
                            this.MainAffixValues = new double[20]{ 28, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 186.5};
                            break;
                        case AffixAttr.pHP:
                            this.MainAffixValues = new double[20]{ 7.0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 46.6};
                            break;
                        case AffixAttr.pATK:
                            this.MainAffixValues = new double[20]{ 7.0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 46.6};
                            break;
                        case AffixAttr.pDEF:
                            this.MainAffixValues = new double[20]{ 8.7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 58.3};
                            break;
                        case AffixAttr.pPhysical:
                            this.MainAffixValues = new double[20]{ 8.7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 58.3};
                            break;
                        case AffixAttr.pHydro:
                        case AffixAttr.pCryo:
                        case AffixAttr.pElectro:
                        case AffixAttr.pAnemo:
                        case AffixAttr.pGeo:
                            this.MainAffixValues = new double[20]{ 7.0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 46.6};
                            break;
                    }
                    break;
                case ArtifactType.CircletOfLogos:
                    this.Name = "Circle of Logos";
                    switch (MainAffix.Attribute)
                    {
                        case AffixAttr.ELM:
                            this.MainAffixValues = new double[20]{ 28, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 186.5};
                            break;
                        case AffixAttr.pHP:
                            this.MainAffixValues = new double[20]{ 7.0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 46.6};
                            break;
                        case AffixAttr.pATK:
                            this.MainAffixValues = new double[20]{ 7.0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 46.6};
                            break;
                        case AffixAttr.pDEF:
                            this.MainAffixValues = new double[20]{ 8.7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 58.3};
                            break;
                        case AffixAttr.pCGR:
                            break;
                        case AffixAttr.pCRI:
                            this.MainAffixValues = new double[20]{ 4.7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 31.1};
                            break;
                        case AffixAttr.pCRD:
                            this.MainAffixValues = new double[20]{ 9.3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 62.2};
                            break;
                        case AffixAttr.pHealing:
                            this.MainAffixValues = new double[20]{ 5.4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 35.9};
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
                this.MainAffix.Value = MainAffixValues[level - 1];
                if (this.Level % 4 == 0)
                {
                    int index = AffixFactory.rand.Next(this.InitSentence.Count);
                    this.MinorAffixes.Add(new Affix(InitSentence[index].Attribute));
                    //this.MinorAffixes[index].Value += AffixFactory.pick_minor_affixes(this.MinorAffixes[index].Attribute);
                }
            }
        }
    }
}
