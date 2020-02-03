using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BokRepository
    {
        public List<Bok> Böcker = new List<Bok>();
        public BokRepository(List<Bok> Böcker)
        {
            // Lista med böcker 

            Böcker.Add(new Bok(1234, "sagan om ringen"));
            Böcker.Add(new Bok(1235, "Bibeln"));
            Böcker.Add(new Bok(1236, "Harry Potter"));
            Böcker.Add(new Bok(1237, "Hur du tränar din drake"));
            Böcker.Add(new Bok(1238, "The shining"));
            Böcker.Add(new Bok(1239, "Porr för kvinnor"));
            Böcker.Add(new Bok(1240, "How to get rich"));
            Böcker.Add(new Bok(1241, "How to get poor"));
            Böcker.Add(new Bok(1242, "Drugs are good for you"));
            Böcker.Add(new Bok(1243, "How to get rid of you baby"));
            Böcker.Add(new Bok(1244, "Repository for dummies"));

        }
            

    }
}
