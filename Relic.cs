using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    class Relic
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
        public Sentence MainSentence { get; private set; }
        public List<Sentence> SubSentence { get; private set; }
        private List<Sentence> InitSentence = new List<Sentence>();
        public string Description
        {
            get
            {
                string str = "";
                for (int i = 0; i < 4; i++)
                {
                    SentenceAttr attr = InitSentence[i].Attribute;
                    str += SentenceFactory.attr2str(attr) + " + " 
                        + SubSentence.Where(x => x.Attribute == attr).Sum(x => x.Value).ToString()
                        + (attr.ToString().StartsWith("p") ? "%" : "");
                    str += "\r\n";
                }
                return str;
            }
        }

        public Relic(Sentence main, List<Sentence> sub, int lv = 1)
        {
            this.MainSentence = main;
            this.SubSentence = sub;
            this.Level = lv;
        }

        public Relic()
        {
            this.Name = "test relic";
            this.MainSentence = SentenceFactory.pick();
            this.SubSentence = new List<Sentence>();
            List<SentenceAttr> lst = new List<SentenceAttr>();
            lst.AddRange(SentenceFactory.attr_arr);
            
            for (int i = 0; i < 4; i++)
            {
                int code = SentenceFactory.rand.Next(lst.Count);
                Sentence line = new Sentence(lst[code]);
                this.SubSentence.Add(line);
                this.InitSentence.Add(line);
                lst.RemoveAt(code);
            }
        }

        public void LevelUp()
        {
            if (this.Level < 20)
            {
                this.level++;
                this.MainSentence.Value += 10;
                if (this.Level % 4 == 0)
                {
                    int index = SentenceFactory.rand.Next(this.InitSentence.Count);
                    this.SubSentence.Add(new Sentence(InitSentence[index].Attribute));
                    //this.SubSentence[index].Value += SentenceFactory.pick(this.SubSentence[index].Attribute);
                }
            }
        }
    }
}
