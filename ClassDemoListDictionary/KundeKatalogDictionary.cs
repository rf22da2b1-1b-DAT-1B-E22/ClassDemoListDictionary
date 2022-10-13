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
            
        }

        // Read  - alle
        public List<Kunde> GetAll()
        {
            // laver en kopi af dictionary
            return new List<Kunde>();
        }

        // Read - en ud fra KundeNummer
        public Kunde GetByNumber(int kundeNummer)
        {
            
            return null;
        }

        // Read - en ud fra mobil nummer
        public Kunde GetByMobil(String mobil)
        {
            return null;
        }

        // Update
        public void Update(Kunde kunde)
        {
            
        }

        // Delete
        public void Delete(Kunde kunde)
        {
            
        }

    }
}
