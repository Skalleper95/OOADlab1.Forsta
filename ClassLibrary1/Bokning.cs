using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BusinessLayer
{
    public class Bokning
    {
        //Boknings klassen. 
         
        public Medlem medlem { get; set; }
        public Anställd anställd { get; set; }
        public int BokningsNr { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<Bok> böcker { get; set; }

        public override string ToString()
        {
            return BokningsNr + " " + medlem;
        }

        


        public Bokning(Medlem medlem,Anställd anställd, int bokningsNr, DateTime startDate, DateTime endDate, List<Bok> böcker)
        {
            
            this.medlem = medlem;
            this.anställd = anställd;
            this.BokningsNr = bokningsNr;
            this.startDate = startDate;
            this.endDate = endDate;
            this.böcker = böcker;
            
        }


        //Metod för att skapa en faktura 
        public Faktura skapaFaktura(int bokningsNr, BusinessManager bm)
        {
            Bokning B = bm.BoknRepo.GetBokning(bokningsNr, bm);

            int FNr = bm.FakRepo.fakturor.Count + 1;
            
            DateTime endDate = DateTime.Today;
            double pris = 0;
            
            TimeSpan ts = endDate - B.endDate;
            pris = ts.Days * 10;

            if (pris <= 0)
            {
                pris = 0;
            }

            Faktura F = new Faktura(FNr, pris, B, B.böcker, B.startDate, endDate);

            bm.FakRepo.AddFaktura(F);

            bm.BoknRepo.DeleteBokning(B.BokningsNr, bm);

            return F;

        }

        


    }
}
