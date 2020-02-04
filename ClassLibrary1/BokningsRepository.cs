using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BusinessLayer
{
    public class BokningsRepository
    {

        public List<Bokning> Bokningar { get; set; }

        public BokningsRepository()
        {
            Bokningar = new List<Bokning>();

            //Bokningar.Add(new Bokning((Medlem)MedlemRepository[0], A, 1, new DateTime(2020 - 02 - 04), new DateTime(2020 - 02 - 11), Böcker));

            //Bokningar.Add(new Bokning(M,A,1,new DateTime(2020 - 01 - 12), new DateTime(2020 - 01 - 19), Böcker));
            
            //Bokningar.Add(new Bokning() //new DateTime(2020 - 01 - 12), new DateTime(2020 - 01 - 19), Böcker));
        }

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


