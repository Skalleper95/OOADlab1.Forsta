using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    class BokningsRepository
    {

       
        public List<Anställd> A = new List<Anställd>();
        public List<Medlem> M = new List<Medlem>();

        BokningsRepository(List<Bokning> Bokningar, List<Bok> Böcker,List<Medlem> m,List<Anställd> a)
        {
            M = m;
            A = a;

            Bokningar.Add(new Bokning(m,a,1,new DateTime(2020 - 01 - 12), new DateTime(2020 - 01 - 19), Böcker));
            Bokningar.Add(new Bokning(m, a, 1, new DateTime(2020 - 01 - 12), new DateTime(2020 - 01 - 19), Böcker));

            //Bokningar.Add(new Bokning() //new DateTime(2020 - 01 - 12), new DateTime(2020 - 01 - 19), Böcker));
        }
    }
}


