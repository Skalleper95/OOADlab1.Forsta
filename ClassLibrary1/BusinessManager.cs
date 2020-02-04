using System;
using System.Collections.Generic;
using System.Text;



namespace BusinessLayer
{
    public class BusinessManager
    {

        public MedlemRepository MedRepo { get; set; }
        public AnställdRepository AnstRepo { get; set; }
        public BokRepository BokRepo { get; set; }
        public BokningsRepository BoknRepo { get; set; }
        public FakturaRepository FakRepo { get; set; }
        public  int inloggad { get; set; }


        public BusinessManager()
        {

            Medlem M = new Medlem(10, "Calle", 0708555789, "calle@hotmail.com", new List<Bokning>());
            Anställd A = new Anställd(10, "Lisa", "LOL", "expedit", new List<Bokning>());
            Bok B = new Bok(1245, "How do?");

            MedRepo = new MedlemRepository();
            AnstRepo = new AnställdRepository();
            BokRepo = new BokRepository();
            BoknRepo = new BokningsRepository(M, A, B);
            FakRepo = new FakturaRepository();

            MedRepo.Medlemmar.Add(M);
            AnstRepo.anställda.Add(A);
            BokRepo.Böcker.Add(B);
           
        }

        public bool loggaIn(int anstNr, string lösen)
        {
            int inloggad = 0;
            bool OK = false;
            foreach (Anställd a in AnstRepo.anställda)
            {
                if (a.anstNr == anstNr)
                {
                    if (lösen == a.lösenord)
                    {
                        OK = true;
                        inloggad = anstNr;
                    }
                }
               
            }
            
            return OK;

        }




    }
}
