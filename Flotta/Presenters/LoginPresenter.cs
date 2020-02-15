using Flotta.Models;
using Flotta.Properties;
using Flotta.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Presenters
{
    class LoginPresenter //hitelesít, conn-t vizsgál
    {
        private ILoginForm view; //view-al kölcsönösen példányosítják egymást
        private autokContext db=new autokContext();
        public bool loginSuccess;

        public LoginPresenter(ILoginForm param) //ki fogja példányosítani a presentert? -- Hát a view!
        {
            view = param; 
        }

        private bool ConnectionExist() //ellenőrzésre
        {
            return db.Database.Exists(); 
        }

        public void Authenticate() //hitelesítés. Ha jók a belépés adatok, akkor visszatér IGAZ-zal
        {
            if (!ConnectionExist())
            {
                view.ErrorMessage = Resources.AdatHiba;
            }
            else //ha van ab-kapcsolat:
            {
                var user = db.felhtabla //var user=db.felhtabla.SingleOrDefault(x=>x.belepesNev==view.UserName
                    .SingleOrDefault(
                         x => x.belepesNev==view.UserName 
                         && x.belepesJelszo==view.Password
                    ); //view-ról szedi ki a felh-jelszót, és összehasonlítja az ab-al.
                if (user != null)
                {
                    loginSuccess = true;
                }
                else
                {
                    view.ErrorMessage = Resources.BelepesHiba;
                }
            }

        }

    }
}
