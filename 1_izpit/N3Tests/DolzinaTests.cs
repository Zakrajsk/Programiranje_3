using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3;
using System;
using System.Collections.Generic;
using System.Text;

namespace N3.Tests
{
    [TestClass()]
    public class DolzinaTests
    {
        [TestMethod()]
        public void Najkrajsa_razlicne()
        {
            Dolzina[] testna_tabela = new Dolzina[5];
            testna_tabela[0] = new Dolzina(10, "m");
            testna_tabela[1] = new Dolzina(5, "cm");
            testna_tabela[2] = new Dolzina(20, "dm");
            testna_tabela[3] = new Dolzina(1, "m");
            testna_tabela[4] = new Dolzina(9, "dm");

            Dolzina rez = Dolzina.NajkrajsaRazdalja(testna_tabela);
            Assert.AreEqual("5 cm", rez.ToString());
        }

        [TestMethod()]
        public void Najkrajsa_prazna()
        {
            Dolzina[] testna_tabela = new Dolzina[0];

            Dolzina rez = Dolzina.NajkrajsaRazdalja(testna_tabela);
            Assert.AreEqual(rez, null);
        }

        [TestMethod()]
        public void Najkrajsa_samo_en()
        {
            Dolzina[] testna_tabela = new Dolzina[1];
            testna_tabela[0] = new Dolzina(2, "m");

            Dolzina rez = Dolzina.NajkrajsaRazdalja(testna_tabela);
            Assert.AreEqual("200 cm", rez.ToString());
        }
    }
}