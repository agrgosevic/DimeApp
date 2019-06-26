using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimeDLL
{
    public class ProvjeraUnosa
    {
        public bool ProvjeraNapomena(string napomena)
        {
            if (napomena == string.Empty)
                return true;
            else
                return false;
        }

        public bool ProvjeraOpis(string opis)
        {
            if (opis == string.Empty)
                return true;
            else
                return false;
        }

        public bool ProvjeraZabijeniPoeni(string zabijeniPoeni)
        {
            if (zabijeniPoeni == string.Empty)
                return true;
            else
                return false;
        }

        public bool ProvjeraPrimljeniPoeni(string primljeniPoeni)
        {
            if (primljeniPoeni == string.Empty)
                return true;
            else
                return false;
        }
    }
}
