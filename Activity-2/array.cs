using System;
using System.Collections;
using System.Collections.Generic;

namespace OddArrayEven
{
class Program
{
public static void Main(string[] args)
{
int[] nums = new int[5];
List&lt;int&gt; oddNums = new List&lt;int&gt;();
List&lt;int&gt; evenNums = new List&lt;int&gt;();

Console.WriteLine(&quot;This program will display the seperate odd and even numbers in an array.&quot;);
Console.WriteLine(&quot;\n Press any key to Proceed...&quot;);
Console.ReadKey(true);
Console.Clear();

Console.WriteLine(&quot;\n ==ARRAY PROGRAM==&quot;);

for (int i = 0; i &lt; nums.Length; i++)
{
Console.Write(&quot;\n Enter element[{0}] = &quot;, i );
nums[i] = Convert.ToInt32(Console.ReadLine());

}for (int i = 0; i &lt; nums.Length; i++)
{

if (nums[i] % 2 == 0)
{
evenNums.Add(nums[i]);
}
else
{
oddNums.Add(nums[i]);
}
}

Console.WriteLine();
Console.Write(&quot;Odd Numbers: &quot;);

foreach (int i in oddNums)
{
Console.Write(i + &quot;, &quot;);
}

Console.WriteLine();
Console.Write(&quot;Even Numbers: &quot;);

foreach (int i in evenNums)
{
Console.Write(i + &quot;, &quot;);

}

Console.ReadKey();}
}
}
}
