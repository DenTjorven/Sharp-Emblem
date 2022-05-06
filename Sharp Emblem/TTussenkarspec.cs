using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TTussenkarspec
    {
        public int KarSpecId { get; set; }
        public int CharId { get; set; }
        public int SpecialId { get; set; }

        public virtual TKarakter? Char { get; set; }
        public virtual TSpeciaal? Special { get; set; }
    }
}
