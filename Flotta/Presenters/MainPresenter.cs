using Flotta.Models;
using Flotta.Properties;
using Flotta.ViewInterfaces;
using Flotta.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta.Presenters
{
    class MainPresenter
    {
        private IMainWindow view;
        private autokContext db = new autokContext();

    
        public MainPresenter(IMainWindow param)
        {
            view = param;
            if (ConnectionExists())
            {
                Load();
            }
        }

        public bool ConnectionExists()
        {
            return db.Database.Exists();
        }

        private void Load()
        {
            if (!ConnectionExists())
            {
                view.ErrorMessageDB = Resources.DBError;
            }
        }
    }
}
