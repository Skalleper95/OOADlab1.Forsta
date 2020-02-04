using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BusinessLayer
{
    public class BokningsRepository
    {

        public List<Bokning> Bokningar { get; set; }

        public BokningsRepository(Medlem M, Anställd A, Bok b)
        {
            Bokningar = new List<Bokning>();

            List<Bok> L = new List<Bok>();
            L.Add(b);
            
            Bokning B = new Bokning(M, A, 1, new DateTime(2020-01-20), new DateTime(2020-01-29), L);
            Bokningar.Add(B);
        }

        //Metod för att lägga in en bokning i Bokningslistan
        public void AddBokning(Bokning B)
        {
            Bokningar.Add(B);
        }

        public Bokning GetBokning(int MedlemsNr)
        {
            
            foreach (Bokning B in Bokningar)
            {
                if (B.medlem.MedlemsNr == MedlemsNr)
                {
                    return B;
                }
            }
            return null;

        }
    }
}


