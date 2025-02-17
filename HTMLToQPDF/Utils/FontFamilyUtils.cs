using System;
using System.Collections.Generic;

namespace HTMLToQPDF.Utils
{
    internal static class FontFamilyUtils
    {
        private static readonly HashSet<string> availableFonts = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Arial",
            "Brush Script MT",
            "Courier New",
            "Garamond",
            "Montserrat",
            "Helvetica",
            "Tahoma",
            "Trebuchet MS",
            "Times New Roman",
            "Verdana",
            "Georgia"
        };

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

        public static bool IsFontFamilyValid(string fontFamily)
        {
            return availableFonts.Contains(fontFamily);
        }
    }
}