using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    class Bokning
    {
        public Medlem medlem { get; set; }
        public Anställd anställd { get; set; }
        public string BokningsNr { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<Bok> böcker { get; set; }

        public Bokning(Medlem medlem, Anställd anställd, string bokningsNr, DateTime startDate, DateTime endDate, List<Bok> böcker)
        {
            this.medlem = medlem;
            this.anställd = anställd;
            BokningsNr = bokningsNr;
            this.startDate = startDate;
            this.endDate = endDate;
            this.böcker = böcker;
        }

        public Faktura skapaFaktura()
        {
            return F;
        }
        


    }
}
