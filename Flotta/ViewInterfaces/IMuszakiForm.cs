using Flotta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.ViewInterfaces
{
    interface IMuszakiForm
    {
        BindingList<muszakiallapottabla> bindingList { set; }

        string sofNev { set; }
        string sofTel { set;  }

        muszakiallapottabla selectedMusz { get; }

        string errorDB { set; }
        string errorKeres { set; }

        bool ascending { get; set; }
        string search { get; }
        
    }
}
