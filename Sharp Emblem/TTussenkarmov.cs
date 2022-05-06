using System;
using System.Collections.Generic;

namespace Sharp_Emblem
{
    public partial class TTussenkarmov
    {
        public int KarMovId { get; set; }
        public int CharId { get; set; }
        public int MovementId { get; set; }

        public virtual TKarakter? Char { get; set; }
        public virtual TBeweging? Movement { get; set; }
    }
}
