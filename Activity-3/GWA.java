import java.util.Scanner;

public class GWA {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        float grscience, grenglish, grhistory, grmath;

        System.out.println("Enter Your Grades:");
        System.out.print("Science : ");
        grscience = s.nextFloat();
        System.out.print("English : ");
        grenglish = s.nextFloat();
        System.out.print("History : ");
        grhistory = s.nextFloat();
        System.out.print("Math    : ");
        grmath = s.nextFloat();
        s.close();

        float average = computeAverage(grscience, grenglish, grhistory, grmath);

        System.out.println("Average: " + average);

        if (average > 100f) {
            System.out.println("Invalid Grade");
        } else if (average <= 100f && average >= 98f) {
            System.out.println("With Highest Honors");
        } else if (average <= 97.99f && average >= 95f) {
            System.out.println("With High Honors");
        } else if (average <= 94.99f && average >= 90f) {
            System.out.println("With Honors");
        } else if (average <= 89.99f && average >= 75f) {
            System.out.println("Passed");
        } else {
            System.out.println("Failed");
        }
    }

    private static float computeAverage(float gr1, float gr2, float gr3, float gr4) {
        float average = (gr1 + gr2 + gr3 + gr4) / 4;

        return average;
    }
}
