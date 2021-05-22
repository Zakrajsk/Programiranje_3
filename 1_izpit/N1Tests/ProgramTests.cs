using Microsoft.VisualStudio.TestTools.UnitTesting;
using N1;
using System;
using System.Collections.Generic;
using System.Text;

namespace N1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Podan_primer()
        {
            int rez = Program.DruzabneStevke("bal123i4e7e12bed42");
            Assert.AreEqual(rez, 7);
        }

        [TestMethod()]
        public void Prazen_niz()
        {
            int rez = Program.DruzabneStevke("");
            Assert.AreEqual(rez, 0);
        }

        [TestMethod()]
        public void Samo_stevilke()
        {
            int rez = Program.DruzabneStevke("54321");
            Assert.AreEqual(rez, 5);
        }

        [TestMethod()]
        public void Na_prvem()
        {
            int rez = Program.DruzabneStevke("52abc");
            Assert.AreEqual(rez, 2);
        }

        [TestMethod()]
        public void Na_zadnjem()
        {
            int rez = Program.DruzabneStevke("abc21");
            Assert.AreEqual(rez, 2);
        }
    }
}