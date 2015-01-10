using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFXSharp.Tests
{
    public static class Paths
    {
        public static DirectoryInfo TestDataFolder { get { return new DirectoryInfo(@"..\..\TestData"); } }
    }
}
