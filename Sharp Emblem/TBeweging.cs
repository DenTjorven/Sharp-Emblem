using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TBeweging
    {
        public TBeweging()
        {
            TTussenkarmovs = new HashSet<TTussenkarmov>();
        }

        public int MovementId { get; set; }
        public string DNaam { get; set; }
        public int DMov { get; set; }
        public bool DFly { get; set; }
        public bool DCav { get; set; }

        public virtual ICollection<TTussenkarmov> TTussenkarmovs { get; set; }
    }
}
