using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vozila;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Tests
{
    [TestClass()]
    public class VnosVozil
    {
        [TestMethod()]
        public void NesmiselnaKapaciteta()
        {
            Action preveri = () => new Vozilo(-60, 5.6);
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void PrevelikaPoraba()
        {
            Action preveri = () => new Vozilo(60, 65.6);
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void NegativnaPoraba()
        {
            Action preveri = () => new Vozilo(60, -5.6);
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void NicnaPoraba()
        {
            Action preveri = () => new Vozilo(60, -0);
            Assert.ThrowsException<Exception>(preveri);
        }

    }
    [TestClass()]
    public class PreostaloKm
    {
        [TestMethod()]
        public void VnosIzracun()
        {
            Vozilo testno = new Vozilo(51, 5.1);
            Assert.AreEqual(testno.PreostaliKilometri, 1000);
        }

    }
    [TestClass()]
    public class PrevozPoti
    {
        [TestMethod()]
        public void AliPrevozi()
        {
            Vozilo testno = new Vozilo(60, 5);
            double[] pot = new double[] { 100, 50, 0 };
            bool konca = testno.Prevozi(pot);
            Assert.AreEqual(konca, true);
        }

        [TestMethod()]
        public void ZmanjkaBencina()
        {
            Vozilo testno = new Vozilo(60, 5);
            double[] pot = new double[] { 100, 50, 0, 500, 400, 400 };
            bool konca = testno.Prevozi(pot);
            Assert.AreEqual(konca, false);
        }


        [TestMethod()]
        public void PotBrezTankanja()
        {
            Vozilo testno = new Vozilo(60, 5);
            double[] pot = new double[] { 100, 50 };
            testno.Prevozi(pot);
            Assert.AreEqual(testno.PreostaliKilometri, 1050);
        }

        [TestMethod()]
        public void PotZTankanjem()
        {
            Vozilo testno = new Vozilo(60, 5);
            double[] pot = new double[] { 100, 50, 0 };
            testno.Prevozi(pot);
            Assert.AreEqual(testno.PreostaliKilometri, 1200);
        }

        [TestMethod()]
        public void NegativnaPot()
        {
            Vozilo testno = new Vozilo(60, 5);
            double[] pot = new double[] { 100, 50, 0, -5, 0, 500, 0, 20 };
            Action preveri = () => testno.Prevozi(pot);
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void DvojnoTankanje()
        {
            Vozilo testno = new Vozilo(60, 5);
            double[] pot = new double[] { 100, 50, 0, 0, 500, 0, 20 };
            Action preveri = () => testno.Prevozi(pot);
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void TankanjeNaZacetkuPravilno()
        {
            Vozilo testno = new Vozilo(60, 5);
            double[] pot = new double[] { 0, 500, 0, 200, 0, 20 };
            Action preveri = () => testno.Prevozi(pot);
            Assert.ThrowsException<Exception>(preveri);
        }

        [TestMethod()]
        public void TankanjeNaZacetkuNapacno()
        {
            Vozilo testno = new Vozilo(60, 5);
            double[] prva_pot = new double[] { 500 };
            testno.Prevozi(prva_pot);
            double[] pot = new double[] { 0, 500, 0, 200, 0, 20 };
            bool konca = testno.Prevozi(pot);
            Assert.AreEqual(konca, true);
        }
    }
}