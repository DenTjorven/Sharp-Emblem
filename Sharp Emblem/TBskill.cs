using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TBskill
    {
        public TBskill()
        {
            TTussenkarbs = new HashSet<TTussenkarb>();
        }

        public int BSkillId { get; set; }
        public string DNaam { get; set; } = null!;

        public virtual ICollection<TTussenkarb> TTussenkarbs { get; set; }
    }
}
