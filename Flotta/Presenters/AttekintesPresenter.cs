using Flotta.Models;
using Flotta.Properties;
using Flotta.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Presenters
{
    class AttekintesPresenter
    {
        private IAttekintesForm view;
        private autokContext db = new autokContext();

        public int OsszAutoDB;
        public int OsszSoforDB;
        public int OsszTeliDB;
        public int OsszNyariDB;
        public int OsszRadioDB;
        public int OsszVontDB;
        public int OsszBikaDB;
        public int OsszMentoDB;

        public AttekintesPresenter(IAttekintesForm param)
        {
            view = param;
            db = new autokContext();
            LoadData();
        }

        public void LoadData()
        {
            OsszAuto();
            OsszSofor();
            OsszTeli();
            OsszNyari();
            OsszRadio();
            OsszVont();
            OsszBika();
            OsszMento();
            LegrAuto();
            KovBizt();
            KovMusz();
            LegtobbKm();
            TeliLista();
            NyariLista();
        }

        private bool ConnectionExists()
        {
            return db.Database.Exists();
        }

        public void OsszAuto()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                OsszAutoDB = db.autoktabla.Count();
                view.OsszAuto = OsszAutoDB.ToString()+" db";
            }
        } 

        public void OsszSofor()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                OsszSoforDB = db.felhtabla
                    .Where(x=>x.soforE.Equals(1))
                    .Count();
                view.OsszSofor = OsszSoforDB.ToString() + " db";
            }
        }

        public void OsszTeli()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                OsszTeliDB = db.muszakiallapottabla
                    .Where(x=>x.teligumi.Equals(1))
                    .Count();
                view.OsszTeli = OsszTeliDB.ToString() + " db";
            }
        }

        public void OsszNyari()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                OsszNyariDB = db.muszakiallapottabla
                    .Select(x => x.nyarigumi)
                    .Where(x => x.Equals(1))
                    .Count();
                view.OsszNyari = OsszNyariDB.ToString() + " db";
            }
        }

        public List<autoktabla> getAutok()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
                return null;
            }
            else
            {
                var list = db.autoktabla.ToList();
                return list;
            }
        }

        public void OsszRadio()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                var list=getAutok();
                var OsszRadioDB = list.Where(x=>x.autoradio==1).Count();
                view.OsszRadio = OsszRadioDB.ToString() + " db";
            }
        }

        public void OsszVont()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                var list = getAutok();
                var OsszVontDB = list.Where(x=>x.vontatokotel==1).Count();
                view.OsszVont = OsszVontDB.ToString() + " db";
            }
        }

        public void OsszBika()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                var list = getAutok();
                var OsszBikaDB = list.Where(x => x.bikakabel == 1).Count();
                view.OsszBika = OsszBikaDB.ToString() + " db";
            }
        }

        public void OsszMento()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                var list = getAutok();
                var OsszMentoDB = list.Where(x=>x.mentodoboz==1).Count();
                view.OsszMento = OsszMentoDB.ToString() + " db";
            }
        }

        public void LegrAuto()
        {
            if (ConnectionExists())
            {
                List<muszakiallapottabla> list = new List<muszakiallapottabla>();
                list = db.muszakiallapottabla.Select(x => x).ToList();
                var legregebbi = list.OrderBy(x => x.evjarat).First();
                view.legregebbiAuto = legregebbi.rendszamHOZ+Environment.NewLine+legregebbi.evjarat.ToString("yyyy-MM-dd");
            }
        }

        public void KovBizt()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                var list = db.muszakiallapottabla.ToList();
                var kovb = list.OrderBy(x => x.biztosErv).First();
                view.kovBizt = kovb.rendszamHOZ + Environment.NewLine + kovb.biztosErv.ToString("yyyy-MM-dd");
            }
        }

        public void KovMusz()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                var list = db.muszakiallapottabla.ToList();
                var kovm = list.OrderBy(x => x.muszakiErv).First();
                view.kovMusz = kovm.rendszamHOZ + Environment.NewLine + kovm.muszakiErv.ToString("yyyy-MM-dd");
            }
        }

        public void LegtobbKm()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                var list = db.autoktabla.ToList();
                var maxkm = list.OrderByDescending(x=>x.km).First();
                view.maxKm = maxkm.rendszam + Environment.NewLine + maxkm.km.ToString()+" km";
            }
        }

        public void TeliLista()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                view.teli = db.muszakiallapottabla.Where(x=>x.teligumi==1).Select(x=>x.rendszamHOZ).ToList();
            }

        }

        public void NyariLista()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                view.nyari = db.muszakiallapottabla.Where(x => x.nyarigumi == 1).Select(x => x.rendszamHOZ).ToList();
            }

        }
    }
}
