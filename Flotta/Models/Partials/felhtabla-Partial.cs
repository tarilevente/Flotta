using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Models
{
   public partial class felhtabla
    {
        public felhtabla(
            int p_id,
            string p_vezetekNev,
            string p_keresztNev,
            string p_varos,
            string p_utcaHsz,
            string p_telefon,
            string p_belepesNev,
            string p_belepesJelszo,
            bool p_soforE,
            bool p_adminE
            )
        {
            this.idFelh = p_id;
            this.vezetekNev = p_vezetekNev;
            this.keresztNev = p_keresztNev;
            this.varos = p_varos;
            this.utcaHsz = p_utcaHsz;
            this.telefon = p_telefon;
            this.belepesNev = p_belepesNev;
            this.belepesJelszo = p_belepesJelszo;
            this.soforE = Convert.ToSByte(p_soforE);
            this.adminE = Convert.ToSByte(p_adminE);
        }


    }
}
