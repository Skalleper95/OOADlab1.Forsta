using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class FakturaRepository
    {
        public List<Bokning> B = new List<Bokning>();

        public FakturaRepository(List<Faktura> Fakturor, List<Bok> Böcker,List<Bokning> b)
        {
            B = b;

            Fakturor.Add(new Faktura("S12", 150, b, Böcker,new DateTime (20,12,11),new DateTime(20,12,18)));
        }
    }
}
