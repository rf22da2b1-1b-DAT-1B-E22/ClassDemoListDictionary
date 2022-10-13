using ClassDemoListDictionary.model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoListDictionary
{
    public class KundeKatalogArray
    {
        private readonly Kunde[] _kunder;
        private int nextIx = 0;     // skal selv holde styr på hvor du har fyldt i arrayet


        public KundeKatalogArray()
        {
            _kunder = new Kunde[50];   // Max 50 kunder
                                       // første ledige plads er nextId => 0   
        }



        // CRUD operationer

        // Create
        public void Add(Kunde kunde)
        {
            _kunder[nextIx] = kunde;
            nextIx++;

        }

        // Read  - alle
        public List<Kunde> GetAll()
        {
            List<Kunde> kunder = new List<Kunde>();

            for (int i = 0; i < nextIx; i++)
            {
                kunder.Add(_kunder[i]);
            }
            return kunder;
        }

        // Read - en ud fra KundeNummer
        public Kunde GetByNumber(int kundeNummer)
        {
            for (int i = 0; i < nextIx; i++)
            {
                if (_kunder[i].KundeNummer == kundeNummer)
                {
                    return _kunder[i];
                }
            }
            return null;
        }

        // Read - en ud fra mobil nummer
        public Kunde GetByMobil(String mobil)
        {
            for (int i = 0; i < nextIx; i++)
            {
                if (_kunder[i].Mobil == mobil)
                {
                    return _kunder[i];
                }
            }
            return null;
        }

        // Update
        public void Update(Kunde kunde)
        {
            for (int i = 0; i < nextIx; i++)
            {
                if (_kunder[i].KundeNummer == kunde.KundeNummer)
                {
                    _kunder[i].Name = kunde.Name;
                    _kunder[i].Mobil = kunde.Mobil;

                }
            }
        }

        // Delete
        public void Delete(Kunde kunde)
        {
            int indexForDelete = -1;
            for (int i = 0; i < nextIx; i++)
            {
                if (_kunder[i].KundeNummer == kunde.KundeNummer)
                {
                    indexForDelete = i;
                }
            }

            if (indexForDelete != -1) {
                DeleteIndex(indexForDelete);
            }
        }

        private void DeleteIndex(int indexForDelete)
        {
            for (int i = indexForDelete+1; i < nextIx; i++)
            {
                _kunder[i - 1] = _kunder[i];
            }
            _kunder[nextIx] = null;
            nextIx--;
        }
    }
}
