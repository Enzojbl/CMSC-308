using System;
using System.Collections.Generic;
using System.Linq;

namespace Act6
{
    class program
    {
        public static void Main()
        {
            List<char> lcode = new List<char>() { 'X', 'C', 'O', 'M', 'P', 'U', 'T', 'E', 'R', 'S' };
            List<int> code2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            int x1, x2, x3, x4, x5, x6, x7, x8, x9, x10;
            Console.WriteLine("X C O M P U T E R S");
            Console.WriteLine("Choose how many codes to enter between 1-10");
            int inp = Convert.ToInt32(Console.ReadLine());

            if (inp >= 1 && inp <= 10)
            {
                Console.WriteLine("\nEnter a code:");
                string res = Console.ReadLine();
                char[] arraych = res.ToCharArray();

                string[] chars = { "X", "C", "O", "M", "P", "U", "T", "E", "R", "S" };

                switch (inp)
                {
                    case 1:
                        if (!chars.Contains(res))
                        {
                            x1 = lcode.IndexOf(arraych[0]);
                            Console.WriteLine("\nEquivalent Code: {0}", code2[x1]);
                            
                        }
                        else if (chars.Contains(res))
                        {
                            Console.WriteLine("ERROR!");
                        }
                        break;


                    case 2:
                        if (!chars.Contains(res))
                        {                            
                            x1 = lcode.IndexOf(arraych[0]);
                            x2 = lcode.IndexOf(arraych[1]);
                            Console.WriteLine("\nEquivalent Code: {0}{1}", code2[x1], code2[x2]);
                        }
                        else if (chars.Contains(res))
                        {
                            Console.WriteLine("ERROR!");
                        }
                        break;

                    case 3:
                        if (!chars.Contains(res))
                        {
                            x1 = lcode.IndexOf(arraych[0]);
                            x2 = lcode.IndexOf(arraych[1]);
                            x3 = lcode.IndexOf(arraych[2]);
                            Console.WriteLine("\nEquivalent Code: {0}{1}{2}", code2[x1], code2[x2], code2[x3]);
                        }
                        else if (chars.Contains(res))
                        {
                            Console.WriteLine("ERROR!");                 
                        }
                        break;

                    case 4:
                        if (!chars.Contains(res))
                        {
                            x1 = lcode.IndexOf(arraych[0]);
                            x2 = lcode.IndexOf(arraych[1]);
                            x3 = lcode.IndexOf(arraych[2]);
                            x4 = lcode.IndexOf(arraych[3]);
                            Console.WriteLine("\nEquivalent Code: {0}{1}{2}{3}", code2[x1], code2[x2], code2[x3], code2[x4]);
                        }
                        else if (chars.Contains(res))
                        {
                            Console.WriteLine("ERROR!");
                        }
                        break;

                    case 5:
                        if (!chars.Contains(res))
                        {
                            x1 = lcode.IndexOf(arraych[0]);
                            x2 = lcode.IndexOf(arraych[1]);
                            x3 = lcode.IndexOf(arraych[2]);
                            x4 = lcode.IndexOf(arraych[3]);
                            x5 = lcode.IndexOf(arraych[4]);
                            Console.WriteLine("\nEquivalent Code: {0}{1}{2}{3}{4}", code2[x1], code2[x2], code2[x3], code2[x4], code2[x5]);
                            
                        }
                        else if (chars.Contains(res))
                        {
                            Console.WriteLine("ERROR!");
                        }
                        break;

                    case 6:
                        if (!chars.Contains(res))
                        {
                            x1 = lcode.IndexOf(arraych[0]);
                            x2 = lcode.IndexOf(arraych[1]);
                            x3 = lcode.IndexOf(arraych[2]);
                            x4 = lcode.IndexOf(arraych[3]);
                            x5 = lcode.IndexOf(arraych[4]);
                            x6 = lcode.IndexOf(arraych[5]);
                            Console.WriteLine("\nEquivalent Code: {0}{1}{2}{3}{4}{5}", code2[x1], code2[x2], code2[x3], code2[x4], code2[x5], code2[x6]);
                        }
                        else if (chars.Contains(res))
                        {
                            Console.WriteLine("ERROR!");
                        }
                            
                        break;

                    case 7:
                        if (!chars.Contains(res))
                        {
                            x1 = lcode.IndexOf(arraych[0]);
                            x2 = lcode.IndexOf(arraych[1]);
                            x3 = lcode.IndexOf(arraych[2]);
                            x4 = lcode.IndexOf(arraych[3]);
                            x5 = lcode.IndexOf(arraych[4]);
                            x6 = lcode.IndexOf(arraych[5]);
                            x7 = lcode.IndexOf(arraych[6]);
                            Console.WriteLine("\nEquivalent Code: {0}{1}{2}{3}{4}{5}{6}", code2[x1], code2[x2], code2[x3], code2[x4], code2[x5], code2[x6], code2[x7]);
                        }
                
                        else if (chars.Contains(res))
                        {
                            Console.WriteLine("ERROR!");
                        }

                        break;

                    case 8:
                        if (!chars.Contains(res))
                        {
                            x1 = lcode.IndexOf(arraych[0]);
                            x2 = lcode.IndexOf(arraych[1]);
                            x3 = lcode.IndexOf(arraych[2]);
                            x4 = lcode.IndexOf(arraych[3]);
                            x5 = lcode.IndexOf(arraych[4]);
                            x6 = lcode.IndexOf(arraych[5]);
                            x7 = lcode.IndexOf(arraych[6]);
                            x8 = lcode.IndexOf(arraych[7]);
                            Console.WriteLine("\nEquivalent Code: {0}{1}{2}{3}{4}{5}{6}{7}", code2[x1], code2[x2], code2[x3], code2[x4], code2[x5], code2[x6], code2[x7], code2[x8]);
                        }
                        else if (chars.Contains(res))
                        {
                            Console.WriteLine("ERROR!");
                        }

                        break;

                    case 9:
                        if (!chars.Contains(res))
                        {
                            x1 = lcode.IndexOf(arraych[0]);
                            x2 = lcode.IndexOf(arraych[1]);
                            x3 = lcode.IndexOf(arraych[2]);
                            x4 = lcode.IndexOf(arraych[3]);
                            x5 = lcode.IndexOf(arraych[4]);
                            x6 = lcode.IndexOf(arraych[5]);
                            x7 = lcode.IndexOf(arraych[6]);
                            x8 = lcode.IndexOf(arraych[7]);
                            x9 = lcode.IndexOf(arraych[8]);
                            Console.WriteLine("\nEquivalent Code: {0}{1}{2}{3}{4}{5}{6}{7}{8}", code2[x1], code2[x2], code2[x3], code2[x4], code2[x5], code2[x6], code2[x7], code2[x8], code2[x9]);
                        }
                        else if (chars.Contains(res))
                        {
                            Console.WriteLine("ERROR!");
                        }
                        break;

                    case 10:
                        if (!chars.Contains(res))
                        {
                            x1 = lcode.IndexOf(arraych[0]);
                            x2 = lcode.IndexOf(arraych[1]);
                            x3 = lcode.IndexOf(arraych[2]);
                            x4 = lcode.IndexOf(arraych[3]);
                            x5 = lcode.IndexOf(arraych[4]);
                            x6 = lcode.IndexOf(arraych[5]);
                            x7 = lcode.IndexOf(arraych[6]);
                            x8 = lcode.IndexOf(arraych[7]);
                            x9 = lcode.IndexOf(arraych[8]);
                            x10 = lcode.IndexOf(arraych[9]);
                            Console.WriteLine("\nEquivalent Code: {0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", code2[x1], code2[x2], code2[x3], code2[x4], code2[x5], code2[x6], code2[x7], code2[x8], code2[x9], code2[x10]);
                        }
                        else if (chars.Contains(res))
                        {
                            Console.WriteLine("Error!");
                        }

                            break;

                }
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
            Console.ReadKey();
        }
            
        }
    }

            
