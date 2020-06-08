using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Models
{
    public partial class soforautojatabla
    {
        public soforautojatabla()
        {

        }
        public soforautojatabla(int p_idFelh, string p_rendszam)
        {
            this.idfelh= p_idFelh;
            this.rendszam = p_rendszam;
        }


    }
}
