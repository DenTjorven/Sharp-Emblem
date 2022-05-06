using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TSpeciaal
    {
        public TSpeciaal()
        {
            TTussenkarspecs = new HashSet<TTussenkarspec>();
        }

        public int SpecialId { get; set; }
        public string DNaam { get; set; }
        public int DCooldown { get; set; }
        public int DAtkInc { get; set; }
        public int DDefIng { get; set; }
        public int DProOfDef { get; set; }
        public int DProOfRes { get; set; }
        public int DProOfMissHp { get; set; }
        public int DDmgReduc { get; set; }
        public int DDmgIncre { get; set; }
        public int DHealForDmg { get; set; }

        public virtual ICollection<TTussenkarspec> TTussenkarspecs { get; set; }
    }
}
