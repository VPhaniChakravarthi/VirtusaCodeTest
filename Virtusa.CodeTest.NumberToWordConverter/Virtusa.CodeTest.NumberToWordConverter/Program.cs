using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtusa.CodeTest.NumberToWordConverter
{
    class Program
    {
        private static bool ValidateAndCovertToWord(string strInputNumber)
        {
            bool isValid = true;
            try
            {
                long number = Convert.ToInt64(strInputNumber.Replace(",", ""));

                if (number < 0)
                {
                    Console.WriteLine("Please Enter Positive Number:");
                }
                if(number> 99999999999)
                {
                    throw new OverflowException();
                }
                else
                {
                    Console.WriteLine(NumberToWordConverter.Convert(number));
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Valid input number Range: 1 to 99999999999");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           return isValid;
           
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter a Number to Convert to Word:");
                string numberString = Console.ReadLine();
                ValidateAndCovertToWord(numberString);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
