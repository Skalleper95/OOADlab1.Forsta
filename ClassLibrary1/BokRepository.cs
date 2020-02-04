using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BokRepository
    {
        public List<Bok> Böcker { get; set; }
        
        public BokRepository()
        {
            Böcker = new List<Bok>();
            // Lista med böcker 

            Böcker.Add(new Bok(1234, "sagan om ringen"));
            Böcker.Add(new Bok(1235, "Bibeln"));
            Böcker.Add(new Bok(1236, "Harry Potter"));
            Böcker.Add(new Bok(1237, "Hur du tränar din drake"));
            Böcker.Add(new Bok(1238, "The shining"));
            Böcker.Add(new Bok(1239, "How to get dates"));
            Böcker.Add(new Bok(1240, "How to get rich"));
            Böcker.Add(new Bok(1241, "How to get poor"));
            Böcker.Add(new Bok(1242, "Drugs are good for you"));
            Böcker.Add(new Bok(1243, "C# for dummies"));
            Böcker.Add(new Bok(1244, "Repositories for dummies"));

        }

        public Bok Getbok(int ISBN)
        {
            Bok b = null;
            foreach (Bok B in Böcker)
            {
                if (B.ISBNnr == ISBN)
                {
                    b = B ;
                   
                }
                
                
            }
            return b;
        }  
        
        public List<Bok> GetBöcker()
        {
            List<Bok> B = new List<Bok>();
            foreach (Bok b in Böcker)
            {
                B.Add(b);
            }
            return B;
        }

    }
}
