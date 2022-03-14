using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brez_trojk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brez_trojk.Tests
{
    [TestClass()]
    public class BrezTrojkTests
    {
        [TestMethod()]
        public void PravilenVnos()
        {
            int[] tab = new int[] { 5, 33, 5123, 22, 3, 433 };
            BrezTrojk.Krajsaj(ref tab);
            int[] resitev = new int[] { 5, 512, 22, 4 };
            CollectionAssert.AreEqual(tab, resitev);
        }

        [TestMethod()]
        public void PrazenVnos()
        {
            int[] tab = new int[0];
            BrezTrojk.Krajsaj(ref tab);
            int[] resitev = new int[0];
            CollectionAssert.AreEqual(tab, resitev);

        }

        [TestMethod()]
        public void NicTrojk()
        {
            int[] tab = new int[] { 5, 6, 9, 22, 2 };
            BrezTrojk.Krajsaj(ref tab);
            int[] resitev = new int[] { 5, 6, 9, 22, 2 };
            CollectionAssert.AreEqual(tab, resitev);

        }

        [TestMethod()]
        public void SamoTrojke()
        {
            int[] tab = new int[] { 3, 33, 33, 3333, 3, 333 };
            BrezTrojk.Krajsaj(ref tab);
            int[] resitev = new int[0];
            CollectionAssert.AreEqual(tab, resitev);

        }
    }
}