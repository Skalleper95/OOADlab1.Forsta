using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    class BokningsRepository
    {

       
        public List<Anställd> anställda = new List<Anställd>();

        BokningsRepository(List<Bokning> Bokningar, List<Bok> Böcker,List<Medlem> M,List<Anställd> A)
        {
            
         

            //Bokningar.Add(new Bokning(M,A,1,new DateTime(2020 - 01 - 12), new DateTime(2020 - 01 - 19), Böcker));
            
            //Bokningar.Add(new Bokning() //new DateTime(2020 - 01 - 12), new DateTime(2020 - 01 - 19), Böcker));
        }
    }
}


