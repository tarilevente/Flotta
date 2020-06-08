using Flotta.Models;
using Flotta.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Presenters
{
    class Login2Presenter
    {
        private autokContext db = new autokContext();
        ILogin2Form view;
        
        public bool loginSuccess;

        public Login2Presenter(ILogin2Form param)
        {
            view = param;
        }

        public bool ConnectionExists()
        {
            return db.Database.Exists();
        }

        public void Authenticate()
        {
            if (ConnectionExists())
            {
                if (!string.IsNullOrWhiteSpace(view.jelszo))
                {
                    if (!view.jelszo.Equals("Jelszó"))
                    {
                        string felhNev = view.GetFelhnev;
                        string DBJelszo = db.felhtabla.SingleOrDefault(x => x.belepesNev.Equals(felhNev)).belepesJelszo;
                        if (DBJelszo.Equals(view.jelszo))
                        {
                            loginSuccess = true;
                        }
                        else
                        {
                            view.ErrorBelepes = "A jelszó nem megfelelő! ";
                            view.ErrorBelepes = "A jelszó nem megfelelő! ";
                        }
                    }
                    else
                    {
                        view.ErrorBelepes = "A belépéshez jelszó megadása szükséges. ";
                    }
                }
                else
                {
                    view.ErrorBelepes = "A belépéshez jelszó megadása szükséges. ";
                    loginSuccess = false;
                }
            }
            else
            {
                view.ErrorDB = "Nincs kapcsolat";
                loginSuccess = false;
            }
        }
    }
}
