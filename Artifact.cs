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
                else if (value < 1)
                {
                    this.level = 0;
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
                    AffixAttr attr = InitSentence[i].Attribute;
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
                    this.MainAffixValues = new double[21]{ 717, 920, 1123, 1326, 1530, 1733, 1936, 2139, 2342, 2545, 2749, 2952, 3155, 3358, 3561, 3764, 3967, 4171, 4374, 4577, 4780 };
                    break;
                case ArtifactType.PlumeOfDeath:
                    this.Name = "Plume of Death";
                    this.MainAffixValues = new double[21]{ 47, 60, 73, 86, 100, 113, 126, 139, 152, 166, 179, 192, 205, 219, 232, 245, 258, 272, 285, 298, 311 };
                    break;
                case ArtifactType.SandsOfEon:
                    this.Name = "Sands of Eon";
                    switch (MainAffix.Attribute)
                    {
                        case AffixAttr.ELM:
                            this.MainAffixValues = new double[21]{ 28, 36, 44, 52, 60, 68, 76, 84, 91, 99, 107, 115, 123, 131, 139, 147, 155, 163, 171, 179, 187 };
                            break;
                        case AffixAttr.pHP:
                            this.MainAffixValues = new double[21]{ 0.07, 0.09, 0.11, 0.129, 0.149, 0.169, 0.189, 0.209, 0.228, 0.248, 0.268, 0.288, 0.308, 0.328, 0.347, 0.367, 0.387, 0.407, 0.427, 0.446, 0.466 };
                            break;
                        case AffixAttr.pATK:
                            this.MainAffixValues = new double[21]{ 0.07, 0.09, 0.11, 0.129, 0.149, 0.169, 0.189, 0.209, 0.228, 0.248, 0.268, 0.288, 0.308, 0.328, 0.347, 0.367, 0.387, 0.407, 0.427, 0.446, 0.466 };
                            break;
                        case AffixAttr.pDEF:
                            this.MainAffixValues = new double[21]{ 0.087, 0.112, 0.137, 0.162, 0.186, 0.211, 0.236, 0.261, 0.286, 0.31, 0.335, 0.36, 0.385, 0.409, 0.434, 0.459, 0.484, 0.508, 0.533, 0.558, 0.583 };
                            break;
                        case AffixAttr.pCGR:
                            this.MainAffixValues = new double[21]{ 0.078, 0.1, 0.122, 0.144, 0.166, 0.188, 0.21, 0.232, 0.254, 0.276, 0.298, 0.32, 0.342, 0.364, 0.386, 0.408, 0.43, 0.452, 0.474, 0.496, 0.518 };
                            break;
                    }
                    break;
                case ArtifactType.GobletOfEonothem:
                    this.Name = "Goblet of Eonothem";
                    switch (MainAffix.Attribute)
                    {
                        case AffixAttr.ELM:
                            this.MainAffixValues = new double[21]{ 28, 36, 44, 52, 60, 68, 76, 84, 91, 99, 107, 115, 123, 131, 139, 147, 155, 163, 171, 179, 187 };
                            break;
                        case AffixAttr.pHP:
                            this.MainAffixValues = new double[21]{ 0.07, 0.09, 0.11, 0.129, 0.149, 0.169, 0.189, 0.209, 0.228, 0.248, 0.268, 0.288, 0.308, 0.328, 0.347, 0.367, 0.387, 0.407, 0.427, 0.446, 0.466 };
                            break;
                        case AffixAttr.pATK:
                            this.MainAffixValues = new double[21]{ 0.07, 0.09, 0.11, 0.129, 0.149, 0.169, 0.189, 0.209, 0.228, 0.248, 0.268, 0.288, 0.308, 0.328, 0.347, 0.367, 0.387, 0.407, 0.427, 0.446, 0.466 };
                            break;
                        case AffixAttr.pDEF:
                            this.MainAffixValues = new double[21]{ 0.087, 0.112, 0.137, 0.162, 0.186, 0.211, 0.236, 0.261, 0.286, 0.31, 0.335, 0.36, 0.385, 0.409, 0.434, 0.459, 0.484, 0.508, 0.533, 0.558, 0.583 };
                            break;
                        case AffixAttr.pPhysical:
                            this.MainAffixValues = new double[21]{ 0.087, 0.112, 0.137, 0.162, 0.186, 0.211, 0.236, 0.261, 0.286, 0.31, 0.335, 0.36, 0.385, 0.409, 0.434, 0.459, 0.484, 0.508, 0.533, 0.558, 0.583 };
                            break;
                        case AffixAttr.pHydro:
                        case AffixAttr.pCryo:
                        case AffixAttr.pElectro:
                        case AffixAttr.pAnemo:
                        case AffixAttr.pGeo:
                            this.MainAffixValues = new double[21]{ 0.07, 0.09, 0.11, 0.129, 0.149, 0.169, 0.189, 0.209, 0.228, 0.248, 0.268, 0.288, 0.308, 0.328, 0.347, 0.367, 0.387, 0.407, 0.427, 0.446, 0.466 };
                            break;
                    }
                    break;
                case ArtifactType.CircletOfLogos:
                    this.Name = "Circle of Logos";
                    switch (MainAffix.Attribute)
                    {
                        case AffixAttr.ELM:
                            this.MainAffixValues = new double[21]{ 28, 36, 44, 52, 60, 68, 76, 84, 91, 99, 107, 115, 123, 131, 139, 147, 155, 163, 171, 179, 187 };
                            break;
                        case AffixAttr.pHP:
                            this.MainAffixValues = new double[21]{ 0.07, 0.09, 0.11, 0.129, 0.149, 0.169, 0.189, 0.209, 0.228, 0.248, 0.268, 0.288, 0.308, 0.328, 0.347, 0.367, 0.387, 0.407, 0.427, 0.446, 0.466 };
                            break;
                        case AffixAttr.pATK:
                            this.MainAffixValues = new double[21]{ 0.07, 0.09, 0.11, 0.129, 0.149, 0.169, 0.189, 0.209, 0.228, 0.248, 0.268, 0.288, 0.308, 0.328, 0.347, 0.367, 0.387, 0.407, 0.427, 0.446, 0.466 };
                            break;
                        case AffixAttr.pDEF:
                            this.MainAffixValues = new double[21]{ 0.087, 0.112, 0.137, 0.162, 0.186, 0.211, 0.236, 0.261, 0.286, 0.31, 0.335, 0.36, 0.385, 0.409, 0.434, 0.459, 0.484, 0.508, 0.533, 0.558, 0.583 };
                            break;
                        case AffixAttr.pCGR:
                            this.MainAffixValues = new double[21]{ 0.078, 0.1, 0.122, 0.144, 0.166, 0.188, 0.21, 0.232, 0.254, 0.276, 0.298, 0.32, 0.342, 0.364, 0.386, 0.408, 0.43, 0.452, 0.474, 0.496, 0.518 };
                            break;
                        case AffixAttr.pCRI:
                            this.MainAffixValues = new double[21]{ 0.047, 0.06, 0.073, 0.086, 0.099, 0.113, 0.126, 0.139, 0.152, 0.166, 0.179, 0.192, 0.205, 0.218, 0.232, 0.245, 0.258, 0.271, 0.284, 0.298, 0.311 };
                            break;
                        case AffixAttr.pCRD:
                            this.MainAffixValues = new double[21]{ 0.093, 0.12, 0.146, 0.173, 0.199, 0.225, 0.252, 0.278, 0.305, 0.331, 0.357, 0.384, 0.41, 0.437, 0.463, 0.49, 0.516, 0.542, 0.569, 0.595, 0.622 };
                            break;
                        case AffixAttr.pHealing:
                            this.MainAffixValues = new double[21]{ 0.054, 0.069, 0.084, 0.1, 0.115, 0.13, 0.145, 0.161, 0.176, 0.191, 0.206, 0.221, 0.237, 0.252, 0.267, 0.282, 0.298, 0.313, 0.328, 0.343, 0.359 };
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
                this.MainAffix.Value = MainAffixValues[level];
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
