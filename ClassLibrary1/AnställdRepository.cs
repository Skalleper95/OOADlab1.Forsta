using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class AnställdRepository
    {

        public AnställdRepository AnstRepo { get; set; }
        public List<Anställd> anställda = new List<Anställd>();
        
        public List<Bokning> B = new List<Bokning>();

        public AnställdRepository()
        {
            // Fyller listan med anställda

            
            anställda.Add(new Anställd(1, "Janne", "LoL", "chef", B));
            anställda.Add(new Anställd(2, "Amy", "LoL", "expedit", B));
            anställda.Add(new Anställd(3, "Björn", "LoL", "expedit", B));
            anställda.Add(new Anställd(4, "Lars", "LoL", "expedit", B));
            anställda.Add(new Anställd(5, "Matilda", "LoL", "expedit", B));
            anställda.Add(new Anställd(6, "Jöran", "LoL", "expedit", B));
            anställda.Add(new Anställd(7, "Peter", "LoL", "expedit", B));
            anställda.Add(new Anställd(8, "Sofia", "LoL", "expedit", B));
            anställda.Add(new Anställd(9, "Bigdick", "LoL", "chef", B));

        }
        
        // Metod för att hämta en anställd
        
        public int inloggad = 0;
        //Metod för inloggning
        public bool loggaIn(int anstNr, string lösen)
        {

            bool OK = false;
            foreach (Anställd a in anställda)
            {
                if (a.anstNr == anstNr)
                {
                    if (lösen == a.lösenord.ToLower())
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
