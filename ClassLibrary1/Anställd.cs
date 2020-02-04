using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer
{
    public class Anställd
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
        //Medlem medlem, Anställd anställd, string bokningsNr, DateTime startDate, DateTime endDate, List<Bok> böcker
        public Bokning skapaBokning(int MedlemsNr, List<Bok> böcker, int anstNr)
        {
            //hitta rätt medlem i repositorin
            DateTime DS = DateTime.Now;
            DateTime D = DS.AddDays(7);

            int BokningsNr = bokning.Count + 1;
            Bokning B = new Bokning;
            BokningsRepository.AddBokning(B);
            return B;

        }
    }
}
