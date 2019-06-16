using System;
using System.Text;

namespace Virtusa.CodeTest.NumberToWordConverter
{
   
    public class NumberToWordConverter
    {
    
        static string[] one = {"", "one ", "two ", "three ", "four ",
                       "five ", "six ", "seven ", "eight ",
                       "nine ", "ten ", "eleven ", "twelve ",
                       "thirteen ", "fourteen ", "fifteen ",
                       "sixteen ", "seventeen ", "eighteen ",
                       "nineteen "};
       static  string[] ten = {"", "", "twenty ", "thirty ", "forty ",
                       "fifty ", "sixty ", "seventy ", "eighty ",
                       "ninety "};
        // n is 1- or 2-digit number  
       static string NumberToWord(int n, string s)
        {
            string word = "";

            // if n is more than 19, divide it  
            if (n > 19)
            {
                word += ten[n / 10] + one[n % 10];
            }
            else
            {
                word += one[n];
            }

            // if n is non-zero  
            if (n != 0)
            {
                word += s;
            }

            return word;
        }
        // Function to print a given number in words  
        public static string Convert(long inputNumber)
        {
            
            StringBuilder strOutputWord = new StringBuilder();
           
            strOutputWord.Append(NumberToWord((int)(inputNumber / 1000000000),
                                          "thousand "));//handle thousand millions (if any)
 
            strOutputWord.Append(NumberToWord((int)((inputNumber / 1000000) % 100),
                                                 "million ")); //handle million (if any)

            strOutputWord.Append(NumberToWord((int)((inputNumber / 1000) % 100),
                                           "thousand ")); //handle thousands (if any)

            // handles digit at hundreds places (if any)  
            strOutputWord.Append(NumberToWord((int)((inputNumber / 100) % 10),
                                          "hundred ")); //handle hundreds (if any)

            if (inputNumber > 100 && inputNumber % 100 > 0)
            {
                strOutputWord.Append("and ");
            }

            // handles digits at ones and tens  
            // places (if any)  
            strOutputWord.Append(NumberToWord((int)(inputNumber % 100), ""));

            return strOutputWord.ToString();
        }
    }
}