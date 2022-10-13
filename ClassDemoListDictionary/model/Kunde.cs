using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoListDictionary.model
{
    public class Kunde
    {
        // Properties
        public int KundeNummer { get; set; }
        public String Name { get; set; }
        public String Mobil { get; set; }


        // Konstruktører
        public Kunde()
        {
        }

        public Kunde(int kundeNummer, string name, string mobil)
        {
            KundeNummer = kundeNummer;
            Name = name;
            Mobil = mobil;
        }

        
        // ToString
        public override string ToString()
        {
            return $"{{{nameof(KundeNummer)}={KundeNummer.ToString()}, {nameof(Name)}={Name}, {nameof(Mobil)}={Mobil}}}";
        }
    }
}
