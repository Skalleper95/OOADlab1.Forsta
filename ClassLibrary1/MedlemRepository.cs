using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class MedlemRepository
    {
        public List<Medlem> Medlemmar { get; set; }

        public MedlemRepository()
        {
            Medlemmar = new List<Medlem>();
            List<Bokning> b = new List<Bokning>();

            //En lista med Medlemmar
            Medlemmar.Add(new Medlem(1, "Daniel", 070987654, "Daniel@hotmail.com", b));
            Medlemmar.Add(new Medlem(1, "Erik", 070987123, "Erikl@hotmail.com", b));
            Medlemmar.Add(new Medlem(1, "Louise", 070987345, "Louise@hotmail.com", b));
            Medlemmar.Add(new Medlem(1, "Axel", 0709875667, "Axel@hotmail.com", b));
            Medlemmar.Add(new Medlem(1, "Mohamed", 070987789, "Mohamed@hotmail.com", b));
            Medlemmar.Add(new Medlem(1, "El-heffe", 07091234, "ElHeffe@hotmail.com", b));
            Medlemmar.Add(new Medlem(1, "Hampus", 070984567, "Hampus@hotmail.com", b));
            Medlemmar.Add(new Medlem(1, "Pochahontas", 070985678, "Pochahontas@hotmail.com", b));
            Medlemmar.Add(new Medlem(1, "Ariel", 070912345, "Ariel@hotmail.com", b));

        }

        public Medlem GetMedlem(int medNr)
        {
            Medlem M = null;

            foreach (Medlem m in Medlemmar)
            {
                if (m.MedlemsNr == medNr)
                {
                    M = m;
                }
            }
            return M;
        }


    }
}

