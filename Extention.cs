﻿namespace FileBuilder
{
    /// <summary> 
    /// Extention type of the file.
    /// Edit it Edit as you see fit.
    /// Just don't forget to update the ToExtentionString method as well.
    /// </summary>
    public enum Extention { CSharp, HTML, CSS, JavaScript, Text, Bat, Python }

    internal static class EnumToString
    {
        /// <summary>
        /// Converts the extention type enum value into its respective string.
        /// Eg. (Extention.JavaScript) => ".js"
        /// </summary>
        /// <param name="extentionValue">The enum value to be converted.</param>
        /// <returns></returns>
        internal static string ToExtentionString(this Extention extentionValue)
        {
            switch (extentionValue)
            {
                case Extention.CSharp: return "cs";
                case Extention.HTML: return "html";
                case Extention.CSS: return "css";
                case Extention.JavaScript: return "js";
                case Extention.Text: return "txt";
                case Extention.Bat: return "bat";
                case Extention.Python: return "py";
                default: return "";
            }
        }
    }
}
