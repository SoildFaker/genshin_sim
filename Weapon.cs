using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_sim
{
    public class Weapon
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Affix MainAffix { get; private set; }

        public Weapon(string name, Affix affix)
        {
            this.Name = name;
            this.MainAffix = affix;
        }
    }
}
