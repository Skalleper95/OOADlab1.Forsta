using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer
{
    public class Medlem
    {

        //Klassen medlem 
        public int MedlemsNr { get; set; }
        public string namn { get; set; }
        public int teleNr { get; set; }
        public string eMail { get; set; }
        public List<Bokning> bokningar { get; set; }


        public Medlem(int medlemsNr, string namn, int teleNr, string eMail, List<Bokning> bokningar)
        {
            this.MedlemsNr = medlemsNr;
            this.namn = namn;
            this.teleNr = teleNr;
            this.eMail = eMail;
            this.bokningar = bokningar;
        }

        public override string ToString()
        {
            return MedlemsNr + " " + namn;
        }

    }
}
