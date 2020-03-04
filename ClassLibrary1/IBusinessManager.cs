using System.Collections.Generic;

namespace BusinessLayer
{
    internal interface IBusinessManager
    {
        AnställdRepository AnstRepo { get; set; }
        BokningsRepository BoknRepo { get; set; }
        BokRepository BokRepo { get; set; }
        List<Bok> Böcker { get; set; }
        FakturaRepository FakRepo { get; set; }
        MedlemRepository MedRepo { get; set; }

        Anställd GetAnställd(int anstNr);
    }
}