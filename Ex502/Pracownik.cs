using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex502
{
    class Pracownik:IComparable<Pracownik>
    {
        private int wynagrodzenie;
        private string imie;

        public int CompareTo(Pracownik other)
        {
            if (this.wynagrodzenie == other.wynagrodzenie)
            {
                return this.imie.CompareTo(other.imie);
            }
            return other.wynagrodzenie.CompareTo(this.wynagrodzenie);
        }

        public Pracownik(string imie, int wynagrodzenie)
        {
            this.imie = imie;
            this.wynagrodzenie = wynagrodzenie;
        }

        public string Info()
        {
            return this.imie + " " + this.wynagrodzenie;
        }

    }
}
