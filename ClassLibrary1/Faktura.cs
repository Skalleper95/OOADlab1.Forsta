using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Faktura
    {
        //klassen faktura. StartDate  och EndDate håller koll på när fakturan startar och slutar
        public string FakturaId { get; set; }
        public int Pris { get; set; }
        public  Bokning bokning { get; set; }
        public List<Bok> böcker { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Faktura(string fakturaId, int pris, Bokning bokning, List<Bok> böcker, DateTime startDate, DateTime endDate)
        {
            FakturaId = fakturaId;
            Pris = pris;
            this.bokning = bokning;
            this.böcker = böcker;
            this.endDate = startDate.AddDays(7);
            this.startDate = DateTime.Now;
            //this.endDate = endDate;

        }
    }
}
