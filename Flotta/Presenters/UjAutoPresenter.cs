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
    public class UjAutoPresenter
    {
        private IUjAutoForm view;
        private autokContext db = new autokContext();
        //public const string errorKmNegativ = "A km nem lehet negatív!";
        public UjAutoPresenter()
        {

        }
        public UjAutoPresenter(IUjAutoForm param)
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
                view.errorDB = Resources.DBError; return false;
            }
            else {

                if (!RendszamCheckOK(view.rendszam))
                {
                    return false;
                }
                view.errorRendsz = "";
                if (!AlvazszamCheckOK(view.alvazszam))
                {
                    return false;
                }
                view.errorAlv = "";
                if (!KmCheckOK(view.km))
                {
                    view.errorKm = "A km nem lehet hosszabb 7 karakternél, és csak számot tartalmazhat!";
                    return false;
                }
                view.errorKm = "";
                if (!EvjaratOK(view.evjarat))
                {
                    view.errorEvjarat = "Csak a múltban gyárthatták le az autót. ";
                    return false;
                }
                view.errorEvjarat = "";
                if (!GyartmanyCheckOk(view.gyartmany))
                {
                    return false;
                }
                view.errorGyart = "";
                if (!TipusCheckOK(view.tipus))
                {
                    return false;
                }
                view.errorTipus = "";
                return true;
            }
        }

        private bool RendszamCheckOK(string rendszam)
            {
            //formai követelmények ellenőrzése
            if (rendszam.Length != 7)
            {
                view.errorRendsz = "A rendszám 7 karakterből áll.";
                return false;
            }
            if (char.IsDigit(rendszam[0]))
            {
                view.errorRendsz = "Hibás a rendszám formátuma! ABC-123";
                return false;
            }
                if (char.IsDigit(rendszam[1]))
            {
                view.errorRendsz = "Hibás a rendszám formátuma! ABC-123";
                return false;
            }
            if (char.IsDigit(rendszam[2]))
            {
                view.errorRendsz = "Hibás a rendszám formátuma! ABC-123";
                return false;
            }

            if (rendszam[3] != '-')
            {
                view.errorRendsz = "Hibás a rendszám formátuma! ABC-123";
                return false;
            }

            if (char.IsLetter(rendszam[4]))
            {
                view.errorRendsz = "Hibás a rendszám formátuma! ABC-123";
                return false;
            }
            if (char.IsLetter(rendszam[5]))
            {
                view.errorRendsz = "Hibás a rendszám formátuma! ABC-123";
                return false;
            }
            if (char.IsLetter(rendszam[6]))
            {
                view.errorRendsz = "Hibás a rendszám formátuma! ABC-123";
                return false;
            }

            //ellenőrzés, hogy a rendszám létezik-e már az adatbázisban.
            var list = db.autoktabla.Select(x=> x.rendszam).ToList(); ;
                if (list.Contains(rendszam))
                {
                    view.errorRendsz = "A rendszám már benne van az adatbázisban! ";
                    return false;
                }

                return true;
            }

            private bool AlvazszamCheckOK(string alvazszam)
            {
                if (string.IsNullOrWhiteSpace(alvazszam))
                {
                    view.errorAlv = "Az alvázszám megadása kötelező! ";
                    return false;
                }
                if (alvazszam.Length!=17)
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
                    view.errorAlv = "Az alvázszámnak tartalmaznia kell legalább egy számot!";
                    return false;
                }

                if (!vanBetu)
                {
                    view.errorAlv = "Az alvázszámnak tartalmaznia kell legalább egy betűt!";
                    return false;
                }

                List<string> meglevok = db.autoktabla.Select(x => x.alvazszam).ToList();
                if (meglevok.Contains(alvazszam))
                {
                   view.errorAlv = "Ez az alvázszám már létezik az adatbázisban! ";
                   return false;
                }

                return true;
            }

            private bool KmCheckOK(string km)
            {
                if (km.Count() < 1)
                {
                    return false;
                }
                if (km.Count()>7)
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
                if (string.IsNullOrWhiteSpace(gyart))
                {
                    view.errorGyart = "A gyártmány megadása kötelező! ";
                    return false;
                }
                if (gyart.Length>15)
                {
                    view.errorGyart = "Ilyen gyártmány nincs!";
                    return false;
                }
                String osszes = "Buick?Cadillac?ChevroletChrysler?Dodge?Ford?GEO?Mercedes?GMC?Jeep?Lincoln?Lingenfelter?Mercury?" +
                "Saleen?Shelby?Tesla?Acura?Daihatsu?Dome?Honda?Infiniti?Isuzu?Lexus?Mazda?Mitsubishi?Nissan?Subaru?Suzuki?Toyota?" +
                "Audi?BMW?Gumpert?Isdera?Mercedes-Benz?Opel?Porsche?Smart?Volkswagen?VW?Alfa Romeo?Alfaromeo?Ferrari?Fiat?Lancia?" +
                "Lamborghini?Maserati?Pagani?Pininfarina?Qvale?Aston Martin?Bentley?Caterham Cars?Caparo?Jaguar?Jensen?Land Rover?Lightning?Lister?" +
                "Lotus?Mini?MorganRolls-Royce?TVR?Vauxhall?Bugatti?Citroen?Heuliez?Mega?Peugeot?Renault?Hyundai?Kia?Oullim?SsangYong?Koenigsegg?" +
                "Volvo?AvtoVAZ?Izs?Lada?UAZ?Škoda?Innotech?MTX?TatraARO?tatra?aro?Dacia?SEAT?Hindustan?Mahindra?Maruti Suzuki?maruti?suzuki?San?T" +
                "ata?Force Motors?Beijing Jeep?jeep?Hongqi?Holden?Proton?Bufori?Tofas?ZAZ?BRIXXON?Solo?Locus";
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
                    view.errorGyart = "Ilyen gyártmány nincs, igyekezz a pontos betűzésre!";
                    return false;
                }
                return true;
            }

            private bool TipusCheckOK(string tip)
            {
                if (string.IsNullOrEmpty(tip))
                {
                    view.errorTipus = "A típus megadása kötelező! ";
                    return false;
                }
                if (tip.Length>20)
                {
                    view.errorTipus = "A típus nem lehet 20 karakternél hosszabb!";
                    return false;
                }
                return true;
            }
            
            private bool EvjaratOK(DateTime evj)
            {
                DateTime now = DateTime.Now;
                int has = DateTime.Compare(now, evj);
                if (has < 0)
                {
                    return false;
                }
                return true;
            }

        public void test()
        {
            int km = -100;
            if (km<0)
            {
                throw new ArgumentOutOfRangeException("UjAutokm",km,"a km nem lehet negatív");
            }
        }

        public void TestEvjaratOk(DateTime evj)
        {
            DateTime now = DateTime.Now;
            int has = DateTime.Compare(now, evj);
            if (has < 0)
            {
                throw new ArgumentOutOfRangeException("UjAutoEvjaratCheck_JövőbeliDátum",evj,"Az évjárat nem lehet jövőbeli dátum. ");
            }
        }


        public void Vegrehajt()
        {
            string rendszam = view.rendszam.ToUpper();
            string alvaz = view.alvazszam;
            string gyart = view.gyartmany;
            string tip = view.tipus;
            int km = Convert.ToInt32(view.km);
            
            bool radio = view.radio;
            bool vontato = view.vontato;
            bool bika = view.bika;
            bool mento = view.mento;

            DateTime evjarat = view.evjarat;

            //adatbázisba feltölteni - autoktabla
            autoktabla uj = new autoktabla(
                rendszam,
                alvaz,
                km,
                radio,
                vontato,
                bika,
                mento,
                gyart,
                tip
                );
            db.autoktabla.Add(uj);


            //adatbázisba feltölteni - muszakiallapottabla
            DateTime now = System.DateTime.Now;
            muszakiallapottabla ujM = new muszakiallapottabla(
                0,
                rendszam,
                false,
                false,
                false,
                true,
                now.AddMonths(2),
                now.AddMonths(2),
                evjarat
                );

            db.muszakiallapottabla.Add(ujM);
            db.SaveChanges();
        }

    }
}
