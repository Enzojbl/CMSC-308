using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace codecnvrt
{
    public class Program
    {
        public static void Main()
        {
            start:

            List<char> lcode = new List<char>() { 'X', 'C', 'O', 'M', 'P', 'U', 'T', 'E', 'R', 'S' };
            List<int> code2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            int x1, x2, x3, x4, x5, x6;
            Console.WriteLine("X C O M P U T E R S");
            // Console.WriteLine("\nInput Six ON CAPS Characters Only..."); 
            Console.WriteLine("\nEnter a code:");
            string res = Console.ReadLine();
            char[] arraych = res.ToCharArray();

            x1 = lcode.IndexOf(arraych[0]);
            x2 = lcode.IndexOf(arraych[1]);
            x3 = lcode.IndexOf(arraych[2]);
            x4 = lcode.IndexOf(arraych[3]);
            x5 = lcode.IndexOf(arraych[4]);
            x6 = lcode.IndexOf(arraych[5]);
          
            Console.WriteLine("\nEquivalent Code: {0}{1}{2}{3}{4}{5}", code2[x1], code2[x2], code2[x3], code2[x4], code2[x5], code2[x6]);
            Console.ReadKey();         
            goto start;
            }

        }
    }	
