using Flotta.Models;
using Flotta.Properties;
using Flotta.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Presenters
{
    class ProfilAdminPresenter
    {
        autokContext db = new autokContext();
        private IProfilAdminForm view;

        public ProfilAdminPresenter(IProfilAdminForm param)
        {
            view = param;
            ComboboxFeltolt();
        }

        public bool ConnectionExists()
        {
            return db.Database.Exists();
        }

        /// <summary>
        /// A bindingList-et feltölti a felhasználók adataival. A query bővíthető
        /// </summary>
        /// <returns></returns>
        public BindingList<felhtabla> GetBindingList()
        {
            if (ConnectionExists())
            {
                var query = db.felhtabla.OrderBy(x => x.idFelh).AsQueryable();
                return new BindingList<felhtabla>(query.ToList());
            }
            return null;
        }

        /// <summary>
        /// A bindingList frissítésének kezdeményezése
        /// </summary>
        public void LoadData()
        {
            ListaBetolt();
        }

        /// <summary>
        /// aktuális felhasználó módosult adatainak adatbázisba mentése
        /// </summary>
        /// <param name="f"></param>
        public void Update(felhtabla f)
        {
            var ezt = db.felhtabla.Find(f.idFelh);
            if (ezt != null)
            {
                db.Entry(ezt).CurrentValues.SetValues(f);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool Delete(felhtabla f)
        {
            bool torolheto = true;

            var talalat = db.soforautojatabla.Any(x=>x.idfelh==f.idFelh);
            if (talalat==true)
            {
                torolheto = false;
            }
            if (torolheto)
            {
                db.felhtabla.Remove(f);
                return true;
            }
            else
            {
                view.errorTorles = "Autója van, először vedd le a nevéről! ";
                return false;
            }
        }
        /// <summary>
        /// Azokat az autókat helyezi comboboxba, melyeknek nincsen sofőrje
        /// </summary>
        public void ComboboxFeltolt()
        {
            List<string> osszAuto = new List<string>();
            osszAuto = db.autoktabla.Select(x=>x.rendszam).ToList();
            var autoListaVansoforje = db.soforautojatabla.Select(x => x.rendszam).ToList();
            List<string> comboboxba = new List<string>();
            foreach (var a in osszAuto)
            {
                if (!autoListaVansoforje.Contains(a))
                {
                    view.comboboxFelt = a;
                }
            }
        }
        /// <summary>
        /// adott felhasználó id-jének lekérdezése
        /// </summary>
        /// <returns></returns>
        public int getKijeloltID()
        {
            if (view.aktKijelolt!=null)
            {
                return view.aktKijelolt.idFelh;
            }
            else
            {
                return 0;
            }
        }

        public void kiirTextBoxAktFelhNev()
        {
            try
            {
                int id = getKijeloltID();
                var felh= db.felhtabla.SingleOrDefault(x => x.idFelh.Equals(id));
                view.aktFelhKIIR = felh.vezetekNev + " " + felh.keresztNev;
            }
            catch(NullReferenceException)
            {
                view.errorDB = "Nincs felhasználó az adatbázisban. ";
            }
        }

        public void kiirTextbeRendszam()
        {
            try
            {
                var valasz = "Nincs autója";
                int id = getKijeloltID();
                var talalat = db.soforautojatabla.SingleOrDefault(x => x.idfelh.Equals(id));
                if (talalat!=null)
                {
                    valasz = talalat.rendszam;
                }
                view.aktAutoKI = valasz;
            }
            catch(NullReferenceException)
            {
                view.errorDB = "Nincs felhasználó az adatbázisban. ";
            }

        }
        /// <summary>
        /// Sofőr és autója közötti kapcsolat mentése a sofőrautója táblában
        /// </summary>
        public void MentKapcsolat()
        {
            //bool mehet = true;
            int felhid = getKijeloltID();
            var vanmar = db.soforautojatabla.Any(x=>x.idfelh.Equals(felhid));
            if (vanmar)
            {
                view.errorKapcsMent = "Egy sofőrnek egy autója lehet!";
            }
            else
            {
                //új bejegyzés a sofőrautója táblában
                try
                {
                    string rdsz = view.aktAuto;
                    soforautojatabla Ujst = new soforautojatabla(felhid, rdsz);
                    db.soforautojatabla.Add(Ujst);
                }
                catch (Exception e)
                {
                    
                }

                //a felhasználó soforE tulajdonságának átállítása
                felhtabla aktTul = view.aktKijelolt;
                felhtabla uj = new felhtabla(
                    aktTul.idFelh,
                    aktTul.vezetekNev,
                    aktTul.keresztNev,
                    aktTul.varos,
                    aktTul.utcaHsz,
                    aktTul.telefon,
                    aktTul.belepesNev,
                    aktTul.belepesJelszo,
                    !Convert.ToBoolean(aktTul.soforE),
                    Convert.ToBoolean(aktTul.adminE)
                    );
                
                if (aktTul!=null)
                {
                    db.Entry(aktTul).CurrentValues.SetValues(uj);
                }
            }
        }
        /// <summary>
        /// Sofőr és autója közötti kapcsolat törlése a sofőrautója táblából
        /// </summary>
        public void DeleteKapcs()
        {
            //törlés a soforautoja táblából
            bool torolveLett = false;
            int felhid = getKijeloltID();
            var sofAutTabl = db.soforautojatabla.ToList();
            foreach (var item in sofAutTabl)
            {
                if (item.idfelh == felhid)
                {
                    db.soforautojatabla.Remove(item);
                    torolveLett = true;
                }
            }

            //a felhasználó soforE tulajdonságának átállítása
            if (torolveLett)
            {
                var aktTul = db.felhtabla.Find(felhid);
                felhtabla uj = new felhtabla(
                    aktTul.idFelh,
                    aktTul.vezetekNev,
                    aktTul.keresztNev,
                    aktTul.varos,
                    aktTul.utcaHsz,
                    aktTul.telefon,
                    aktTul.belepesNev,
                    aktTul.belepesJelszo,
                    !Convert.ToBoolean(aktTul.soforE),
                    Convert.ToBoolean(aktTul.adminE)
                    );
                if (aktTul != null)
                {
                    db.Entry(aktTul).CurrentValues.SetValues(uj);
                }
            }
        }

        /// <summary>
        /// BindingList feltöltése, a megadott paraméterek alapján, a query kiterjesztésével.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="searchCat"></param>
        /// <param name="sortBy"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public BindingList<felhtabla> GetAllFelh(
         string search,
         string searchCat,
         string sortBy,
         bool ascending)
        {
            IQueryable<felhtabla> query = db.felhtabla.OrderBy(x => x.idFelh).AsQueryable();
            if (searchCat!="Válassz!")
            {
                switch (searchCat)
                {
                    default:
                        query = query.Where(x => x.vezetekNev.ToUpper().Contains(search));
                        break;
                    case "Vezetéknév":
                        query = query.Where(x => x.vezetekNev.ToUpper().Contains(search));
                        break;
                    case "Keresztnév":
                        query = query.Where(x => x.keresztNev.ToUpper().Contains(search));
                        break;
                    case "Város":
                        query = query.Where(x => x.varos.ToUpper().Contains(search));
                        break;
                    case "Utca, házszám":
                        query = query.Where(x => x.utcaHsz.ToUpper().Contains(search));
                        break;
                    case "Telefon":
                        query = query.Where(x => x.telefon.ToUpper().Contains(search));
                        break;
                    case "Felhasználónév":
                        query = query.Where(x => x.belepesNev.ToUpper().Contains(search));
                        break;
                    case "Jelszó":
                        query = query.Where(x => x.belepesJelszo.ToUpper().Contains(search));
                        break;
                }
            }
            
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.idFelh) : query.OrderByDescending(x => x.idFelh);
                        break;
                    case "vezetekNev":
                        query = ascending ? query.OrderBy(x => x.vezetekNev) : query.OrderByDescending(x => x.vezetekNev);
                        break;
                    case "keresztNev":
                        query = ascending ? query.OrderBy(x => x.keresztNev) : query.OrderByDescending(x => x.keresztNev);
                        break;
                    case "varos":
                        query = ascending ? query.OrderBy(x => x.varos) : query.OrderByDescending(x => x.varos);
                        break;
                    case "utcaHsz":
                        query = ascending ? query.OrderBy(x => x.utcaHsz) : query.OrderByDescending(x => x.utcaHsz);
                        break;
                    case "telefon":
                        query = ascending ? query.OrderBy(x => x.telefon) : query.OrderByDescending(x => x.telefon);
                        break;
                    case "belepesNev":
                        query = ascending ? query.OrderBy(x => x.belepesNev) : query.OrderByDescending(x => x.belepesNev);
                        break;
                    case "belepesJelszo":
                        query = ascending ? query.OrderBy(x => x.belepesJelszo) : query.OrderByDescending(x => x.belepesJelszo);
                        break;
                    case "soforE":
                        query = ascending ? query.OrderBy(x => x.soforE) : query.OrderByDescending(x => x.soforE);
                        break;
                    case "adminE":
                        query = ascending ? query.OrderBy(x => x.adminE) : query.OrderByDescending(x => x.adminE);
                        break;
                }
            }
            return new BindingList<felhtabla>(query.ToList());
        }

        /// <summary>
        /// Meghívja a felhasználói adatok frissítését végző metódust
        /// </summary>
        public void ListaBetolt()
        {
            try
            {
                    view.BindingList = GetAllFelh(
                        view.search,
                        view.searchCat,
                        view.sortBy,
                        view.ascending);

                    view.felhasznalokListaja = GetAllFelh(
                        view.search,
                        view.searchCat,
                        view.sortBy,
                        view.ascending).ToList();
            }
            catch (NullReferenceException)
            {
            }
        }
    }
}
