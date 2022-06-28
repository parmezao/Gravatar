namespace Gravatar.Tests;

[TestClass]
public class GravatarExtensionTests
{
    [TestCategory("Gravatar Tests")]
    [TestMethod("Should validate Gravatar extension")]
    [DataRow(null, false)]
    [DataRow(" ", false)]
    [DataRow("a@a", false)]
    [DataRow("a@parmex.com", false)]
    [DataRow("wagner@parmex.com.br", true)]
    public void ShouldValidateGravatar(string email, bool status)
    {
        var result = "https://www.gravatar.com/avatar/203b1d2b1069f155a607905c97f1bb58";
        Assert.AreEqual((email.ToGravatar() == result), status);
    }
}