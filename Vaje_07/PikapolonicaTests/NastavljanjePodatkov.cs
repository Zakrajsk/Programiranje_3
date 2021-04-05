using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zivali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zivali.Tests
{
    [TestClass()]
    public class NastavljanjePodatkov
    {
        [TestMethod()]
        public void PrevelikaStarost()
        {
            Action preveri = () => new Pikapolonica(300, 6);
            Assert.ThrowsException<Exception>(preveri);
        }
        [TestMethod()]
        public void NegativnoSteviloPik()
        {
            Action preveri = () => new Pikapolonica(200, -4);
            Assert.ThrowsException<Exception>(preveri);
        }
        [TestMethod()]
        public void PravilniVnos()
        {
            Pikapolonica testna = new Pikapolonica(120, 7);
            Assert.AreEqual(testna.Starost, 120);
        }
        [TestMethod()]
        public void Izpis()
        {
            string zeljen_izpis = "Jaz sem PikaPoka, stara 120 tednov in imam 7 pik";
            Pikapolonica testna = new Pikapolonica(120, 7);
            Assert.AreEqual(testna.ToString(), zeljen_izpis);
        }
    }
    [TestClass()]
    public class KopiranjePikapolonic
    {
        [TestMethod()]
        public void NegativniMnozitelj()
        {
            Pikapolonica testna = new Pikapolonica(120, 7);
            Action preveri = () => { Pikapolonica[] kopije = testna * -2; };
            Assert.ThrowsException<Exception>(preveri);
        }
    }

    [TestClass()]
    public class SestevanjePik
    {
        [TestMethod()]
        public void PravilnoSestevanje()
        {
            Pikapolonica[] tabela = new Pikapolonica[5];

            tabela[0] = new Pikapolonica(220, 3);
            tabela[1] = new Pikapolonica(10, 7);
            tabela[2] = new Pikapolonica(80, 7);
            tabela[3] = new Pikapolonica(110, 6);
            tabela[4] = new Pikapolonica(170, 5);
            Assert.AreEqual(Pikapolonica.SteviloPikVseh(tabela), 21);
        }
    }
}