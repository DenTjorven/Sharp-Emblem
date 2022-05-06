using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TTussenkarwapen
    {
        public int KarWapenId { get; set; }
        public int CharId { get; set; }
        public int WeaponId { get; set; }

        public virtual TKarakter? Char { get; set; }
        public virtual TWapen? Weapon { get; set; }
    }
}
