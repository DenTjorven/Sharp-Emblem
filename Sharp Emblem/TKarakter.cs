using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TKarakter
    {
        public TKarakter()
        {
            TTussenkaras = new HashSet<TTussenkara>();
            TTussenkarbs = new HashSet<TTussenkarb>();
            TTussenkarcs = new HashSet<TTussenkarc>();
            TTussenkarmovs = new HashSet<TTussenkarmov>();
            TTussenkarspecs = new HashSet<TTussenkarspec>();
            TTussenkarwapens = new HashSet<TTussenkarwapen>();
        }

        public int CharId { get; set; }
        public string DNaam { get; set; }
        public int DHp { get; set; }
        public int DAtk { get; set; }
        public int DSpd { get; set; }
        public int DDef { get; set; }
        public int DRes { get; set; }

        public virtual ICollection<TTussenkara> TTussenkaras { get; set; }
        public virtual ICollection<TTussenkarb> TTussenkarbs { get; set; }
        public virtual ICollection<TTussenkarc> TTussenkarcs { get; set; }
        public virtual ICollection<TTussenkarmov> TTussenkarmovs { get; set; }
        public virtual ICollection<TTussenkarspec> TTussenkarspecs { get; set; }
        public virtual ICollection<TTussenkarwapen> TTussenkarwapens { get; set; }
    }
}
