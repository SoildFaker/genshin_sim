using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    class Artifact
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
        public string Name { get; private set; }
        public Affix MainAffix { get; private set; }
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

        public Artifact()
        {
            this.Name = "test relic";
            this.MainAffix = new Affix(AffixAttr.HP, 717);
            this.MinorAffixes = new List<Affix>();
            List<AffixAttr> lst = new List<AffixAttr>();
            lst.AddRange(AffixFactory.attr_arr);
            lst.Remove(AffixAttr.HP);
            
            for (int i = 0; i < 4; i++)
            {
                int code = AffixFactory.rand.Next(lst.Count);
                Affix line = new Affix(lst[code]);
                this.MinorAffixes.Add(line);
                this.InitSentence.Add(line);
                lst.RemoveAt(code);
            }
        }

        public void LevelUp()
        {
            if (this.Level < 20)
            {
                this.level++;
                this.MainAffix.Value += 213.8421;
                if (this.Level % 4 == 0)
                {
                    int index = AffixFactory.rand.Next(this.InitSentence.Count);
                    this.MinorAffixes.Add(new Affix(InitSentence[index].Attribute));
                    //this.MinorAffixes[index].Value += AffixFactory.pick(this.MinorAffixes[index].Attribute);
                }
            }
        }
    }
}
