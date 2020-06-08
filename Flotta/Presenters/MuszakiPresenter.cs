using Flotta.Models;
using Flotta.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Presenters
{
    class MuszakiPresenter
    {
        private autokContext db = new autokContext();
        private IMuszakiForm view;

        public MuszakiPresenter(IMuszakiForm param)
        {
            view = param;   
        }

        public bool ConnectionExists()
        {
            return db.Database.Exists();
        }

        /// <summary>
        /// A datagridview-t feltölti adattal
        /// </summary>
        public void Load()
        {
            view.bindingList = GetBiningList(
            view.search,
            view.ascending
            );
        }
        /// <summary>
        /// A bindingList-et feltölti adattal.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        private BindingList<muszakiallapottabla> GetBiningList(
            string search,
            bool ascending
        )
        {
            IQueryable<muszakiallapottabla> query = db.muszakiallapottabla.OrderBy(x => x.muszakiErv).AsQueryable();
                if (!string.IsNullOrWhiteSpace(search))
                {
                    query = query.Where(x => x.rendszamHOZ.ToUpper().Contains(search));
                }
                
            query = ascending ? query.OrderBy(x => x.muszakiErv) : query.OrderByDescending(x => x.muszakiErv);

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(x=>x.rendszamHOZ.Contains(search));
            }
                
            return new BindingList<muszakiallapottabla>(query.ToList());
        }
        /// <summary>
        /// A kijelölt autó sofőrjének és telefonszámának kiírása
        /// </summary>
        public void NevRendszamBetolt()
        {
            try
            {
                muszakiallapottabla t = view.selectedMusz;
                string aktRendsz = t.rendszamHOZ;
                var sofTabl = db.soforautojatabla.ToList();
                var SofID = -1;

                if (db.soforautojatabla.Select(x => x.rendszam).Contains(aktRendsz))
                {
                    SofID = sofTabl.Find(x => x.rendszam.Equals(aktRendsz)).idfelh;
                }
                string sofNev = "Az autónak nincs sofőrje. ";
                var felhTab = db.felhtabla.ToList();
                if (SofID == -1)
                {
                    view.sofNev = sofNev;
                    view.sofTel = "-- -- -------";
                }
                else
                {
                    var sofor = felhTab.SingleOrDefault(x => x.idFelh == SofID);
                    view.sofNev = sofor.vezetekNev + " " + sofor.keresztNev;
                    view.sofTel = sofor.telefon.ToString();
                }
            }
            catch (Exception e)
            {
                view.errorKeres = "A keresés nem vezetett eredményre.  :(";
            }
        }//endof nevrendszambetolt
    }
}
