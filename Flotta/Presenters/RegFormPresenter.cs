using Flotta.Models;
using Flotta.Properties;
using Flotta.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Flotta.Presenters
{
    class RegFormPresenter
    {
        private IRegForm view;
        private autokContext db = new autokContext();

        public RegFormPresenter(IRegForm param)
        {
            view = param;
            db = new autokContext();
        }

        private bool ConnectionExist() 
        {
            return db.Database.Exists();
        }
        /// <summary>
        /// Regisztrációs adatok ellenőrzése Bool-al tér vissza
        /// </summary>
        /// <returns></returns>
        public bool Authenticate()
        {
            if (!ConnectionExist())
            {
                view.errorDB = Resources.AdatHiba;
                return false;
            }
            else 
            {
                if (!CheckVezetekNev())
                {
                    return false;
                }
                view.errorVez = "";
                if (!CheckKeresztNev())
                {
                    return false;
                }
                view.errorKer = "";
                if (!CheckVaros())
                {
                    return false;
                }
                view.errorKer = "";
                if (!CheckUtca())
                {
                    return false;
                }
                view.errorUtc = "";
                if (!CheckTel())
                {
                    return false;
                }
                view.errorTel = "";
                if (!CheckFelh())
                {
                    return false;
                }
                view.errorFelh = "";
                if (!CheckJelsz())
                {
                    return false;
                }
                view.errorJelsz = view.errorConf="";

                return true;
            }
        }

        private bool CheckVezetekNev()
        {
            if (string.IsNullOrWhiteSpace(view.vezetekNev))
            {
                view.errorVez = "A vezetéknév megadása kötelező! ";
                return false;
            }
            
            if (view.vezetekNev.Length<3 || view.vezetekNev.Length>50)
            {
                view.errorVez = "A vezetéknév min. 3 és max. 50 karakter lehet. ";
                return false;   
            }
            return true;
        }

        private bool CheckKeresztNev()
        {
            if (string.IsNullOrWhiteSpace(view.keresztnev))
            {
                view.errorKer = "A keresztnév megadása kötelező! ";
                return false;
            }

            if (view.keresztnev.Length < 3 || view.keresztnev.Length > 50)
            {
                view.errorKer = "A keresztnév min. 3 és max. 50 karakter lehet. ";
                return false;
            }
            return true;
        }

        private bool CheckVaros()
        {
            if (view.varos.Length > 25)
            {
                view.errorVar = "A városnév max. 25 karakter hosszú lehet. ";
                return false;
            }
            return true;
        }

        private bool CheckUtca()
        {
            if (view.utcaHsz.Length>60)
            {
                view.errorUtc = "A cím nem lehet 60 karakternél hoszabb! ";
                return false;
            }
            return true;
        }

        private bool CheckTel()
        {
            if (view.telefon.Length>13)
            {
                view.errorTel = "A telefonszám nem lehet hosszabb 16 karakternél";
                return false;
            }
            return true;
        }

        private bool CheckFelh()
        {
            if (string.IsNullOrWhiteSpace(view.felhNev))
            {
                view.errorFelh = "A felhasználónév megadása kötelező! ";
                return false;
            }

            if (view.felhNev.Length<5 || view.felhNev.Length>30)
            {
                view.errorFelh = "A felhasználónév hossza nem megfelelő! (min. 5, max 30 karakter)";
            }

            var list = db.felhtabla.Select(x=>x.belepesNev);
            if (list.Contains(view.felhNev))
            {
                view.errorFelh = "A felhasználónév már foglalt, válassz másikat! ";
                return false;
            }

            return true;
        }

        private bool CheckJelsz()
        {
            if (string.IsNullOrWhiteSpace(view.jelsz))
            {
                view.errorJelsz = "A jelszó megadása kötelező! ";
                return false;
            }
            if (string.IsNullOrWhiteSpace(view.confirm))
            {
                view.errorConf = "A jelszó megadása kötelező! ";
                return false;
            }

            if (!view.jelsz.Equals(view.confirm))
            {
                view.errorConf = "Nem egyeznek a megadott jelszavak! ";
                return false;
            }

            if (view.felhNev.Equals(view.jelsz))
            {
                view.errorJelsz = "A felhasználónév és a jelszó nem lehet azonos! ";
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            Match match1 = hasNumber.Match(view.jelsz);
            if (!match1.Success)
            {
                view.errorJelsz = "A jelszónak legalább egy számot tartalmaznia kell! ";
                return false;
            }
            Match match2 = hasUpperChar.Match(view.jelsz);
            if (!match2.Success)
            {
                view.errorJelsz = "A jelszónak tartalmaznia kell min. egy nagybetűt! ";
                return false;
            }
            Match match3 = hasMinimum8Chars.Match(view.jelsz);
            if (!match3.Success)
            {
                view.errorJelsz = "A jelszó min. 8 karakter hosszú kell, hogy legyen! ";
                return false;
            }
            
            return true;
        }
        /// <summary>
        /// Adatbázisba való mentésért felel
        /// </summary>
        public void Insert()
        {
            felhtabla uj = new felhtabla
            (
                0,
                view.vezetekNev.ToUpper(),
                view.keresztnev.ToUpper(),
                view.varos,
                view.utcaHsz,
                view.telefon,
                view.felhNev,
                view.jelsz,
                false,
                false);
            db.felhtabla.Add(uj);
            db.SaveChanges();
        }
    }
}
