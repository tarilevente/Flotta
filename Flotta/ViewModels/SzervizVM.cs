using Flotta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.ViewModels
{

    public class SzervizVM
    {
        string rendszam;
        int felhId;

        private autokContext db;

        public SzervizVM(int felhId)
        {
            db = new autokContext();

            felhId = db.felhtabla.SingleOrDefault(x => x.idFelh == felhId).idFelh;
            rendszam = db.soforautojatabla.SingleOrDefault(x => x.idfelh == felhId).rendszam;
        }
    }
}
