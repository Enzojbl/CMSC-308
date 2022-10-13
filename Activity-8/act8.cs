using System;
using System.Collections.Generic;

namespace act8
{
	class Program
	{
		public static void Main(string[] args)
		{
			HashSet<int> myhs1 = new HashSet<int>();
			HashSet<int> myhs2 = new HashSet<int>();
			
			HashSet<int> myhs3 = new HashSet<int>();
			HashSet<int> myhs4 = new HashSet<int>();
			
			HashSet<int> myhs5 = new HashSet<int>();
			HashSet<int> myhs6 = new HashSet<int>();
			
			
            Console.WriteLine("====HashSet 1====");
            for (int i = 0; i < 5; i++)
            {
            	Console.Write("Element {0} :", i);
            	int x = int.Parse(Console.ReadLine());
            	
            	myhs1.Add(x);
            	myhs3.Add(x);
            	myhs5.Add(x);
            }
            Console.WriteLine("\n====HashSet 2====");
            for (int i = 0; i < 5; i++)
            {
            	Console.Write("Element {0} :", i);
            	int x = int.Parse(Console.ReadLine());
            	
            	myhs2.Add(x);
            	myhs4.Add(x);
            	myhs6.Add(x);
            	
            }
            
            myhs1.UnionWith(myhs2);
            
            Console.Write("\nUNION: ");
            foreach (var i in myhs1)
            {
                Console.Write(" " + i);
                
            }

            myhs3.IntersectWith(myhs4);
            Console.Write("\nINTERSECTION: ");
            foreach (var i in myhs3)
            {
                Console.Write(" " + i); ;
            }

            myhs5.ExceptWith(myhs6);
            Console.Write("\nSET DIFFERENCE: ");
            foreach (var i in myhs5)
            {
                Console.Write(" " + i);
            }
            Console.ReadKey();
		}
	}
}
