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
        public string legrAuto;
        private List<String> legrAutoLista;

        public AttekintesPresenter(IAttekintesForm param)
        {
            view = param;
            db = new autokContext();
            //adatok betöltése
            LoadData();
        }

        public void LoadData()
        {
            //a view-t feltöltjük adatokkal
            OsszAuto();
            OsszSofor();
            OsszTeli();
            OsszNyari();
            OsszRadio();
            OsszVont();
            OsszBika();
            OsszMento();
            //legrAuto();
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
                OsszAutoDB = db.autoktabla
                    .Select(x=>x.rendszam)

                    .Count();
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
                    .Select(x => x.soforE)
                    .Where(x=>x.Equals(1))
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
                    .Select(x=>x.teligumi)
                    .Where(x=>x.Equals(1))
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

        public void OsszRadio()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessage = Resources.DBError;
            }
            else
            {
                OsszRadioDB = db.autoktabla
                    .Select(x => x.autoradio)
                    .Where(x => x != null)
                    .Count();
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
                OsszVontDB = db.autoktabla
                    .Select(x => x.vontatokotel)
                    .Where(x => x != null)
                    .Count();
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
                OsszBikaDB = db.autoktabla
                    .Select(x => x.bikakabel)
                    .Where(x => x != null)
                    .Count();
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
                OsszMentoDB = db.autoktabla
                    .Select(x => x.mentodoboz)
                    .Where(x => x != null)
                    .Count();
                view.OsszMento = OsszMentoDB.ToString() + " db";
            }
        }

        public void LegrAuto()
        {
            if (!ConnectionExists())
            {
                legrAutoLista = db.muszakiallapottabla
                    .Select(x => x.rendszamHOZ)
                    .ToList();
            }
        }
    }
}
