﻿using System;
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

            //fyller listan med Medlemmar
            Medlemmar.Add(new Medlem(1, "Daniel", 070987654, "Daniel@hotmail.com", b));
            Medlemmar.Add(new Medlem(2, "Erik", 070987123, "Erikl@hotmail.com", b));
            Medlemmar.Add(new Medlem(3, "Louise", 070987345, "Louise@hotmail.com", b));
            Medlemmar.Add(new Medlem(4, "Axel", 0709875667, "Axel@hotmail.com", b));
            Medlemmar.Add(new Medlem(5, "Mohamed", 070987789, "Mohamed@hotmail.com", b));
            Medlemmar.Add(new Medlem(6, "El-heffe", 07091234, "ElHeffe@hotmail.com", b));
            Medlemmar.Add(new Medlem(7, "Hampus", 070984567, "Hampus@hotmail.com", b));
            Medlemmar.Add(new Medlem(8, "Pochahontas", 070985678, "Pochahontas@hotmail.com", b));
            Medlemmar.Add(new Medlem(9, "Ariel", 070912345, "Ariel@hotmail.com", b));

        }


        //Metod för att hämta en medlem
        public Medlem GetMedlem(int medNr)
        {
            Medlem M = null;

            foreach (Medlem m in this.Medlemmar)
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

