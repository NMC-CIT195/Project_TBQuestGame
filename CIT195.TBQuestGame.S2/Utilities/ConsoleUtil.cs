﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CIT195.TBQuestGame
{
    /// <summary>
    /// class to hold utility methods for the console
    /// </summary>
    public static class ConsoleUtil
    {
        /// <summary>
        /// wraps text using a list of strings
        /// Original code from Mike Ward's website
        /// http://mike-ward.net/2009/07/19/word-wrap-in-a-console-app-c/
        /// Adapted to include a left margin for console window support
        /// </summary>
        /// <param name="text">text to wrap</param>
        /// <param name="rightMargin">length of each line</param>
        /// <param name="leftMargin">left margin</param>
        /// <returns>list of lines as strings</returns>
        public static List<string> Wrap(string text, int rightMargin, int leftMargin)
        {
            int start = 0, end;
            var lines = new List<string>();

            string leftMarginSpaces = "";
            for (int i = 0; i < leftMargin; i++)
            {
                leftMarginSpaces += " ";
            }

            text = Regex.Replace(text, @"\s", " ").Trim();

            while ((end = start + rightMargin) < text.Length)
            {
                while (text[end] != ' ' && end > start)
                    end -= 1;

                if (end == start)
                    end = start + rightMargin;

                lines.Add(leftMarginSpaces + text.Substring(start, end - start));
                start = end + 1;
            }

            if (start < text.Length)
                lines.Add(leftMarginSpaces + text.Substring(start));

            return lines;
        }
        /// <summary>
        /// center text as a function of the window width with padding on both sides
        /// Note: the method currently assumes the text will fit on one line
        /// </summary>
        /// <param name="text">text to center</param>
        /// <param name="windowWidth">the width of the window in characters</param>
        /// <returns>string with spaces and centered text</returns>
        public static string Center(string text, int windowWidth)
        {
            int leftPadding = (windowWidth - text.Length) / 2 + text.Length;
            return text.PadLeft(leftPadding).PadRight(windowWidth);
        }

        /// <summary>
        /// generate a string of spaces of a given length
        /// </summary>
        /// <param name="stringLength">length of string</param>
        /// <returns>string of spaces</returns>
        public static string FillStringWithSpaces(int stringLength)
        {
            string rowOfSpaces = "";
            return rowOfSpaces.PadRight(stringLength);
        }
    }
}
