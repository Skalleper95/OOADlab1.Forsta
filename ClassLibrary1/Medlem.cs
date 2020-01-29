using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    class Medlem
    {
        public int MedlemsNr { get; set; }
        public string namn { get; set; }
        public int teleNr { get; set; }
        public string eMail { get; set; }
        public List<Bokning> bokning { get; set; }

        public Medlem(int medlemsNr, string namn, int teleNr, string eMail, List<Bokning> bokning)
        {
            MedlemsNr = medlemsNr;
            this.namn = namn;
            this.teleNr = teleNr;
            this.eMail = eMail;
            this.bokning = bokning;
        }

        public Medlem GetMed(int MedNr)
        {
            foreach(Medlem in)
        }
    }
}
