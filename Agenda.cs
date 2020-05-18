using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaPersonala
{
    class Agenda
    {
        private Persoana pers;
        private LinkedList<Activitate> activitati;

        public Agenda(Persoana pers)
        {
            this.pers = pers;
        }

        public void adaugareActivitate(Activitate a)
        {
            activitati.AddLast(a);
            a.adaugarePersoana(pers);
        }

        public Activitate[] cautareActivitate(string nume)
        {
            Activitate[] act = new Activitate[5];
            int k = 0;
            foreach(Activitate a in activitati)
            {
                if (a.getDenumire().Equals(nume))
                {
                    act[k++] = a;
                }
            }
            return act;
        }

        public void stergereActivitate(string nume)
        {
            foreach(Activitate a in activitati)
            {
                if (nume.Equals(a.getDenumire()))
                {
                    activitati.Remove(a);
                    break;
                }
            }
        }

        public List<Activitate> raport(Ora inceput, Ora sfarsit, Data zi)
        {
            List<Activitate> act = new List<Activitate>();
            foreach(Activitate a in activitati)
            {
                if(a.getOraInceput() > inceput && a.getOraSfarsit() < sfarsit && a.getData() == zi)
                {
                    act.Add(a);
                }
            }
            return act;
      
        }
    }
}
