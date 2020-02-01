using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class AnställdRepository
    {


        public List<Anställd> anställda = new List<Anställd>();
        
        public List<Bokning> B = new List<Bokning>();

        public AnställdRepository(List<Anställd> anställda, List<Bokning> b)
        {
            // en lista med anställda
            //this.anställda = anställda;
            B = b;
            anställda.Add(new Anställd(1, "Janne", "LoL", "Chef", B));
            anställda.Add(new Anställd(2, "Amy", "LoL", "receptionist", B));
            anställda.Add(new Anställd(3, "Björn", "LoL", "receptionist", B));
            anställda.Add(new Anställd(4, "Lars", "LoL", "receptionist", B));
            anställda.Add(new Anställd(5, "Matilda", "LoL", "receptionist", B));
            anställda.Add(new Anställd(6, "Jöran", "LoL", "receptionist", B));
            anställda.Add(new Anställd(7, "Peter", "LoL", "receptionist", B));
            anställda.Add(new Anställd(8, "Sofia", "LoL", "receptionist", B));
            anställda.Add(new Anställd(9, "Bigdick", "LoL", "Chef", B));

        }

        


        
    }
}
