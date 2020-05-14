using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaPersonala
{
    class Activitate
    {
        private string denumire;
        private Data data;
        private Ora inceput;
        private Ora sfarsit;
        private string descriere;
        private List<Persoana> participanti;

        public Activitate(string denumire, Data data, Ora inceput, Ora sfarsit, string descriere)
        {
            this.denumire = denumire;
            this.data = data;
            this.inceput = inceput;
            this.sfarsit = sfarsit;
            this.descriere = descriere;
            participanti = new List<Persoana>();
        }

        public Data GetData()
        {
            return data;
        }

        public string getDescriere()
        {
            return descriere;
        }

        public void adaugarePersoana(Persoana pers)
        {
            participanti.Add(pers);
        }

        public string getDenumire()
        {
            return this.denumire;
        }

        public Ora getOraInceput()
        {
            return inceput;
        }

        public Ora getOraSfarsit()
        {
            return sfarsit;
        }
    }
}
