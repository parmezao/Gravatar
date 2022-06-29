namespace Gravatar.Tests;

[TestClass]
public class GravatarExtensionTests
{
    [TestCategory("Gravatar Tests")]
    [TestMethod("Should validate Gravatar extension")]
    [DataRow(null, 200, false)]
    [DataRow(" ", 200, false)]
    [DataRow("a@a", 200, false)]
    [DataRow("a@parmex.com", 200, false)]
    [DataRow("wagner@parmex.com.br", null, true)]
    [DataRow("wagner@parmex.com.br", 200, true)]
    public void ShouldValidateGravatar(string email, int? size, bool status)
    {
        var imageSize = size.HasValue ? size.Value.ToString() : "60";
        var result = $"https://www.gravatar.com/avatar/203b1d2b1069f155a607905c97f1bb58?s={imageSize}";
        Assert.AreEqual((email.ToGravatar(size ?? 60) == result), status);
    }
}