using Flotta.Models;
using Flotta.Properties;
using Flotta.ViewInterfaces;
using Flotta.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Presenters
{
    class LoginPresenter 
    {
        private ILoginForm view; 
        private autokContext db=new autokContext();
        public bool toLogin2Form;

        public LoginPresenter(ILoginForm param) 
        {
            view = param; 
        }

        private bool ConnectionExist() 
        {
            return db.Database.Exists(); 
        }
        /// <summary>
        /// Hitelesítés. Amennyiben sikeres, loginSuccess=true-ra állítja => beléphet
        /// </summary>
        public void Authenticate() 
        {
            if (!ConnectionExist())
            {
                view.ErrorMessageDB = Resources.DBError;
            }
            else 
            {
                if (!string.IsNullOrWhiteSpace(view.UserName))
                {
                    if (!view.UserName.Equals("Felhasználónév"))
                    {
                        var user = db.felhtabla
                        .SingleOrDefault(
                            x => x.belepesNev.Equals(view.UserName));
                        if (user != null)
                        {
                            bool adminE = false;
                            var list = db.felhtabla.ToList();
                            foreach (var f in list)
                            {
                                if (f.belepesNev.Equals(view.UserName))
                                {
                                    if (Convert.ToBoolean(f.adminE))
                                    {
                                        adminE = true;
                                    }
                                    else break;
                                }
                            }
                            if (adminE)
                            {
                                toLogin2Form = true;
                            }
                            else
                            {
                                toLogin2Form = false;
                                view.ErrorMessageLogin = "Ezzel a felhasználói fiókkal nincs jogosultságod az adatok megtekintésére. ";
                            }
                        }
                        else
                        {
                            view.ErrorMessageLogin = Resources.FelhasznaloHiba;
                            toLogin2Form = false;
                        }
                    }
                    else
                    {
                        view.ErrorMessageLogin = "Meg kell adnod egy felhasználót a belépéshez! ";
                        toLogin2Form = false;
                    }
                }
                else
                {
                    view.ErrorMessageLogin = "Meg kell adnod egy felhasználót a belépéshez! ";
                    toLogin2Form = false;
                }
               
            }
        }

        public string GetFelhNev()
        {
            return "nev";
        }

    }
}
