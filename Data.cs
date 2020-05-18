using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaPersonala
{
    class Data
    {
        private int an;
        private int luna;
        private int zi;

        public Data(int an, int luna, int zi)
        {
            this.an = an;
            this.luna = luna;
            this.zi = zi;
        }

        public override string ToString()
        {
            return an + "/" + luna + "/" + zi;
        }

        public static bool operator ==(Data x, Data y)
        {
            if (x.getAn() == y.getAn() && x.getLuna() == y.getLuna() && x.getZi() == y.getZi())
                return true;
            return false;
        }

        public static bool operator !=(Data x, Data y)
        {
            if (x.getAn() == y.getAn() && x.getLuna() == y.getLuna() && x.getZi() == y.getZi())
                return false;
            return true;
        }

        public int getAn()
        {
            return an;
        }

        public int getLuna()
        {
            return luna;
        }

        public int getZi()
        {
            return zi;
        }

        public void setAn(int an)
        {
            this.an = an;
        }

        public void setLuna(int luna)
        {
            this.luna = luna;
        }

        public void setZi(int zi)
        {
            this.zi = zi;
        }

       
    }
}
