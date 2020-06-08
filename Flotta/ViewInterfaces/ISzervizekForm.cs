using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.ViewInterfaces
{
    interface ISzervizekForm
    {
        string ErrorMessageDB { set; }

        List<String> rendszamLista { set; }
        string selectedRendszam { get; }

        string aktRendszam { set; }
        string aktGyartmany { set; }
        string aktTipus { set; }
        string aktKm { set; }

        string aktMuszaki { set; }
        string aktBizt { set; }

        string aktLeiras { set; }
        string aktIdopont { get; set; }
        
        string comboBoxFelt { set; }

        bool showHide { get; set; }
    }
}
