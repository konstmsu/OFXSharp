using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFXSharp.Tests
{
    public static class TestData
    {
        public static readonly FileInfo itau = GetFile("itau.ofx");
        public static readonly FileInfo santander = GetFile("santander.ofx");
        public static readonly FileInfo ACCT_660_24_12_2012 = GetFile("ACCT_660_24_12_2012.OFX");

        static FileInfo GetFile(string fileName)
        {
            return Paths.TestDataFolder.GetFiles(fileName).Single();
        }
    }
}
