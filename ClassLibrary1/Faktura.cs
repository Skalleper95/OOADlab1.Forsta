using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Faktura
    {
        public int FakturaId { get; set; }
        public int Pris { get; set; }
        public  Bokning bokning { get; set; }
        public List<Bok> böcker { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Faktura(int fakturaId, int pris, Bokning bokning, List<Bok> böcker, DateTime startDate, DateTime endDate)
        {
            this.FakturaId = fakturaId;
            this.Pris = pris;
            this.bokning = bokning;
            this.böcker = böcker;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
