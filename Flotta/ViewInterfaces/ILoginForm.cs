using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.ViewInterfaces
{
    interface ILoginForm
    {
        string ErrorMessageDB { set; }
        string ErrorMessageLogin { set; }
        string UserName { get; }
        string Password { get; }
    }
}
