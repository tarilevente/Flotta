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
    class RegFormPresenter
    {
        private IRegForm view;
        private autokContext db = new autokContext();
        public bool loginSuccess;

        public RegFormPresenter(IRegForm param)
        {
            view = param;
            db = new autokContext();
        }

        private bool ConnectionExist() 
        {
            return db.Database.Exists();
        }
        
        public void Authenticate()
        {
            if (!ConnectionExist())
            {
                view.ErrorMessage = Resources.AdatHiba;
            }
            else //ha van ab-kapcsolat:
            {
               



            }
        }




    }
}
