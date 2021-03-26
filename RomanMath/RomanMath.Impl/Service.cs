using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Linq;

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
            if (string.IsNullOrWhiteSpace(expression)) 
            {
                throw new ArgumentException("Expressin string is null or empty");
            }

            expression = expression.Replace(" ", "");


            //regex for checking is given expression permissible
            string allowedRomes = @"M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})";
            string allowedExpress = string.Concat($"^([{allowedRomes}]", @"+[\+\*-])+", $"{allowedRomes}$");
            if (!Regex.IsMatch(expression, allowedExpress))
            {
                throw new ArgumentException("Given expression is incorect");
            }

            var romanNumbers = expression.Split('+', '-', '*');

            foreach (var romanNumber in romanNumbers)
            {
                var arabicNumber = ConvertToArabic(romanNumber).ToString();
                int i = expression.IndexOf(romanNumber);
                //replace first coinciding substring
                expression = expression.Remove(i, romanNumber.Length).Insert(i, arabicNumber);
            }

            var result = new DataTable().Compute(expression, "");
            return (int) result;
        }

        private static readonly Dictionary<char, int> romanDigMap = new Dictionary<char, int>
        {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
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
                    total = total + thisNumeral;
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
