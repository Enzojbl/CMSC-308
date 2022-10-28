import java.util.Scanner;
import java.util.Arrays;
import java.util.Collections;
import java.util.ArrayList;
import java.util.List;
	
public class holidays {
	public static void main(String[] args) throws Exception {
		Scanner s = new Scanner(System.in);

		// While loop
		while (true) {
			System.out.print("\nEnter number of test cases: ");
			int tstcases =	s.nextInt(); 
			
		// Use 3 Int list for arrays
            List<Integer> c1holidays = new ArrayList<>(
                                Arrays.asList(6,13,14,20,21,27,28));
            List<Integer> c2holidays = new ArrayList<>(
                                    Arrays.asList(7,13,14,20,21,27,28));
            List<Integer> c3holidays = new ArrayList<>(
                                        Arrays.asList(6,7,14,20,21,27,28));
            
		// if-else for test cases input
			if (tstcases == 3) 
			{
				System.out.println("\nNumber of Test cases: " + tstcases);
			
                 for (int i = 1; i <= tstcases; i++) 
                 {

                    System.out.print("\nNumber of Holidays: ");
                    int x = s.nextInt();
		
		// nested ifs
                    if (x > 3) 
                        {
                            System.out.println("Error!");
                            return;
                        }
                        if (x == 2)
                        {
                            System.out.print("Day of Holidays: ");
                            int addlist = s.nextInt();
                            int addlist1 = s.nextInt();
                            Collections.addAll(c1holidays, addlist, addlist1);
                        }
                       
                        if (x == 3)
                        {
                            System.out.print("Day of Holidays: ");
                            int addlist = s.nextInt();
                            int addlist1 = s.nextInt();
                            int addlist2 = s.nextInt();
                            Collections.addAll(c2holidays, addlist, addlist1, addlist2);
                        } 
                        if (x == 1)
                        {
                            System.out.print("Day of Holidays: ");
                            int addlist = s.nextInt();
                            c3holidays.add(addlist);     
                        } 
                 }
		// show input
            System.out.println("\nOutput: ");
            Collections.sort(c1holidays);
            System.out.println("\nNumber of Holidays for Test Case 1: "+ (c1holidays.size())  + (c1holidays.toString()));
            Collections.sort(c2holidays);
            System.out.println("Number of Holidays for Test Case 2: "+ (c2holidays.size())  + (c2holidays.toString()));
            Collections.sort(c3holidays);
            System.out.println("Number of Holidays for Test Case 3: "+ (c3holidays.size())  + (c3holidays.toString()));
                }
            else
            {
                System.out.println("\nTest Cases must be 3!");
            }
            break;
			  }
		}
}
