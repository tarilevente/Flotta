using Microsoft.VisualStudio.TestTools.UnitTesting;
using Flotta;
using Flotta.Presenters;
using System;

namespace FlottaTest
{
    [TestClass]
    public class Tests
    {



        [TestMethod]
        public void UjAutoKm_NemLehetNegativ()
        {
            UjAutoPresenter UjAutoPresenter = new Flotta.Presenters.UjAutoPresenter();
            try
            {
                UjAutoPresenter.test();
            }

            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "neg");
                return;
            }
            Assert.Fail("A várt kivétel nem került elõ.");
        }

        [TestMethod]
        public void UjAutoEvj_NemLehetJovobeli()
        {
            UjAutoPresenter ua = new UjAutoPresenter();
            System.DateTime jovore =System.DateTime.Now.AddYears(1);
            
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => ua.TestEvjaratOk(jovore));
        }


    }
}
