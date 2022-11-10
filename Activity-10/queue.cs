using System;
using System.Collections;
using System.Collections.Generic;


namespace Queueq
{
    class Program
    {
        static void Main(string[] args)
        {


            Queue que = new Queue();
    	int b;
        string d;

            while (true) 
        {
                // menu queue
            Console.WriteLine("\nQueue MENU");
            Console.WriteLine("\n1. Add an element");
            Console.WriteLine("2. Remove front Element");
            Console.WriteLine("3. Search an Element");
            Console.WriteLine("4. Display Queue Elements");
            Console.WriteLine("5. Exit");
            
                // user input
            Console.Write("\nEnter Choice: ");
            b = int.Parse(Console.ReadLine());
			
            
             // constraints for the choices
            if (b >= 1 && b <= 5)
            {
                    if (b == 1)
                    {
                        
                        Console.WriteLine("Add an element: "); // 1 element per loop then the input will be stacked in queue
                        d = Console.ReadLine();

                        
                        que.Enqueue(d);
                        if (que.Count > 5) // when input is larger than 5 , queue will dequeue
                        {
                               que.Dequeue(); // if total size of que is 5+ the front element will be removed
                        }
                    
            }
            if (b == 2)
            {
            	Console.WriteLine("Remove front element: " + que.Dequeue());
            }
            if (b == 3)
            {
            	
            	Console.WriteLine("Search an Element: ");
            	string j = Console.ReadLine();
            	Console.WriteLine(que.Contains(j));
            }
            if (b == 4)
            {
            	foreach(string name in que)
            	{
            		
            		Console.WriteLine();
            		Console.WriteLine(name); // all added elements can be displayed
                            
            }
            }
            	if ( b == 5)
            	{
            		Environment.Exit(0);
            	}
            }
            else 
            {
            	Console.WriteLine("\nError!");
            }
            }
    }
    }
  }
  
