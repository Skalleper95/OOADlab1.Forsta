using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BusinessLayer
{
    public class Bokning
    {
        //Boknings klassen. 
         
        public Medlem medlem { get; set; }
        public Anställd anställd { get; set; }
        public int BokningsNr { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<Bok> böcker { get; set; }
       

        public override string ToString()
        {
            return BokningsNr + " " + medlem;
        }

        


        public Bokning(Medlem medlem,Anställd anställd, int bokningsNr, DateTime startDate, DateTime endDate, List<Bok> böcker)
        {
            
            this.medlem = medlem;
            this.anställd = anställd;
            this.BokningsNr = bokningsNr;
            this.startDate = startDate;
            this.endDate = endDate;
            this.böcker = böcker;
            
        }
        



        


    }
}
