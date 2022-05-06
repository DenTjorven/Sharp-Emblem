using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TTussenkarc
    {
        public int KarCid { get; set; }
        public int CharId { get; set; }
        public int CSkillId { get; set; }

        public virtual TCskill? CSkill { get; set; }
        public virtual TKarakter? Char { get; set; }
    }
}
