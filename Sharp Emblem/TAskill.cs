using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TAskill
    {
        public TAskill()
        {
            TTussenkaras = new HashSet<TTussenkara>();
        }

        public int ASkillId { get; set; }
        public string DNaam { get; set; }

        public virtual ICollection<TTussenkara> TTussenkaras { get; set; }
    }
}
