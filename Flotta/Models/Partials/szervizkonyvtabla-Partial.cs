using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Models
{
    public partial class szervizkonyvtabla
    {
        public szervizkonyvtabla()
        {

        }

        public szervizkonyvtabla(string p_rendszamHOZ, DateTime p_idopont, string p_leiras, bool p_cascoE, bool p_biztositasE)
        {
            this.rendszamHOZ = p_rendszamHOZ;
            this.idopont = p_idopont;
            this.leiras = p_leiras;
            this.cascoE = Convert.ToSByte(p_cascoE);
            this.biztositasE = Convert.ToSByte(p_biztositasE);
        }


    }
}
