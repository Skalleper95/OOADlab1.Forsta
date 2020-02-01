using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;


namespace DataLayer
{
    

    public class AnställdLista
    {

        BusinessLayer bl = new BusinessLayer;
        public static List<Anställd> LoadSampleData()
        {
            List<Anställd> output = new List<Anställd>();
            output.Add(new Anställd() { anstNr = 1, namn = "Janne", lösenord = "LoL", roll = "Chef" });
            output.Add(new Anställd() { anstNr = 2, namn = "Amy", lösenord = "LoL", roll = "receptionist" });
            output.Add(new Anställd() { anstNr = 3, namn = "Björn", lösenord = "LoL", roll = "receptionist" });
            output.Add(new Anställd() { anstNr = 4, namn = "Lars", lösenord = "LoL", roll = "receptionist" });
            output.Add(new Anställd() { anstNr = 5, namn = "Matilda", lösenord = "LoL", roll = "receptionist" });
            output.Add(new Anställd() { anstNr = 6, namn = "Jöran", lösenord = "LoL", roll = "receptionist" });
            output.Add(new Anställd() { anstNr = 7, namn = "Peter", lösenord = "LoL", roll = "receptionist" });
            output.Add(new Anställd() { anstNr = 8, namn = "Sofia", lösenord = "LoL", roll = "receptionist" });
            output.Add(new Anställd() { anstNr = 9, namn = "Bigdick", lösenord = "LoL", roll = "Chef" });

            return output;


        }
    }
}
