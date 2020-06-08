using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Models
{
    public partial class muszakiallapottabla
    {
        public muszakiallapottabla()
        {

        }

        public muszakiallapottabla(
            int p_id,
            string p_rendszamHOZ, 
            bool p_matricaMegyei,
            bool p_matricaOrszagos,
            bool p_teligumi,
            bool p_nyarigumi,
            DateTime p_muszakiErv,
            DateTime p_biztosErv,
            DateTime p_evjarat)
        {
            this.idmuszakiAllapot = p_id;
            this.rendszamHOZ = p_rendszamHOZ;
            this.matricaMegyei = Convert.ToSByte(p_matricaMegyei);
            this.matricaOrszagos =Convert.ToSByte(p_matricaOrszagos);
            this.teligumi = Convert.ToSByte(p_teligumi);
            this.nyarigumi =Convert.ToSByte(p_nyarigumi);
            this.muszakiErv = p_muszakiErv;
            this.biztosErv = p_biztosErv;
            this.evjarat = p_evjarat;
        }

    }
}
