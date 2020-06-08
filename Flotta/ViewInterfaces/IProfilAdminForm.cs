using Flotta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.ViewInterfaces
{
    interface IProfilAdminForm
    {
        //BindingList<>
        string selectedFelh { get;  }

        BindingList<felhtabla> BindingList { set; }
        
        string errorDB { set; }
        string errorKapcsMent { set; }
        string errorTorles { set; }

        string comboboxFelt { set; }
        string aktAuto { get;}
        string aktAutoKI { set ; }
        string aktFelhKIIR { set; }
        felhtabla aktKijelolt { get; }
        
        List<felhtabla> felhasznalokListaja { set; get; }

        bool ascending { get; set; }
        string sortBy { get; set; }
        string search { get; }
        string searchCat { get; }
    }
}
