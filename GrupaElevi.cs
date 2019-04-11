using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class GrupaElevi
    {
        public GrupaElevi()
        {
            grupa = new List<Elev>();
        }

        public Boolean adaugaElev(Elev elev)
        {
            if (!grupa.Contains(elev))
            {
                grupa.Add(elev);
                return true;
            }
            return false;
        }

        List<Elev> grupa;
    }
}
