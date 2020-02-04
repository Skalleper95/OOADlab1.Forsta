using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class FakturaRepository
    {
        public List<Faktura> fakturor { get; set; }

        public FakturaRepository()
        {
            fakturor = new List<Faktura>();
        }

        //Metod för att lägga till en faktura i listan 
        public void AddFaktura (Faktura F)
        {
            fakturor.Add(F);
        }
    }
}
