using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(compress("ssssbbdddddss"));
            Console.ReadKey();
        }
        static string compress(string inp)
        {

            string resultString = "";
            int sum = 1;
            int i;
            sum = 1;
            char[] inpString = inp.ToArray();
            for (i = 0; i < inpString.Length - 1; i++)
            {

                if (inpString[i] == inpString[i + 1])
                {
                    sum = sum + 1;
                }
                else
                {
                    resultString = resultString + sum + inpString[i] + " ";
                    sum = 1;
                }

            }
            resultString = resultString + sum +  inpString[inpString.Length - 1] + " ";
            return resultString.Length < inpString.Length ? resultString : inp;
        }
    }
}

