using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    class Anställd
    {
        public int anstNr { get; set; }
        public string namn { get; set; }
        public string lösenord { get; set; }
        public string roll { get; set; }
        public List<Bokning> bokning { get; set; }

        public Anställd(int anstNr, string namn, string lösenord, string roll, List<Bokning> bokning)
        {
            this.anstNr = anstNr;
            this.namn = namn;
            this.lösenord = lösenord;
            this.roll = roll;
            this.bokning = bokning;
        }

        public Bokning skapaBokning(int MedlemsNr,List<Bok> böcker)
        {
            
        }
    }
}
