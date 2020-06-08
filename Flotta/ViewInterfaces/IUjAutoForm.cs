using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.ViewInterfaces
{
    public interface IUjAutoForm
    {
        string rendszam { get; }
        string alvazszam { get; }
        string km { get; }
        string gyartmany { get; }
        string tipus { get; }
        bool radio { get; }
        bool vontato { get; }
        bool bika { get; }
        bool mento { get; }

        DateTime evjarat { get; }

        string errorRendsz { set; }
        string errorAlv { set; }
        string errorGyart { set; }
        string errorTipus { set; }
        string errorDB { set; }
        string errorKm { set; }
        string errorEvjarat { set; }
    }
}
