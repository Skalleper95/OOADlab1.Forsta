using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class FakturaRepository
    {
        public FakturaRepository(List<Faktura> Fakturor, List<Bok> Böcker)
        {
            Fakturor.add(new Faktura("S12", 150, bokning, Böcker,new DateTime (20,12,11),new DateTime(20,12,18)));
        }
    }
}
