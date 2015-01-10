using System.IO;

namespace OFXSharp.Tests
{
    public static class ExtensionMethods
    {
        public static string ReadAllText(this FileInfo fileInfo)
        {
            return File.ReadAllText(fileInfo.FullName);
        }
    }
}
