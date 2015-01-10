using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace OFXSharp.Tests
{
    [TestClass]
    public class CanParser
    {
        [TestMethod]
        public void CanParserItau()
        {
            var parser = new OFXDocumentParser();
            var ofxDocument = parser.Import(TestData.itau.ReadAllText());
        }

        [TestMethod]
        public void CanParserSantander()
        {
            var parser = new OFXDocumentParser();
            var ofxDocument = parser.Import(TestData.santander.ReadAllText());
        }
    }
}
