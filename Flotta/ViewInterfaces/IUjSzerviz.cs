using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.ViewInterfaces
{
    interface IUjSzerviz
    {
        string rendszam { get; }
        bool casco { get; }
        bool bizt { get; }
        DateTime idopont { get; }
        string leiras { get; set; }


        string errorRendszam {set;} //formátum
        string errorIdopont { set; } //ha jövőbeli (mostantól 1 hétre előre)
        string errorLeiras { set; } //ha üres
        string errorDB { set; }

    }
}
