import java.util.Scanner;
import java.util.ArrayList;
import java.util.List;
	
public class Act4test {
	public static void main(String[] args) throws Exception {
		Scanner s = new Scanner(System.in);
		List<String> res = new ArrayList<String>();
		
		while (true) {
			System.out.println("Enter number of test cases:");
			int tCaseNum =	s.nextInt(); 
			
			if (tCaseNum >=  1 && tCaseNum <= 10 ) {
				System.out.println("No. of test cases" + tCaseNum);
				
				for (int i = 1; i <= tCaseNum; i++) {
                    System.out.println(String.format("Test Case #%s", i));
                    System.out.print("Enter Uber Fee:");
                    int x = s.nextInt();
                    if (x >= 1 && x <= 1000) {
                        System.out.print("Enter Grab Fee:");
                        int y = s.nextInt();
                        if (y >= 1 && y <= 1000) {
                            res.add(compareFees(x, y));
                        } else {
                            res.add("ERROR!");
                            break;
                        }
                    } else {
                        res.add("ERROR!");
                        break;
                    }
                }
                for (String string : res) {
                    System.out.println(string);
                }
                break;
            } else {
                System.out.println("Enter numbers 1-10 only!");
            }
        }
        s.close();
    }

    private static String compareFees(int xFee, int yFee) {
        if (xFee == yFee) {
            return "ANY";
        } else if (xFee < yFee) {
            return "FIRST";
        } else {
            return "SECOND";
        }
    }
}
