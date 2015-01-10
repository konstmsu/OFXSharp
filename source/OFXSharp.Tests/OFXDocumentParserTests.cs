using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OFXSharp.Tests
{
    [TestClass]
    public class OFXDocumentParserTests
    {
        [TestMethod]
        public void ShouldFailOnBadDates()
        {
            var parser = new OFXDocumentParser();
            AssertEx.Throws<OFXParseException>(() => parser.Import(TestData.ACCT_660_24_12_2012.ReadAllText()))
                .WithMessage("Unable to parse date '23032012210000'");
        }
    }
}
