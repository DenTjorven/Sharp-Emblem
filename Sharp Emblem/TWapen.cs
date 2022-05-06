using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TWapen
    {
        public TWapen()
        {
            TTussenkarwapens = new HashSet<TTussenkarwapen>();
        }

        public int WeaponId { get; set; }
        public string DNaam { get; set; }
        public int DKracht { get; set; }
        public string DType { get; set; }
        public string DKleur { get; set; }
        public int DCooldownEffect { get; set; }
        public bool DDc { get; set; }
        public bool DGem { get; set; }
        public bool DDraEffect { get; set; }
        public bool DInfEffect { get; set; }
        public bool DColorEffect { get; set; }
        public bool DArmorEffect { get; set; }
        public bool DCavEffect { get; set; }
        public bool DFlyEffect { get; set; }
        public bool DBrave { get; set; }
        public bool DKiller { get; set; }
        public bool DBladetome { get; set; }

        public virtual ICollection<TTussenkarwapen> TTussenkarwapens { get; set; }
    }
}
