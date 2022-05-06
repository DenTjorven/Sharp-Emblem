using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TCskill
    {
        public TCskill()
        {
            TTussenkarcs = new HashSet<TTussenkarc>();
        }

        public int CSkillId { get; set; }
        public string DNaam { get; set; } = null!;

        public virtual ICollection<TTussenkarc> TTussenkarcs { get; set; }
    }
}
