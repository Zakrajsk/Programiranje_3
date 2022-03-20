using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vrni_Nti_element_deluxe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrni_Nti_element_deluxe.Tests
{
    [TestClass()]
    public class Pravilni_Izhode
    {

        [TestMethod()]
        public void PozitivniIndex()
        {
            string[] blebetanje = { "bla", "blo", "bli" };

            string niz = VrniNtiElementDeluxe.VrniNtiElement(blebetanje, 2);
            Assert.AreEqual(niz, "blo");
        }

        [TestMethod()]
        public void NegativniIndex()
        {
            string[] blebetanje = { "bla", "blo", "bli" };

            string niz = VrniNtiElementDeluxe.VrniNtiElement(blebetanje, -3); // dobimo "bla"
            Assert.AreEqual(niz, "bla");

        }
    }

    [TestClass()]
    public class Napake
    {
        [TestMethod()]
        public void ObNepravilnemArgumentu()
        {
            string[] blebetanje = { "bla", "blo", "bli" };
            Action preveri = () => VrniNtiElementDeluxe.VrniNtiElement(blebetanje, -4); // sproži se izjema
            Assert.ThrowsException<IndexOutOfRangeException>(preveri);
        }

        [TestMethod()]
        public void ObArgumentuNic()
        {
            int[] tja = { 10, 20, 30 };
            Action preveri = () => VrniNtiElementDeluxe.VrniNtiElement(tja, 0); // sproži se izjema
            Assert.ThrowsException<IndexOutOfRangeException>(preveri);
        }
    }
}