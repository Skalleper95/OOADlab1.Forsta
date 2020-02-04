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
            b = B;

            Fakturor.Add(new Faktura(12, 150, B, Böcker,new DateTime (20,12,11),new DateTime(20,12,18)));
        }
    }
}
