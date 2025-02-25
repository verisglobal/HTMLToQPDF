using System;
using System.Collections.Generic;

namespace HTMLToQPDF.Utils
{
    internal static class FontFamilyUtils
    {
        public static string FormatFontFamily(string fontFamily)
        {
            var font = fontFamily;
            int comma = font.IndexOf(',');
            if (comma != -1)
            {
                font = fontFamily.Substring(0, comma);
            }
            font = font.Replace("'", string.Empty);
            font = font.Replace("\"", string.Empty);

            return font;
        }
    }
}