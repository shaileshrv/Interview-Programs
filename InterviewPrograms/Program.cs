
using InterviewPrograms;
using InterviewPrograms.AllProgram.Sports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    class Program
    {

        delegate void Printer();
        static void Main(string[] args)
        {

            var sss = Utility.Reverse_String("shailesh");

            List<Printer> printers = new List<Printer>();
            int i = 0;
            for (; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var printer in printers)
            {
                printer();
            }

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            var dd = arr.Where(x => x % 2 == 0).Count();



            //Console.WriteLine(DD(57817));
            Console.Read();
        }

        #region Number to text convert
        static string DD(int num)
        {
            //int num = 57814;
            string NumString = num.ToString();
            string finalString = "";

            while (NumString.Length > 0)
            {
                string currentNumber = "";
                if (NumString.Length == 5 || NumString.Length == 4)
                {
                    var size = NumString.Length == 4 ? 1 : 2;
                    currentNumber = NumString.Substring(0, size);
                    NumString = NumString.Substring(size - 1, NumString.Length - 1);
                    finalString += GetScreen(int.Parse(currentNumber)) + " ";
                    finalString += GetScreen(1000) + " ";
                }
                else if (NumString.Length == 3)
                {
                    currentNumber = NumString.Substring(0, 1);
                    NumString = NumString.Substring(1, NumString.Length - 1);
                    finalString += GetScreen(int.Parse(currentNumber)) + " ";
                    finalString += GetScreen(100) + " ";
                }
                else if (NumString.Length == 2)
                {
                    if (int.Parse(NumString) > 20)
                    {
                        currentNumber = NumString.Substring(0, 1);
                        NumString = NumString.Substring(1, NumString.Length - 1);
                        currentNumber += "0";
                    }
                    else
                    {
                        currentNumber = NumString.Substring(0, 2);
                        NumString = "";
                    }
                    finalString += GetScreen(int.Parse(currentNumber)) + " ";
                }
                else if (NumString.Length == 1)
                {
                    currentNumber = NumString.Substring(0, 1);
                    NumString = NumString.Substring(1, NumString.Length - 1);
                    finalString += GetScreen(int.Parse(currentNumber)) + " ";
                }
            }
            return finalString;
        }

        public static string GetScreen(int number)
        {
            switch (number)
            {
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                case 10: return "Ten";
                case 11: return "Elevnen";
                case 12: return "Twelve";
                case 13: return "Thirteen";
                case 14: return "Fourteen";
                case 15: return "Fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";
                case 20: return "Twenty";
                case 30: return "Thirty";
                case 40: return "Forty";
                case 50: return "Fifty";
                case 60: return "Sixty";
                case 70: return "Seventy";
                case 80: return "Eighty";
                case 90: return "Ninety";
                case 100: return "Hundred";
                case 1000: return "Thousand";
            }
            return "";
        }
        #endregion
    }
}
