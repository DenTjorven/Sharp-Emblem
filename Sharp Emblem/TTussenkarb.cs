using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TTussenkarb
    {
        public int KarBid { get; set; }
        public int CharId { get; set; }
        public int BSkillId { get; set; }

        public virtual TBskill? BSkill { get; set; }
        public virtual TKarakter? Char { get; set; }
    }
}
