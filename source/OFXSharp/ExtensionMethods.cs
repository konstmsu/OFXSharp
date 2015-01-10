namespace OFXSharp
{
    internal static class ExtensionMethods
    {
        public static string FormatWith(this string format, params object[] args)
        {
            return string.Format(format, args);
        }
    }
}
