using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class AnställdRepository
    {


        public List<Anställd> anställda = new List<Anställd>();
        
        public List<Bokning> B = new List<Bokning>();

        public AnställdRepository()
        {
            // en lista med anställda

            
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

        public Anställd GetAnställd(int anstNr)
        {
            foreach(Anställd A in anställda)
            {
                if (A.anstNr == anstNr)
                {
                    return A;
                }
            }
            return null;
        }

        


        
    }
}
