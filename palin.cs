[TestClass]
public class PalindromeCheckerTest
{
    private readonly PalindromeChecker checker = new PalindromeChecker();

    [TestMethod]
    public void Sprawdza_MaleLitery()
    {
        Assert.IsTrue(checker.CzyPalindrom("kajak"));
    }

    [TestMethod]
    public void Sprawdza_DuzeIMaleLitery()
    {
        Assert.IsTrue(checker.CzyPalindrom("Kajak"));
    }

    [TestMethod]
    public void Sprawdza_ZnakiSpecjalne()
    {
        Assert.IsTrue(checker.CzyPalindrom("A man, a plan, a canal: Panama"));
    }

    [TestMethod]
    public void Sprawdza_PustyString()
    {
        Assert.IsFalse(checker.CzyPalindrom(""));
    }

    [TestMethod]
    public void Sprawdza_Niepalindrom()
    {
        Assert.IsFalse(checker.CzyPalindrom("palindrom"));
    }
}
