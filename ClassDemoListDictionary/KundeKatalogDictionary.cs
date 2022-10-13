using ClassDemoListDictionary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoListDictionary
{
    public class KundeKatalogDictionary
    {

        private readonly Dictionary<int, Kunde> _kunder;
        
        public KundeKatalogDictionary()
        {
            _kunder = new Dictionary<int, Kunde>();
        }



        // CRUD operationer

        // Create
        public void Add(Kunde kunde)
        {
            _kunder.Add(kunde.KundeNummer, kunde);
        }

        // Read  - alle
        public List<Kunde> GetAll()
        {
            // laver en kopi af dictionarys værdier
            return new List<Kunde>(_kunder.Values);
        }

        // Read - en ud fra KundeNummer
        public Kunde GetByNumber(int kundeNummer)
        {
            return _kunder[kundeNummer];
        }

        // Read - en ud fra mobil nummer
        public Kunde GetByMobil(String mobil)
        {
            foreach (Kunde k in _kunder.Values)
            {
                if (k.Mobil == mobil)
                {
                    return k;
                }
            }
            return null;
        }

        // Update
        public void Update(Kunde kunde)
        {
            _kunder[kunde.KundeNummer] = kunde;
        }

        // Delete
        public void Delete(Kunde kunde)
        {
            _kunder.Remove(kunde.KundeNummer);
        }

    }
}
