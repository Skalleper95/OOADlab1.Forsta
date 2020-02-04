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

        public override string ToString()
        {
            return anstNr + " " + namn;
        }



        //EN metod som skapar en bokning 
        public Bokning skapaBokning(int MedlemsNr, List<Bok> böcker, int anstNr, BusinessManager bm)
        {
            Medlem M = bm.MedRepo.GetMedlem(MedlemsNr);
            Anställd A = bm.AnstRepo.GetAnställd(anstNr);
            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(7);

            int BokningsNr = bm.BoknRepo.Bokningar.Count + 1;
            Bokning B = new Bokning(M, A, BokningsNr, start, end, böcker);

            
            return B;

        }
    }
}
