using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaPersonala
{
    class Ora
    {
        private int ora;
        private int minut;

        public Ora(int ora, int minut)
        {
            this.ora = ora;
            this.minut = minut;
        }

        public override string ToString()
        {
            return ora + ":" + minut;
        }

        public void setOra(int ora)
        {
            this.ora = ora;
        }

        public void setMinut(int minut)
        {
            this.minut = minut;
        }

        public int getOra()
        {
            return ora;
        }

        public int getMinut()
        {
            return minut;
        }

        public static bool operator <(Ora x, Ora y)
        {
            if(x.getOra() < y.getOra())
            {
                return true;
            }
            else if (x.getOra() == y.getOra())
            {
                if(x.getMinut() < y.getMinut())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator >(Ora x, Ora y)
        {
            if (x.getOra() > y.getOra())
            {
                return true;
            }
            else if (x.getOra() == y.getOra())
            {
                if (x.getMinut() > y.getMinut())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
