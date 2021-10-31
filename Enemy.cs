using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    public class Enemy
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public double DEF { get; private set; }
        public double[] Resistances { get; private set; }
        public ElementalType Element { get; private set; }
        public string Description
        { 
            get
            {
                return string.Format("防御: {0}\r\n物理: {1}\r\n火: {2}\r\n水: {3}\r\n冰: {4}\r\n草: {5}\r\n雷: {6}\r\n风: {7}\r\n岩: {8}",
                    DEF,
                    Resistances[0].ToString("0.0%"),
                    Resistances[1].ToString("0.0%"),
                    Resistances[2].ToString("0.0%"),
                    Resistances[3].ToString("0.0%"),
                    Resistances[4].ToString("0.0%"),
                    Resistances[5].ToString("0.0%"),
                    Resistances[6].ToString("0.0%"),
                    Resistances[7].ToString("0.0%")
                );
            }
        }
        
        public Enemy(string name, int lv, double def, double[] res)
        {
            this.Name = name;
            this.Level = lv;
            this.DEF = def;
            this.Resistances = res;
            this.Element = ElementalType.None;
        }

        public void SetLevel(int lv)
        {
            this.Level = lv < 1 ? 1 : (lv > 100 ? 100 : lv);
        }

        public void SetElement(ElementalType type)
        {
            this.Element = type;
        }
    }
}
