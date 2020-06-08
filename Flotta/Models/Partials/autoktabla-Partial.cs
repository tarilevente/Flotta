using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Models
{
    public partial class autoktabla
    {
        public autoktabla(
            string p_rendszam, 
            string p_alvazszam, 
            int p_km, 
            bool p_autoradio, 
            bool p_vontatokotel, 
            bool p_bikakabel, 
            bool p_mentodoboz, 
            string p_gyartmany, 
            string p_tipus)
        {
            this.rendszam = p_rendszam;
            this.alvazszam = p_alvazszam;
            this.km = p_km;
            this.autoradio = Convert.ToSByte(p_autoradio);
            this.vontatokotel = Convert.ToSByte(p_vontatokotel);
            this.bikakabel = Convert.ToSByte(p_bikakabel);
            this.mentodoboz = Convert.ToSByte(p_mentodoboz);
            this.gyartmany = p_gyartmany;
            this.tipus = p_tipus;
        }




    }
}
