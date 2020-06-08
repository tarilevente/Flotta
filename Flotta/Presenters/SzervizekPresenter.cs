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
    class SzervizekPresenter
    {
 
        private ISzervizekForm view;
        private autokContext db = new autokContext();
        public List<String> rendszamListaPres = new List<String>();
      
        public SzervizekPresenter(ISzervizekForm param) 
        {
            view = param;
            db = new autokContext();
            getRendszamList();
            LoadDetails();
        }
        /// <summary>
        /// Adatok frissítéséért felel, függvényeket hív meg, melyek adatokat kérdeznek le az adatbázisból
        /// </summary>
        public void LoadDetails()
        {
                var lista = idopontLeirasListaGeneralas(view.selectedRendszam);
                getKivalasztottReGyaTiKm(view.selectedRendszam); 
                loadMuszBizt(view.selectedRendszam); 
                idopontLeirasListaGeneralas(view.selectedRendszam); 
                aktIdopontKiiratas(lista, view.aktIdopont); 
                comboboxFeltoltes(lista);
        }
        
        public void getKivalasztottReGyaTiKm(string selected){
            
                view.aktRendszam = db.autoktabla.Select(x => x.rendszam).FirstOrDefault(x=>x==selected);
                view.aktGyartmany = db.autoktabla.SingleOrDefault(x => x.rendszam == selected).gyartmany;
                view.aktTipus = db.autoktabla.SingleOrDefault(x=>x.rendszam==selected).tipus;
                view.aktKm = db.autoktabla.SingleOrDefault(x=>x.rendszam==selected).km.ToString();
        }

        private bool ConnectionExists()
        {
            return db.Database.Exists();
        }

        public void getRendszamList()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessageDB = Resources.DBError;
                view.rendszamLista = null;
            }
            else
            {
                rendszamListaPres = db.autoktabla
                    .Select(x => x.rendszam)
                    .ToList();
                 view.rendszamLista=rendszamListaPres;

                rendszamListaPres = db.szervizkonyvtabla
                    .Select(x => x.rendszamHOZ)
                    .ToList();
            }
        }

        public void loadMuszBizt(string selected)
        {
            if (selected == "")
            {
                view.ErrorMessageDB = Resources.IndexIsmeretlen;
            }
            else
            {
                view.aktMuszaki = db.muszakiallapottabla.SingleOrDefault(x => x.rendszamHOZ == selected).muszakiErv.ToString("yyyy-MM-dd");
                view.aktBizt = db.muszakiallapottabla.SingleOrDefault(x => x.rendszamHOZ == selected).biztosErv.ToString("yyyy-MM-dd");
            }
        }
        /// <summary>
        /// A szervizek időpontja és a hozzá tartozó leírás key-value pair listában tárolódik, itt fog feltöltődni a lista
        /// </summary>
        /// <param name="selectedRendszam"></param>
        /// <returns></returns>
        public List<KeyValuePair<DateTime, string>> idopontLeirasListaGeneralas(string selectedRendszam)
        {
            //adott rendszám szervizeit KeyValuePair listába helyezi(ordered!)
            if (!ConnectionExists())
            {
                view.ErrorMessageDB = Resources.DBError;
                return null;
            }
            else if (selectedRendszam == null)
            {
                view.ErrorMessageDB = Resources.IsmeretlenHibaPresenter; return null;
            }
            else {
                List<szervizkonyvtabla> lista = new List<szervizkonyvtabla>();
                lista = db.szervizkonyvtabla.Select(x => x).ToList();
                var listaIpLeir = new List<KeyValuePair<DateTime, string>>();

                foreach (szervizkonyvtabla sz in lista)
                {
                    if (sz.rendszamHOZ.Contains(selectedRendszam))
                    {
                        listaIpLeir.Add(new KeyValuePair<DateTime, String>(sz.idopont, sz.leiras));
                    }
                }
                listaIpLeir = listaIpLeir.OrderBy(z => z.Key).ToList();

                return listaIpLeir;
            }
        }
        
        public void aktIdopontKiiratas(List<KeyValuePair<DateTime, string>> lista, string aktIdopont)
        {
            //kiíratja az akt időpontot + leírást, hogy először lefusson
            if (!ConnectionExists())
            {
                view.ErrorMessageDB = Resources.DBError;
            }
          
            else
            {
                if (lista.Count < 1)
                {
                    view.aktIdopont = "---- -- --";
                }
                else
                {
                    string idopont = lista.Min(k => k.Key).ToString("yyyy-MM-dd");
                    string leiras = "";
                    foreach (var item in lista)
                    {
                        if (item.Key.ToString("yyyy-MM-dd").Contains(aktIdopont))
                        {
                            idopont = item.Key.ToString("yyyy-MM-dd");
                            leiras = item.Value + Environment.NewLine;
                        }
                    }
                    view.aktIdopont = idopont;
                    view.aktLeiras = leiras;
                }
            }
        }

        public void LoadLeiras() //ez azért van külön, hogy a view meg tudja hívni paraméterek nélkül 
        {
            if (view.selectedRendszam==null)
            {
                view.ErrorMessageDB = Resources.IsmeretlenHibaPresenter;
                view.showHide = false;
            }
            else {
                var lista = idopontLeirasListaGeneralas(view.selectedRendszam);
                loadLeiras(lista, view.aktIdopont);
            }
        }
        /// <summary>
        /// leírás betöltése
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="aktIdopont"></param>
        public void loadLeiras(List<KeyValuePair<DateTime, string>> lista, string aktIdopont)
        {
            //Leírást frissíti 
            if (aktIdopont == null)
            {
                view.ErrorMessageDB = Resources.IsmeretlenHibaPresenter;
                view.showHide = false;
            }
            else
            {
                string leiras = "";

                foreach (var item in lista)
                {
                    if (item.Key.ToString("yyyy-MM-dd").Contains(aktIdopont))
                    {
                        leiras += item.Value + Environment.NewLine + Environment.NewLine;
                    }
                }
                view.aktLeiras = leiras;
            }
        }
        /// <summary>
        /// comboboxba tölti a szervizelés időpontjait
        /// </summary>
        /// <param name="lista"></param>
        public void comboboxFeltoltes(List<KeyValuePair<DateTime, string>> lista)
        {
            if (lista==null)
            {
                view.ErrorMessageDB = Resources.IsmeretlenHibaPresenter;
            }
            else
            {
                var lista2 = new List<String>();
                foreach (var item in lista)
                {
                    lista2.Add(item.Key.ToString("yyyy-MM-dd"));
                }
                var lista3 = new List<String>();
                foreach (var item in lista2)
                {
                    if (!lista3.Contains(item))
                    {
                        lista3.Add(item);
                    }
                }
                foreach (var item in lista3)
                {
                    view.comboBoxFelt = item;
                }
                if (lista3.Count < 2)
                {
                    view.showHide = false;
                } //tableLayoutPanelNav eltűnik, ha 1 elem van
                else
                {
                    view.showHide = true;
                }
            }
        }
        /// <summary>
        /// Aktuális szerviz id-jét kérdezi le
        /// </summary>
        /// <param name="rendszam"></param>
        /// <param name="idopont"></param>
        /// <returns></returns>
        public int aktId(string rendszam, string idopont)
        {
            int id = -1;

            var lista = db.szervizkonyvtabla.Where(x => x.rendszamHOZ.Contains(rendszam)).ToList();
            foreach (var item in lista)
            {
                if (item.idopont.ToString("yyyy-MM-dd").Contains(idopont))
                {
                    id=item.idszervizkonyv;
                }
            }
            return id;
        }

        public void Save()
        {
            db.SaveChanges();
        }
        /// <summary>
        /// Törlés az adatbázisból
        /// </summary>
        public void AktTorl()
        {
            int id=aktId(view.selectedRendszam,view.aktIdopont);
            szervizkonyvtabla sz = db.szervizkonyvtabla.SingleOrDefault(x=>x.idszervizkonyv==id);
            db.szervizkonyvtabla.Remove(sz);
            Save();
        }
    }
}
