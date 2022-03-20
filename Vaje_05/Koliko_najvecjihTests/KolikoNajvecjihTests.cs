using Microsoft.VisualStudio.TestTools.UnitTesting;
using Koliko_najvecjih;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koliko_najvecjih.Tests
{
    [TestClass()]
    public class PravilniVnosi
    {
        [TestMethod()]
        public void PrestejInt()
        {
            int[] tab = new int[] { 2, 3, 4, 5, 1, 2, 2, 5 };
            int rez = KolikoNajvecjih.PrestejNajvecje(tab);
            Assert.AreEqual(rez, 2);
        }

        [TestMethod()]
        public void PrestejString()
        {
            string[] tab = new string[] { "janez", "miha", "peter", "jakob", "marjeta", "nika", "ana", "eva" };
            int rez = KolikoNajvecjih.PrestejNajvecje(tab);
            Assert.AreEqual(rez, 1);
        }

        [TestMethod()]
        public void PrestejDouble()
        {
            double[] tab = new double[] { 2.2, 3.1, 4.1, 5.6, 1.2, 2.2, 2.1, 5.6 , 2.9, 3.8, 5.6};
            int rez = KolikoNajvecjih.PrestejNajvecje(tab);
            Assert.AreEqual(rez, 3);
        }

        [TestMethod()]
        public void PrestejPrazno()
        {
            double[] tab = new double[0];
            int rez = KolikoNajvecjih.PrestejNajvecje(tab);
            Assert.AreEqual(rez, 0);
        }
    }
}