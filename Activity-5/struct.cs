using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace InkColor
{
public class Program
{

struct BoardMaker
{
public string inkColor;
public int inkContent;
}
public static void Main(string[] args)
{
BoardMaker board;
board.inkColor = &quot;Black&quot;;
board.inkContent = 20;
int choice = 0;
while (choice != 4)
{
start:
Console.WriteLine(&quot;==MENU==&quot;);
Console.WriteLine(&quot;1. Display Info&quot;);
Console.WriteLine(&quot;2. Change Color&quot;);
Console.WriteLine(&quot;3. Refill&quot;);
Console.WriteLine(&quot;4. Write&quot;);
Console.Write(&quot;Enter the number of your choice: &quot;);
choice = int.Parse(Console.ReadLine());
if (choice == 1)
{
Console.WriteLine(&quot;Ink Color: {0}&quot;, board.inkColor);
Console.WriteLine(&quot;Ink Content: {0}ml\n&quot;, board.inkContent);
Console.ReadKey();
goto start;
}
if (choice == 2)
{
if (board.inkContent == 0)
{
Console.WriteLine(&quot;You Can&#39;t change color if the link is empty\n&quot;);
}
else
{
Console.Write(&quot;Change color to:&quot; + board.inkColor);
}
Console.ReadKey();
goto start;
}
else if (choice == 3)
{
board.inkContent = 20;
Console.WriteLine(&quot;Your ink is now Refilled!\n&quot;);
Console.ReadKey();
goto start;
}
if (choice == 4)
{
if (board.inkContent == 0)
{
Console.WriteLine(&quot;You don&#39;t have enough ink, please refill.\n&quot;);
Console.ReadKey();

goto start;
}
else
{
board.inkContent -= 10;
Console.WriteLine(&quot;You Wrote\n&quot;);
Console.ReadKey();
goto start;
}
}
}
}
}
}
