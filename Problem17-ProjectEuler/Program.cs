using System;

namespace Problem17_ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;

            for(int i = 1; i <= 1000; i++)
            {
                totalSum = totalSum + NumberToWords(i).Length;
            }

            Console.WriteLine("If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, there would be {0} letters used", totalSum);

            //Console.WriteLine(NumberToWords(342).Length + " and " + NumberToWords(115).Length);
            //Console.WriteLine(NumberToWords(114));
        }

        static string NumberToWords(int value)
        {
            string stringNumber = "";
            char[] valueToString = value.ToString().ToCharArray();
            string[] firstTen = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] secondTen = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] firstHundred = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred", "and", "thousand" };

            if (valueToString.Length == 4)
            {
                stringNumber = firstTen[Convert.ToInt32(valueToString[0].ToString())] + firstHundred[10];
                if (valueToString[1].ToString() == "0" && (valueToString[2].ToString() != "0" || valueToString[3].ToString() != "0"))
                {
                    stringNumber = stringNumber + firstHundred[9];
                    if (valueToString[2].ToString() == "0")
                        stringNumber = stringNumber + firstTen[Convert.ToInt32(valueToString[2].ToString())];
                    if (valueToString[2].ToString() == "1")
                        stringNumber = stringNumber + secondTen[Convert.ToInt32(valueToString[3].ToString())];
                    if (valueToString[2].ToString() != "0" && valueToString[2].ToString() != "1")
                    {
                        stringNumber = stringNumber + firstHundred[Convert.ToInt32(valueToString[2].ToString()) - 2] + firstTen[Convert.ToInt32(valueToString[3].ToString())];
                    }
                }
                else if (valueToString[1].ToString() == "0" && valueToString[2].ToString() == "0" && valueToString[3].ToString() == "0")
                    stringNumber = stringNumber;
                else
                {
                    if (valueToString[2].ToString() == "0" || valueToString[3].ToString() == "0")
                        stringNumber = stringNumber + firstTen[Convert.ToInt32(valueToString[1].ToString())] + firstHundred[8];
                    else
                        stringNumber = stringNumber + firstTen[Convert.ToInt32(valueToString[1].ToString())] + firstHundred[8] + firstHundred[9];
                    if (valueToString[2].ToString() == "0")
                        stringNumber = stringNumber + firstTen[Convert.ToInt32(valueToString[2].ToString())];
                    if (valueToString[2].ToString() == "1")
                        stringNumber = stringNumber + secondTen[Convert.ToInt32(valueToString[3].ToString())];
                    if (valueToString[2].ToString() != "0" && valueToString[2].ToString() != "1")
                    {
                        stringNumber = stringNumber + firstHundred[Convert.ToInt32(valueToString[2].ToString()) - 2] + firstTen[Convert.ToInt32(valueToString[3].ToString())];
                    }
                }
            }
            else if (valueToString.Length == 3)
            {
                if (valueToString[1].ToString() == "0" && valueToString[2].ToString() == "0")
                    stringNumber = firstTen[Convert.ToInt32(valueToString[0].ToString())] + firstHundred[8];
                else
                    stringNumber = firstTen[Convert.ToInt32(valueToString[0].ToString())] + firstHundred[8] + firstHundred[9];
                if (valueToString[1].ToString() == "0")
                    stringNumber = stringNumber + firstTen[Convert.ToInt32(valueToString[2].ToString())];
                if (valueToString[1].ToString() == "1")
                    stringNumber = stringNumber + secondTen[Convert.ToInt32(valueToString[2].ToString())];
                if (valueToString[1].ToString() != "0" && valueToString[1].ToString() != "1")
                {
                    stringNumber = stringNumber + firstHundred[Convert.ToInt32(valueToString[1].ToString()) - 2] + firstTen[Convert.ToInt32(valueToString[2].ToString())];
                }
            }
            else if (valueToString.Length == 2)
            {
                if (valueToString[0].ToString() == "1")
                    stringNumber = stringNumber + secondTen[Convert.ToInt32(valueToString[1].ToString())];
                if (valueToString[0].ToString() != "0" && valueToString[0].ToString() != "1")
                {
                    stringNumber = stringNumber + firstHundred[Convert.ToInt32(valueToString[0].ToString()) - 2] + firstTen[Convert.ToInt32(valueToString[1].ToString())];
                }
            }
            else if (valueToString.Length == 1)
            {
                stringNumber = firstTen[Convert.ToInt32(valueToString[0].ToString())];
            }

            return stringNumber;
        }
    }
}
