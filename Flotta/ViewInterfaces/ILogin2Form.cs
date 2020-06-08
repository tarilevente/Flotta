using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.ViewInterfaces
{
    interface ILogin2Form
    {

        string ErrorDB { set; }
        string ErrorBelepes { set; }
        string jelszo { get; }
        string GetFelhnev { get; }
    }
}
