using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zool.Extensions
{
    public static class StringExtensions
    {
        #region ToString oprations      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string IntToString(this int number)
        {
            return number.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string FloatToString(this float number)
        {
            return number.ToString();
        }

        public static string DecimalToString(this decimal number)
        {
            return number.ToString();
        }

        public static string ToStringUpper(this string stringText)
        {
            if (string.IsNullOrEmpty(stringText) || string.IsNullOrWhiteSpace(stringText))
                return string.Empty;
            return stringText.ToUpper();
        }

        public static string ToStringLower(this string stringText)
        {
            if (string.IsNullOrEmpty(stringText) || string.IsNullOrWhiteSpace(stringText))
                return string.Empty;
            return stringText.ToLower();
        }

        public static string DateToString(this DateTime date)
        {
            return date.ToString();
        }

        public static string YearToString(this DateTime date)
        {
            return date.Year.ToString();
        }

        public static string DayToString(this DateTime date)
        {
            return date.Day.ToString();
        }
        #endregion

        public static string FirstLetterUpper(this string stringText)
        {
            if (string.IsNullOrEmpty(stringText) || string.IsNullOrWhiteSpace(stringText))
                return string.Empty;
            return char.ToUpper(stringText[0]) + stringText.Substring(1);
        }

        /// <summary>
        /// Convert string with spaces into a Pascal Format string.
        /// </summary>
        /// <param name="stringText"></param>
        /// <returns></returns>
        public static string StringInPascalFormat(this string stringText)
        {
            var result = string.Empty;
            if (string.IsNullOrEmpty(stringText) || string.IsNullOrWhiteSpace(stringText))
                return result;

            var wordList = stringText.Split(' ').ToList();
            foreach(var item in wordList)
            {
                result += item.FirstLetterUpper();
            }
            return result;
        }





    }
}
