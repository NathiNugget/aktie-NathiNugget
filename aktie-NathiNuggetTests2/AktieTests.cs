using Microsoft.VisualStudio.TestTools.UnitTesting;
using aktie_NathiNugget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace aktie_NathiNugget.Tests
{
    [TestClass()]
    [ExcludeFromCodeCoverage]
    public class AktieTests
    {
        [TestMethod()]
        public void AktieKonstruktørTest()
        {
            Aktie a = new Aktie("Hej", 10, 12, 5);
            Assert.IsNotNull(a);
        }

        [TestMethod()]
        public void AktieSalgTest()
        {
            Aktie a = new Aktie("Hej", 10, 12, 5);
            Assert.AreEqual(10, a.Afkast()); 
        }

        [TestMethod()]
        public void AktieSalgNegativTest()
        {
            Aktie a = new Aktie("Hej", 12, 10, 5);
            Assert.AreEqual(-10, a.Afkast());
        }
    }
}