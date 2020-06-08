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
    class GepjarmuvekAdminPresenter
    {
        private IGepjarmuvekAdminForm view;
        private autokContext db = new autokContext();
        public List<String> rendszamLista = new List<String>();
        private List<autoktabla> autokTabla = new List<autoktabla>();
        private List<muszakiallapottabla> muszakiTabla = new List<muszakiallapottabla>();
        private List<felhtabla> felhTabla = new List<felhtabla>();

        public GepjarmuvekAdminPresenter(IGepjarmuvekAdminForm param)
        {
            view = param;
            getRendszamList();
            Load();
        }

        private bool ConnectionExists()
        {
            return db.Database.Exists();
        }
        /// <summary>
        /// Az adatbázis rendszámait listázza List<string> listába, mely megjelenik a listboxban a view-n
        /// </summary>
        public void getRendszamList()
        {
            if (!ConnectionExists())
            {
                view.errorDB = Resources.DBError;
                view.rendszamLista = null;
            }
            else
            {
                rendszamLista = db.autoktabla
                    .Select(x => x.rendszam)
                    .ToList();
                if (rendszamLista.Count < 1)
                {
                    view.errorDB = "Nincs az adatbázisban autó. ";
                    view.rendszamLista = null;
                }
                else
                {
                    view.rendszamLista = rendszamLista;
                }
            }
        }

        /// <summary>
        ///A rendszámok listáján kívül minden adatot megjelenít, az adatokat lekérdező függvényeket hívja meg.
        /// </summary>
        public void Load()
        {
            KiirAktAutoTabla();
            KiirMuszakiTabla();
            kiirSofor();
        }

        public void KiirAktAutoTabla()
        {
            if (String.IsNullOrEmpty(view.selectedRendszam))
            {
                view.errorDB = "Nincs autó a listában. ";
            }
            else
            {
                string rendsz = view.selectedRendszam;
                autokTabla = db.autoktabla.ToList();
                var a = autokTabla.SingleOrDefault(x=>x.rendszam.Equals(rendsz));
                        view.rendszam = a.rendszam;
                        view.alvaz = a.alvazszam;
                        view.gyartmany = a.gyartmany;
                        view.tipus = a.tipus;
                        view.km = a.km.ToString();
                        view.autoR = Convert.ToBoolean(a.autoradio);
                        view.vont = Convert.ToBoolean(a.vontatokotel);
                        view.bikak = Convert.ToBoolean(a.bikakabel);
                        view.mentod = Convert.ToBoolean(a.mentodoboz);
            }
        }

        public void KiirMuszakiTabla()
        {
            if (view.selectedRendszam.Length < 1)
            {
                view.errorDB = "Nincs autó a listában. ";
            }
            else
            {
                string rendsz = view.selectedRendszam;
                muszakiTabla = db.muszakiallapottabla.ToList();
                var m = muszakiTabla.SingleOrDefault(x=>x.rendszamHOZ.Equals(rendsz));
                        view.mMegyei = Convert.ToBoolean(m.matricaMegyei);
                        view.mOrszagos = Convert.ToBoolean(m.matricaOrszagos);
                        view.teligumi = Convert.ToBoolean(m.teligumi);
                        view.nyarigumi = Convert.ToBoolean(m.nyarigumi);
                        view.muszaki = m.muszakiErv;
                        view.bizt = m.biztosErv;
                        view.evjarat = m.evjarat.ToString("yyyy-MM-dd");
            }
        }
        
        public void kiirSofor()
        {
            if (view.selectedRendszam.Length < 1)
            {
                view.errorDB = "Nincs autó a listában. ";
            }
            else
            {
                string rend = view.selectedRendszam;
                int id = -1;
                var talalat = db.soforautojatabla.SingleOrDefault(x => x.rendszam.Equals(rend));
                if (talalat==null)
                {
                    view.sofor = "Ehhez az autóhoz nem tartozik sofőr. ";
                }
                else
                {
                    var felh = db.felhtabla.SingleOrDefault(x => x.idFelh == talalat.idfelh);
                    view.sofor = felh.vezetekNev.ToUpper() + " " + felh.keresztNev.ToUpper();
                }
            }
        }
        /// <summary>
        /// A bevitel ellenőrzés függvényeit hívja meg. BOOL metódus
        /// </summary>
        /// <returns></returns>
        public bool Check()
        {
            if (!ConnectionExists())
            {
                view.errorDB = Resources.DBError; return false;
            }
            else
            {

                if (!RendszamCheckOK(view.rendszam))
                {
                    view.errorRendszam = "Hibás a rendszám formátuma, NKK-111!";
                    return false;
                }

                if (!AlvazszamCheckOK(view.alvaz))
                {
                    view.errorAlv = "Hibás az alvázszám formátuma. 17 karakter, betű és szám!";
                    return false;
                }
                if (!KmCheckOK(view.km))
                {
                    view.errorKm = "A km nem lehet hosszabb 7 karakternél, és csak számot tartalmazhat!";
                    return false;
                }

                if (!GyartmanyCheckOk(view.gyartmany))
                {
                    view.errorGyart = "Ilyen gyártmány nincs, igyekezz a pontos betűzésre!";
                    return false;
                }

                if (!TipusCheckOK(view.tipus))
                {
                    view.errorTip = "A típus nem lehet 20 karakternél hosszabb!";
                }

                if (!MuszakiCheckOK(view.muszaki))
                {
                    return false;
                }

                if (!BiztositasCheckOK(view.bizt))
                {
                    return false;
                }

                if (!ModositAutokTablaCheck())
                {
                    return false;
                }

                if (!ModositMuszakiAllTablCheck())
                {
                    return false;
                }


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

        private bool AlvazszamCheckOK(string alvazszam)
        {
            if (alvazszam.Length != 17)
            {
                view.errorAlv = "Az alvázszám 17 karakterből áll.";
                return false;
            }
            bool vanSzam = false;
            bool vanBetu = false;
            foreach (char c in alvazszam)
            {
                if (char.IsDigit(c))
                {
                    vanSzam = true;
                }
                else
                {
                    vanBetu = true;
                }
            }
            if (!vanSzam)
            {
                view.errorAlv = "Az alvázszám tartalmaz számot!";
                return false;
            }

            if (!vanBetu)
            {
                view.errorAlv = "Az alvázszám tartalmaz betűt!";
                return false;
            }
            return true;
        }

        private bool KmCheckOK(string km)
        {
            if (km.Count() > 7)
            {
                return false;
            }
            bool vanbenne = false;
            foreach (var c in km)
            {
                if (!char.IsDigit(c))
                {
                    vanbenne = true;
                }
            }
            if (vanbenne)
            {
                return false;
            }
            return true;
        }

        private bool GyartmanyCheckOk(string gyart)
        {
            if (gyart.Length > 15)
            {
                return false;
            }
            String osszes = "Buick?Cadillac?ChevroletChrysler?Dodge?Ford?GEO?Mercedes?GMC?Jeep?Lincoln?Lingenfelter?Mercury?Saleen?Shelby?" +
                "Tesla?Acura?Daihatsu?Dome?Honda?Infiniti?Isuzu?Lexus?Mazda?Mitsubishi?Nissan?Subaru?Suzuki?Toyota?Audi?BMW?Gumpert?Isdera?" +
                "Mercedes-Benz?Opel?Porsche?Smart?Volkswagen?VW?Alfa Romeo?Alfaromeo?Ferrari?Fiat?Lancia?Lamborghini?Maserati?Pagani?Pininfarina?" +
                "Qvale?Aston Martin?Bentley?Caterham Cars?Caparo?Jaguar?Jensen?Land Rover?Lightning?Lister?Lotus?Mini?MorganRolls-Royce?TVR?Vauxhall?" +
                "Bugatti?Citroen?Heuliez?Mega?Peugeot?Renault?Hyundai?Kia?Oullim?SsangYong?Koenigsegg?Volvo?AvtoVAZ?Izs?Lada?UAZ?Škoda?Innotech" +
                "?MTX?TatraARO?tatra?aro?Dacia?SEAT?Hindustan?Mahindra?Maruti Suzuki?maruti?suzuki?San?Tata?Force Motors?Beijing Jeep?jeep?Hongqi?" +
                "Holden?Proton?Bufori?Tofas?ZAZ?BRIXXON?Solo?Locus";
            gyart = gyart.ToUpper();
            string[] split = osszes.Split('?');
            List<string> osszesLista = new List<string>();

            for (int i = 0; i < split.Length; i++)
            {
                split[i] = split[i].ToUpper();
                osszesLista.Add(split[i]);
            }

            if (!osszesLista.Contains(gyart))
            {
                return false;
            }
            return true;
        }

        private bool TipusCheckOK(string tip)
        {
            if (tip.Length > 20)
            {
                return false;
            }
            return true;
        }

        private bool MuszakiCheckOK(DateTime aktM)
        {
            DateTime now = DateTime.Now;
            int has = DateTime.Compare(now.AddYears(3), aktM); 
            int has2 = DateTime.Compare(now, aktM);
            if (has2>0)
            {
                view.errorMuszaki = "Ez az időpont már elmúlt.  ";
                return false;
            }
            if (has < 0)
            {
                view.errorMuszaki = "max. 3 évre előre lehet rögzíteni! ";
                return false;
            }
            return true;
        }

        private bool BiztositasCheckOK(DateTime aktB)
        {
            DateTime now = DateTime.Now;
            int has = DateTime.Compare(now.AddYears(1), aktB);
            int has2 = DateTime.Compare(now, aktB);
            if (has2 > 0)
            {
                view.errorBizt = "Ez az időpont már elmúlt.  ";
                return false;
            }
            if (has < 0)
            {
                view.errorBizt = "A biztosítást max. egy évre adják! ";
                return false;
            }
            return true;
        }
        /// <summary>
        /// Az adatok módosításáért felel, Check-eket követően hívódik meg.
        /// </summary>
        public void Modosit()
        {
            //autóktábla update
            autoktabla regi = db.autoktabla.SingleOrDefault(x => x.rendszam.Contains(view.selectedRendszam));
            autoktabla uj = new autoktabla(
                view.rendszam,
                view.alvaz,
                Convert.ToInt32(view.km),
                view.autoR,
                view.vont,
                view.bikak,
                view.mentod,
                view.gyartmany,
                view.tipus);
            if (uj != null)
            {
                db.Entry(regi).CurrentValues.SetValues(uj);
            }

            //műszakiállapottábla update
            muszakiallapottabla regiM = db.muszakiallapottabla.SingleOrDefault(x => x.rendszamHOZ.Contains(view.selectedRendszam));
            DateTime evjarat = regiM.evjarat;
            int id = regiM.idmuszakiAllapot;
            muszakiallapottabla ujM = new muszakiallapottabla(
                id,
                view.rendszam,
                view.mMegyei,
                view.mOrszagos,
                view.teligumi,
                view.nyarigumi,
                view.muszaki,
                view.bizt,
                evjarat);
            if (uj != null)
            {
                db.Entry(regiM).CurrentValues.SetValues(ujM);
            }
            Save();
        }
        
        /// <summary>
        /// Nem formai Check, hanem azt vizsgálja, hogy az adatbázis ne legyen redundáns
        /// </summary>
        /// <returns></returns>
        private bool ModositAutokTablaCheck()
        {
            //Ha módosul a rendszám, van-e már ilyen?
            string selRdsz = view.selectedRendszam;
            string aktRdsz = view.rendszam;

            var list = db.autoktabla.Select(x => x.rendszam).ToList();
            if (selRdsz != aktRdsz)
            {
                if (list.Contains(aktRdsz))
                {
                    view.errorRendszam = "Ez az autó már létezik az adatbázisban. Kattints rá a listában, ha módosítani szeretnéd.";
                    return false;
                }
            }

            //Alvázszám létezik-e már az adatbázisban?
            var alvList = db.autoktabla.Select(x => x.alvazszam).ToList();
            var tabla = db.autoktabla.ToList();

            string aktAlv = tabla.Find(x=>x.rendszam.Equals(selRdsz)).alvazszam;
            string alvMod = view.alvaz;
            if (!aktAlv.Contains(alvMod))
            {
                foreach (var item in alvList)
                {
                    if (item.Contains(alvMod))
                    {
                        view.errorAlv = "Az alvázszám már létezik az adatbázisban.";
                        return false;
                    }
                }
            }
            
            //kevesebb km nem lehet!
            int aktKm = Convert.ToInt32(view.km);
            var regisztraltKm = tabla.SingleOrDefault(x => x.rendszam.Equals(selRdsz)).km;
                    if (aktKm < regisztraltKm)
                    {
                        view.errorKm = "Nem adhatsz meg kevesebb km-t az előzőnél: " + regisztraltKm + " km";
                        return false;
                    }
            return true;
        }
        
        private bool ModositMuszakiAllTablCheck()
        {
            //ha országost kipipálják, akkor a megyeit is ki kell pipálni.
            bool orsz = view.mOrszagos;
            if (orsz == true)
            {
                if (view.mMegyei == false)
                {
                    view.errorMegyei = "Az országos matricával megyén belül is utazni lehet, pipáld ki!";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
 
        private void Save()
        {
            db.SaveChanges();
        }
        /// <summary>
        /// Végleges törlés előtti ellenőrzés
        /// </summary>
        /// <returns></returns>
        public bool Torol()
        {
            if (CheckTorol())
            {
                Delete();
                return true;
            }
            return false;
        }

        public bool CheckTorol()
        {
            string torolniAuto = view.selectedRendszam;
            //Ha sofőr tartozik az autóhoz, akkor először a kapcsolatot kell törölnie a felhasználónak.
            //A törlési szándék megerősítését szolgálja.
            var talalat = db.soforautojatabla.Any(x => x.rendszam.Equals(torolniAuto));
            if (talalat)
            {
                view.errorTorol = "Az autó nem törölhető, először a sofőrrel való kapcsolatot törölni kell. (Profilkezelés)";
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// eltávolítja az autót az autóktáblából, a szervizek táblából és a műszaki táblából
        /// </summary>
        private void Delete()
        {
            string rendsz = view.selectedRendszam;

            List<szervizkonyvtabla> listSz = db.szervizkonyvtabla.Where(x=>x.rendszamHOZ.Contains(rendsz)).ToList();
            foreach (var item in listSz)
            {
                db.szervizkonyvtabla.Remove(item);
            }

            List<muszakiallapottabla> listM = db.muszakiallapottabla.Where(x => x.rendszamHOZ.Contains(rendsz)).ToList();
            foreach (var item in listM)
            {
                db.muszakiallapottabla.Remove(item);
            }

            autoktabla a = db.autoktabla.SingleOrDefault(x=>x.rendszam.Contains(rendsz));
            db.autoktabla.Remove(a);

            db.SaveChanges();
            Load();
        }
    }
}
