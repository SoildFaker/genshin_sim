using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    public enum ElementType
    {
        Pyro,       // 火
        Hydro,      // 水
        Cryo,       // 冰
        Dendro,     // 草
        Electro,    // 雷
        Anemo,      // 风
        Geo,        // 岩
    }

    public class Waifu
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public ElementType Vision { get; private set; }
        public List<Affix> BaseStat {  get; private set; }
        public List<Talent> Talents { get; private set; }
        public Artifact[] Artifacts = new Artifact[5];
        public Weapon Weapon { get; set; }

        public Waifu(string name, ElementType vision, List<Affix> stat, List<Talent> talents, int level = 1)
        {
            this.Name = name;
            this.Vision = vision;
            this.Talents = talents;
            this.BaseStat = stat;
            this.Level = level;
        }

        public void SetLevel(int level)
        {
            this.Level = level;
            foreach (var item in BaseStat)
            {
                item.SetLevel(level - 1);
            }
        }
    }

    public class Talent
    {
        public string Name { get; private set; }
        public List<double> Actions { get; private set; }

        public Talent(string name)
        {
            this.Name = name;
            this.Actions = new List<double>();
        }

        public Talent(string name, double[] actions)
        {
            this.Name = name;
            this.Actions = new List<double>();
            this.Actions.AddRange(actions);
        }
    }
}
