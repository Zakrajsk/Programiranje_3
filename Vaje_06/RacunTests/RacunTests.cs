using Microsoft.VisualStudio.TestTools.UnitTesting;
using Racuni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racuni.Tests
{
    [TestClass()]
    public class RacunTests
    {
        [TestMethod()]
        public void StanjeEUR()
        {
            Racun test = new Racun("$", 0.778);
            test.Polog(30);
            Assert.AreEqual(test.StanjeEUR, 30);
        }

        [TestMethod()]
        public void PologTest()
        {
            Racun test = new Racun("$", 0778);
            test.Polog(100);

            test.Polog(-30);
            Assert.AreEqual(test.StanjeEUR, 70);
        }
    }
}