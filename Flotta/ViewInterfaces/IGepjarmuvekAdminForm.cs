using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.ViewInterfaces
{
    interface IGepjarmuvekAdminForm
    {
        List<string> rendszamLista { set; }
        string selectedRendszam { get; }

        string rendszam { get; set; }
        string gyartmany { get; set; }
        string tipus { get; set; }
        string alvaz { get; set; }
        string km { get; set; }
        DateTime muszaki { get; set; }
        DateTime bizt { get; set; }
        string aktSofor { get; set; }
        string evjarat { get; set; }

        bool mMegyei { get; set; }
        bool mOrszagos { get; set; }
        bool autoR { get; set; }
        bool vont { get; set; }
        bool mentod { get; set; }
        bool bikak { get; set; }

        bool teligumi { get; set; }
        bool nyarigumi { get; set; }

        string errorDB { set;}
        string errorRendszam { set; }
        string errorGyart { set; }
        string errorTip { set; }
        string errorAlv { set; }
        string errorKm { set; }
        string errorMuszaki { set; }
        string errorBizt { set; }
        string errorSofor { set; }
    }
}
