namespace ObliczVAT
{
    [TestClass]
    public class VATCalculatorTest
    {
        private readonly VATCalculator vatCalc = new VATCalculator();

        [TestMethod]
        public void VAT_23()
        {
            double vat = vatCalc.ObliczVAT(100, 23);
            Assert.AreEqual(23, vat);
        }

        [TestMethod]
        public void VAT_8()
        {
            double vat = vatCalc.ObliczVAT(100, 8);
            Assert.AreEqual(8, vat);
        }

        [TestMethod]
        public void VAT_0()
        {
            double vat = vatCalc.ObliczVAT(100, 0);
            Assert.AreEqual(0, vat);
        }

        [TestMethod]
        public void VAT_ZeroNetto()
        {
            double vat = vatCalc.ObliczVAT(0, 23);
            Assert.AreEqual(0, vat);
        }

        [TestMethod]
        public void VAT_Throws_WhenNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => vatCalc.ObliczVAT(-10, 23));
        }
    }

}