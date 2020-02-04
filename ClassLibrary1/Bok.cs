using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer
{
    public class Bok
    {
        public int ISBNnr { get; set; }
        public string titel { get; set; }

        public Bok(int iSBNnr, string titel)
        {
            ISBNnr = iSBNnr;
            this.titel = titel;
        }

        public override string ToString()
        {
            return ISBNnr + " " + titel;
        }
    }
}
