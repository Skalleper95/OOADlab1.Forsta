using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer
{
    public class Bokning
    {
        //Boknings klassen. 
         
        //public Medlem medlem { get; set; }
        public List<Medlem> medlemar { get; set; }
        public List<Anställd> anställda { get; set; }
        //public Anställd anställd { get; set; }
        public int BokningsNr { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<Bok> böcker { get; set; }




        public Bokning(List<Medlem> medlemar, List<Anställd> anställda, int bokningsNr, DateTime startDate, DateTime endDate, List<Bok> böcker)
        {
            
            this.medlemar = medlemar;
            this.anställda = anställda;
            BokningsNr = bokningsNr;
            this.startDate = startDate;
            this.endDate = endDate;
            this.böcker = böcker;
            
        }

        public Faktura skapaFaktura()
        {
            if(st)
        }
        


    }
}
