using System;
using System.Collections.Generic;
using System.Text;



namespace BusinessLayer
{
    public class BusinessManager : IBusinessManager
    {

        public MedlemRepository MedRepo { get; set; }
        public AnställdRepository AnstRepo { get; set; }
        public BokRepository BokRepo { get; set; }
        public BokningsRepository BoknRepo { get; set; }
        public FakturaRepository FakRepo { get; set; }
        public List<Bok> Böcker { get; set; }

        private BusinessManager()
        {
            //Extra data som skapas för att skapa en initciell bokning 
            Medlem M = new Medlem(10, "Calle", 0708555789, "calle@hotmail.com", new List<Bokning>());
            Anställd A = new Anställd(10, "Lisa", "LOL", "expedit", new List<Bokning>());
            Bok B = new Bok(1245, "How do?");

            MedRepo = new MedlemRepository();
            AnstRepo = new AnställdRepository();
            BokRepo = new BokRepository();
            BoknRepo = new BokningsRepository(M, A, B);
            FakRepo = new FakturaRepository();

            //Lägger in extradatan i sina respektive listor
            MedRepo.Medlemmar.Add(M);
            AnstRepo.anställda.Add(A);
            BokRepo.Böcker.Add(B);

        }
       
        public Anställd GetAnställd(int anstNr)
        {
            foreach (Anställd A in AnstRepo.anställda)
            {
                if (A.anstNr == anstNr)
                {
                    return A;
                }
            }
            return null;
        }



        
        public Faktura skapaFaktura(int bokningsNr)
        {
            Bokning B = BoknRepo.GetBokning(bokningsNr);

            int FNr = FakRepo.fakturor.Count + 1;

            DateTime endDate = DateTime.Today;
            double pris = 0;

            TimeSpan ts = endDate - B.endDate;
            pris = ts.Days * 10;

            if (pris <= 0)
            {
                pris = 0;
            }

            Faktura F = new Faktura(FNr, pris, B, B.böcker, B.startDate, endDate);

            FakRepo.AddFaktura(F);

            BoknRepo.DeleteBokning(B.BokningsNr);

            return F;

        }

        public class IBusinessManager : BusinessManager
        {
            public IBusinessManager()
            {
            }
        }



        //Metod för inloggning
    }
}
