﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RomanMath.Impl
{
    public static class Service
    {
        /// <summary>
        /// See TODO.txt file for task details.
        /// Do not change contracts: input and output arguments, method name and access modifiers
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static int Evaluate(string expression)
        {
            
        }

        private static readonly Dictionary<char, int> romanDigMap = new Dictionary<char, int>
        {
            {'M', 1000}, {'D', 500}, {'C', 100},{'L', 50},{'X', 10},{'V', 5},{'I', 1}
        };

        /// <returns>Integer representation of roman number</returns>
        private static int ConvertToArabic(string romanNumber) 
        {
            romanNumber = romanNumber.ToUpper();

            //total = the current total value that will be returned.
            // minus = value to subtract from next numeral
            int total = 0, minus = 0;

            for (int i = 0; i < romanNumber.Length; i++) 
            {
                // Get the value for the current numeral. Takes subtraction into account.
                int thisNumeral = romanDigMap[romanNumber[i]] - minus;

                // Checks if this is the last character in the string, or if the current numeral
                // is greater than or equal to the next numeral.
                if (i >= romanNumber.Length - 1 ||
                    thisNumeral + minus >= romanDigMap[romanNumber[i + 1]])
                {
                    total += thisNumeral;
                    minus = 0;
                }
                else
                {
                    minus = thisNumeral;
                }
            }

            return total;
        }
    }
}
