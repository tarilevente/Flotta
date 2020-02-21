﻿using Flotta.Models;
using Flotta.Properties;
using Flotta.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Presenters
{
    class UjAutoPresenter
    {
        private IUjAutoForm view;
        private autokContext db = new autokContext();


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
                    view.errorRendsz = "Hibás a rendszám formátuma, NKK-111!";
                    return false;
                }

                if (!AlvazszamCheckOK(view.alvazszam))
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
                    view.errorTipus = "A típus nem lehet 20 karakternél hosszabb!";
                }
               
                return true;
            }
        }

            private bool RendszamCheckOK(string rendszam)
            {
                if (rendszam.Length!=7)
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
                if (gyart.Length>15)
                {
                    return false;
                }
                String osszes = "Buick?Cadillac?ChevroletChrysler?Dodge?Ford?GEO?Mercedes?GMC?Jeep?Lincoln?Lingenfelter?Mercury?Saleen?Shelby?Tesla?Acura?Daihatsu?Dome?Honda?Infiniti?Isuzu?Lexus?Mazda?Mitsubishi?Nissan?Subaru?Suzuki?Toyota?Audi?BMW?Gumpert?Isdera?Mercedes-Benz?Opel?Porsche?Smart?Volkswagen?VW?Alfa Romeo?Alfaromeo?Ferrari?Fiat?Lancia?Lamborghini?Maserati?Pagani?Pininfarina?Qvale?Aston Martin?Bentley?Caterham Cars?Caparo?Jaguar?Jensen?Land Rover?Lightning?Lister?Lotus?Mini?MorganRolls-Royce?TVR?Vauxhall?Bugatti?Citroen?Heuliez?Mega?Peugeot?Renault?Hyundai?Kia?Oullim?SsangYong?Koenigsegg?Volvo?AvtoVAZ?Izs?Lada?UAZ?Škoda?Innotech?MTX?TatraARO?tatra?aro?Dacia?SEAT?Hindustan?Mahindra?Maruti Suzuki?maruti?suzuki?San?Tata?Force Motors?Beijing Jeep?jeep?Hongqi?Holden?Proton?Bufori?Tofas?ZAZ?BRIXXON?Solo?Locus";
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
                if (tip.Length>20)
                {
                    return false;
                }
                return true;
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

            //adatbázisba feltölteni


        }

    }
}
