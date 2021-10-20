using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    public enum WaifuAttr
    {
        HP,     // 生命
        ATK,    // 攻击
        DEF,    // 防御
        ELM,    // 元素精通
        CGR,    // 充能效率
        CRI,    // 暴击率
        CRD,    // 暴击伤害
    }

    public enum ElementType
    {
        Hydro,
        Cryo,
        Electro,
        Anemo,
        Geo,
    }

    public class Waifu
    {
        public string Name { get; private set; }
        public ElementType Vision { get; private set; }
        public List<Talent> Talents { get; private set; }
        public Artifact[] Artifacts = new Artifact[5];
        public int ImageIndex { get; private set; }
        public Weapon Weapon { get; set; }

        public Waifu(string name, ElementType vision, List<Talent> talents, int image_index = 0)
        {
            this.Name = name;
            this.Vision = vision;
            this.Talents = talents;
            this.ImageIndex = image_index;
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
