using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.ViewInterfaces
{
    interface IRegForm
    {
        string vezetekNev { get; }
        string keresztnev { get; }
        string varos { get; }
        string utcaHsz { get; }
        string telefon { get; }
        string felhNev { get; }
        string jelsz { get; }
        string confirm { get; }

        string errorDB { set; }
        string errorVez { set; }
        string errorKer { set; }
        string errorVar { set; }
        string errorUtc { set; }
        string errorTel { set; }
        string errorFelh { set; }
        string errorJelsz { set; }
        string errorConf { set; }
        string errorButt { set; }

    }
}
