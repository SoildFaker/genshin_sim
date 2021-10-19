using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    public enum SentenceAttr
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
    }
    public static class SentenceFactory
    {
        public static Sentence HP_209 = new Sentence(SentenceAttr.HP, 209);
        public static Sentence HP_239 = new Sentence(SentenceAttr.HP, 239);
        public static Sentence HP_269 = new Sentence(SentenceAttr.HP, 269);
        public static Sentence HP_299 = new Sentence(SentenceAttr.HP, 299);

        public static Sentence ATK_14 = new Sentence(SentenceAttr.ATK, 14);
        public static Sentence ATK_16 = new Sentence(SentenceAttr.ATK, 16);
        public static Sentence ATK_18 = new Sentence(SentenceAttr.ATK, 18);
        public static Sentence ATK_19 = new Sentence(SentenceAttr.ATK, 19);

        public static Sentence DEF_16 = new Sentence(SentenceAttr.DEF, 16);
        public static Sentence DEF_19 = new Sentence(SentenceAttr.DEF, 19);
        public static Sentence DEF_21 = new Sentence(SentenceAttr.DEF, 21);
        public static Sentence DEF_23 = new Sentence(SentenceAttr.DEF, 23);

        public static Sentence ELM_16 = new Sentence(SentenceAttr.ELM, 16);
        public static Sentence ELM_19 = new Sentence(SentenceAttr.ELM, 19);
        public static Sentence ELM_21 = new Sentence(SentenceAttr.ELM, 21);
        public static Sentence ELM_23 = new Sentence(SentenceAttr.ELM, 23);

        public static Sentence CGR_4p5 = new Sentence(SentenceAttr.pCGR, 4.5);
        public static Sentence CGR_5p2 = new Sentence(SentenceAttr.pCGR, 5.2);
        public static Sentence CGR_5p8 = new Sentence(SentenceAttr.pCGR, 5.8);
        public static Sentence CGR_6p5 = new Sentence(SentenceAttr.pCGR, 6.5);

        public static Sentence DEF_5p1 = new Sentence(SentenceAttr.pDEF, 5.1);
        public static Sentence DEF_5p8 = new Sentence(SentenceAttr.pDEF, 5.8);
        public static Sentence DEF_6p6 = new Sentence(SentenceAttr.pDEF, 6.6);
        public static Sentence DEF_7p3 = new Sentence(SentenceAttr.pDEF, 7.3);

        public static Sentence HP_4p1 = new Sentence(SentenceAttr.pHP, 4.1);
        public static Sentence HP_4p7 = new Sentence(SentenceAttr.pHP, 4.7);
        public static Sentence HP_5p3 = new Sentence(SentenceAttr.pHP, 5.3);
        public static Sentence HP_5p8 = new Sentence(SentenceAttr.pHP, 5.8);

        public static Sentence ATK_4p1 = new Sentence(SentenceAttr.pATK, 4.1);
        public static Sentence ATK_4p7 = new Sentence(SentenceAttr.pATK, 4.7);
        public static Sentence ATK_5p3 = new Sentence(SentenceAttr.pATK, 5.3);
        public static Sentence ATK_5p8 = new Sentence(SentenceAttr.pATK, 5.8);

        public static Sentence CRI_2p7 = new Sentence(SentenceAttr.pCRI, 2.7);
        public static Sentence CRI_3p1 = new Sentence(SentenceAttr.pCRI, 3.1);
        public static Sentence CRI_3p5 = new Sentence(SentenceAttr.pCRI, 3.5);
        public static Sentence CRI_3p9 = new Sentence(SentenceAttr.pCRI, 3.9);

        public static Sentence CRD_5p4 = new Sentence(SentenceAttr.pCRD, 5.4);
        public static Sentence CRD_6p2 = new Sentence(SentenceAttr.pCRD, 6.2);
        public static Sentence CRD_7p0 = new Sentence(SentenceAttr.pCRD, 7.0);
        public static Sentence CRD_7p8 = new Sentence(SentenceAttr.pCRD, 7.8);

        public static Sentence[] sub_sentence_arr = new Sentence[40] 
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

        public static SentenceAttr[] attr_arr = new SentenceAttr[]
        {
            SentenceAttr.HP,
            SentenceAttr.ATK,
            SentenceAttr.DEF,
            SentenceAttr.ELM,
            SentenceAttr.pHP,
            SentenceAttr.pATK,
            SentenceAttr.pDEF,
            SentenceAttr.pCGR,
            SentenceAttr.pCRI,
            SentenceAttr.pCRD,
        };

        public static Random rand = new Random();
        public static Sentence pick()
        {
            return sub_sentence_arr[rand.Next(0, 40)];
        }

        public static double pick(SentenceAttr attr)
        {
            switch (attr)
            {
                case SentenceAttr.HP:
                    return new double[4]{209, 239, 269, 299}[SentenceFactory.rand.Next(0,4)];
                case SentenceAttr.pHP:
                    return new double[4]{4.1, 4.7, 5.3, 5.8}[SentenceFactory.rand.Next(0,4)];
                case SentenceAttr.DEF:
                    return new double[4]{16, 19, 21, 23}[SentenceFactory.rand.Next(0,4)];
                case SentenceAttr.pDEF:
                    return new double[4]{5.1, 5.8, 6.6, 7.3}[SentenceFactory.rand.Next(0,4)];
                case SentenceAttr.ATK:
                    return new double[4]{14, 16, 18, 19}[SentenceFactory.rand.Next(0,4)];
                case SentenceAttr.pATK:
                    return new double[4]{4.1, 4.7, 5.3, 5.8}[SentenceFactory.rand.Next(0,4)];
                case SentenceAttr.pCGR:
                    return new double[4]{4.5, 5.2, 5.8, 6.5}[SentenceFactory.rand.Next(0,4)];
                case SentenceAttr.pCRD:
                    return new double[4]{5.4, 6.2, 7.0, 7.8}[SentenceFactory.rand.Next(0,4)];
                case SentenceAttr.pCRI:
                    return new double[4]{2.7, 3.1, 3.5, 3.9}[SentenceFactory.rand.Next(0,4)];
                case SentenceAttr.ELM:
                    return new double[4]{16, 19, 21, 23}[SentenceFactory.rand.Next(0,4)];
            }
            return -1;
        }
        public static string attr2str(SentenceAttr attr)
        {
            switch (attr)
            {
                case SentenceAttr.HP: return "生命值";
                case SentenceAttr.ATK: return "攻击力";
                case SentenceAttr.DEF: return "防御力";
                case SentenceAttr.pHP: return "生命值";
                case SentenceAttr.pATK: return "攻击力";
                case SentenceAttr.pDEF: return "防御力";
                case SentenceAttr.ELM: return "元素精通";
                case SentenceAttr.pCGR: return "充能效率";
                case SentenceAttr.pCRI: return "暴击率";
                case SentenceAttr.pCRD: return "暴击伤害";
                default: return "？？？";
            }
        }
    }
    public class Sentence
    {
        public SentenceAttr Attribute { get; private set; }
        public double Value { get; set; }

        public string Description
        {
            get
            {
                return SentenceFactory.attr2str(Attribute) + " + " + Value.ToString() + (Attribute.ToString().StartsWith("p") ? "%" : "");
            }
        }

        public Sentence(SentenceAttr attr, double val)
        {
            this.Attribute = attr;
            this.Value = val;
        }
        public Sentence(SentenceAttr attr)
        {
            this.Attribute = attr;
            this.Value = SentenceFactory.pick(attr);
        }

    }
}
