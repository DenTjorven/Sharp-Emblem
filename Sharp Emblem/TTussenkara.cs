using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TTussenkara
    {
        public int KarAid { get; set; }
        public int CharId { get; set; }
        public int ASkillId { get; set; }

        public virtual TAskill? ASkill { get; set; }
        public virtual TKarakter? Char { get; set; }
    }
}
