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
            
            DateTime end = DateTime.Today;
            int pris = 0;
            int dagar = DateTime.Compare(B.endDate, end);

            if (dagar == 0 || dagar < 0)
            {
                
            }
            else 
            { 
                pris = dagar / 24 * 10; 
            }

            Faktura F = new Faktura(FNr, pris, B, B.böcker, B.startDate, end);

            bm.FakRepo.AddFaktura(F);

            bm.BoknRepo.DeleteBokning(B.BokningsNr, bm);

            return F;

        }

        


    }
}
