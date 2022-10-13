using ClassDemoListDictionary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoListDictionary
{
    public class KundeKatalogListe
    {
        private readonly List<Kunde> _kunder;
        public KundeKatalogListe()
        {
            _kunder = new List<Kunde>();
        }



        // CRUD operationer

        // Create
        public void Add(Kunde kunde)
        {
            _kunder.Add(kunde);
        }

        // Read  - alle
        public List<Kunde> GetAll()
        {
            // laver en kopi af listen
            return new List<Kunde>(_kunder);
        }

        // Read - en ud fra KundeNummer
        public Kunde GetByNumber(int kundeNummer)
        {
            foreach (Kunde k in _kunder)
            {
                if (k.KundeNummer == kundeNummer)
                {
                    // fundet
                    return k;
                }
            }


            // ingen fundet
            return null;
        }

        // Read - en ud fra mobil nummer
        public Kunde GetByMobil(String mobil)
        {
            foreach (Kunde k in _kunder)
            {
                if (k.Mobil == mobil)
                {
                    // fundet
                    return k;
                }
            }


            // ingen fundet
            return null;
        }

        // Update
        public void Update(Kunde kunde)
        {
            Kunde fundetkunde = GetByNumber(kunde.KundeNummer);
            if (fundetkunde is not null)
            {
                fundetkunde.Name = kunde.Name;
                fundetkunde.Mobil = kunde.Mobil;
            }

            // hvis ingen fundet -> ingen opdatering
        }

        // Delete
        public void Delete(Kunde kunde)
        {
            _kunder.Remove(kunde);
        }

    }
}
