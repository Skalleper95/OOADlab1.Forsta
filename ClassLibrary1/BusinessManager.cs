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

        
        public BusinessManager()
        {
            MedRepo = new MedlemRepository();
            AnstRepo = new AnställdRepository();
            BokRepo = new BokRepository();
            BoknRepo = new BokningsRepository();
            FakRepo = new FakturaRepository();
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
