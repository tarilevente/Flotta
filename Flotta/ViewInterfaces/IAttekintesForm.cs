using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.ViewInterfaces
{
    interface IAttekintesForm
    {
        string ErrorMessage { set; }
        string OsszAuto { set; }
        string OsszSofor { set; }
        string OsszTeli { set; }
        string OsszNyari { set; }
        string OsszRadio { set; }
        string OsszVont { set; }
        string OsszBika { set; }
        string OsszMento { set; }

    }
}
