using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaPersonala
{
    class Persoana
    {
        private string nume;
        private string prenume;
        private string email;

        public Persoana(string nume, string prenume, string email)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.email = email;
        }

        public string getNume()
        {
            return this.nume;
        }

        public string getPrenume()
        {
            return this.prenume;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
    }
}
