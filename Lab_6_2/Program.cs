using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string secondString="";
            foreach (string s in stringArray)
            {
                secondString += s.Trim();
            }
            string thirdString = secondString.ToLower();
            int l = thirdString.Length;
            int i, j;
            j = 0;
            char[] charArray = thirdString.ToArray();
            for (i = l - 1; i >= 0; i--)
            {
                if (charArray[j] == charArray[i])
                {
                    j++;
                    if (i==0)
                    {
                        Console.WriteLine("yvliaetcy");
                    }
                }
                else
                {
                    Console.WriteLine("ne yvliaetcy");
                    break;
                }  
            }
            Console.ReadKey();
        }
    }
}
