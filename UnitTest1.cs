using kalkulator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class KalkulatorTest
{
    private readonly Kalkulator calc = new Kalkulator();

    [TestMethod]
    public void Dodaj_Test()
    {
        double result = calc.Dodaj(5, 3);
        Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void Odejmij_Test()
    {
        double result = calc.Odejmij(10, 4);
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void Pomnoz_Test()
    {
        double result = calc.Pomnoz(6, 7);
        Assert.AreEqual(42, result);
    }

    [TestMethod]
    public void Podziel_Test()
    {
        double result = calc.Podziel(10, 2);
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void Podziel_ThrowsException_WhenDividingByZero()
    {
        Assert.ThrowsException<DivideByZeroException>(() => calc.Podziel(5, 0));
    }
}
