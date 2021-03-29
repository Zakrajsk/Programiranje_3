using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registracije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracije.Tests
{
    [TestClass()]
    public class SpreminjanjeSpiska
    {
        [TestMethod()]
        public void DodajPoSpreminjanjuNapaka()
        {
            string[] nova_obmocja = new string[] { "AA", "BB", "CC" };
            //spremenimo spisek
            Registracija.SpremeniObmocja(nova_obmocja);

            Action preveri = () => new Registracija("LJ", "AS5S2");
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void DodajPoSpreminjanjuPravilna()
        {
            string[] nova_obmocja = new string[] { "AA", "BB", "CC" };
            //spremenimo spisek
            Registracija.SpremeniObmocja(nova_obmocja);

            Registracija testna = new Registracija("BB", "AS5S2");
            Assert.AreEqual(testna.obmocje, "BB");
        }

    }

    [TestClass()]
    public class NapacniPodatki
    {
        [TestMethod()]
        public void NapacnoObmocje()
        {
            Action preveri = () => new Registracija("ZZ", "AS5S2");
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void NeveljavnoObmocje()
        {
            Action preveri = () => new Registracija("LJU", "AS5S2");
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void NeveljavnaRegistracija()
        {
            Action preveri = () => new Registracija("ZZ", "AS5SS2");
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void StevilkaVObmocju()
        {
            Action preveri = () => new Registracija("P0", "AS5S2");
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void ZnakVRegistraciji()
        {
            Action preveri = () => new Registracija("ZZ", "AS5-S2");
            Assert.ThrowsException<Exception>(preveri);
        }

    }
}