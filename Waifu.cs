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

    class Waifu
    {
        public string Name { get; private set; }
    }
}
