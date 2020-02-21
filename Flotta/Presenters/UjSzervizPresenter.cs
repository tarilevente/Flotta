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
    class UjSzervizPresenter
    {
        private IUjSzerviz view;
        private autokContext db = new autokContext();
        public List<String> rendszamListaPres = new List<String>();

        public UjSzervizPresenter(IUjSzerviz param)
        {
            view = param;
        }

        private bool ConnectionExists()
        {
            return db.Database.Exists();
        }
        public bool Check()
        {
            if (!ConnectionExists())
            {
                view.errorDB = Resources.DBError;
                return false;
            }
            else
            {
                if (!RendszamCheckOK(view.rendszam))
                {
                    view.errorRendszam = "Hibás a rendszám formátuma, NKK-111";
                    return false;
                } //működik

                if (!VanIlyenRendszam(view.rendszam))
                {
                    return false;
                } //működik

                /*if (!IdopontCheck(view.idopont))
                {
                    view.errorLeiras = "false ág";
                    return false;
                }
                view.leiras = "true ág";*/

                return true;
            }
        }

        private bool RendszamCheckOK(string rendszam)
        {
            if (rendszam.Length != 7)
                return false;

            if (char.IsDigit(rendszam[0]))
                return false;
            if (char.IsDigit(rendszam[1]))
                return false;
            if (char.IsDigit(rendszam[2]))
                return false;

            if (rendszam[3] != '-')
                return false;

            if (char.IsLetter(rendszam[4]))
                return false;
            if (char.IsLetter(rendszam[5]))
                return false;
            if (char.IsLetter(rendszam[6]))
                return false;

            return true;

        }

        private bool VanIlyenRendszam(string rendszam)
        {
            if (!ConnectionExists())
            {
                view.errorDB = Resources.DBError;
                return false;
            }
            else
            {
                
                rendszamListaPres = db.autoktabla
                    .Select(x => x.rendszam)
                    .ToList();

                if (rendszamListaPres.Count<1)
                {
                    view.errorDB = "Nincs autó az adatbázisban!";
                    return false;
                }
                rendszam = rendszam.ToUpper();
                if (!rendszamListaPres.Contains(rendszam))
                {
                    view.errorRendszam = "Ilyen rendszám nincs az adatbázisban!";
                    return false;
                }
                
                return true;
            }
        }

        private bool IdopontCheck(DateTime ip)
        {
            DateTime now = DateTime.Now;
            if (now.CompareTo(ip)>7)
            {
                view.errorIdopont = "Egy hétnél előrébb nem rögzíthetsz!";
                return false;
            }
            view.leiras =now.CompareTo(ip).ToString();
            return true;
        }
    }
}
