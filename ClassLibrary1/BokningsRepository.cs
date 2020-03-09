using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BusinessLayer
{
    public class BokningsRepository
    {

        public List<Bokning> Bokningar { get; set; }

        public BokningsRepository(/*Medlem M, Anställd A, Bok b*/)
        {
            Bokningar = new List<Bokning>();

            //List<Bok> L = new List<Bok>();
            //L.Add(b);
            
            //Bokning B = new Bokning(M, A, 1, new DateTime(2020, 01, 03), new DateTime(2020, 01, 10), L);
            
        }

        //Metod för att lägga in en bokning i Bokningslistan
        public void AddBokning(Bokning B)
        {
            Bokningar.Add(B);
        }

        //Metod för att hämta en bokning i listan
        public Bokning GetBokning(int BokningsNr)
        {
            Bokning b = null;

            foreach (Bokning B in Bokningar)
            {
                if (B.BokningsNr == BokningsNr)
                {
                    b = B;
                }
            }

            return b;
        }

        //Metod för att ta bort en bokning ur listan 
        public void DeleteBokning(int bokningsNr)
        {
            for (int i = 0; i < Bokningar.Count; i++)
            {
                if (Bokningar[i].BokningsNr == bokningsNr)
                {
                    Bokningar.RemoveAt(i);
                }
            }
        }
    }
}


