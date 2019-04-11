using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Elev : IComparable, IEquatable<Elev>
    {
        public Elev(String nume, String prenume, long varsta)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
        }

        public String toString()
        {
            return Nume;
        }

        public int CompareTo(object obj)
        {
            Elev other = obj as Elev;

            if (Nume == other.Nume)
            {
                if (Prenume == other.Prenume)
                {
                    if (Varsta == other.Varsta)
                    {
                        return 0;
                    }
                }
            }

            return 1;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Elev objAsPart = obj as Elev;
            if (objAsPart == null)
            {
                return false;
            }
            else
            {
                return Equals(objAsPart);
            }
        }

        public bool Equals(Elev other)
        {
            if (other == null)
            {
                return false;
            }
            return (this.Nume.Equals(other.Nume));
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(Nume);
        }

        String Nume { get; set; }
        String Prenume { get; set; }
        long Varsta { get; set; }
    }
}
