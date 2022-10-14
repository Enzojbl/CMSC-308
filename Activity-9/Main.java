import java.util.Scanner;

import com.java.enzo.Calculator;

class Main {
  public static void main(String[] args) {

    char operator;
    Double num1, num2;
    
    
    Scanner input = new Scanner(System.in);
    
    do {
    System.out.println("Calculator Menu");
    System.out.println("Choose an operation:");
    System.out.println("[1] Addition");
    System.out.println("[2] Subraction");
    System.out.println("[3] Multiplication");
    System.out.println("[4] Division");
    System.out.println("[5] Exponent");
    System.out.println("[6] Modulo");
    System.out.println("[7] Exit");
    
    
    operator = input.next().charAt(0);

    Calculator calcu = new Calculator();

    switch (operator) {

      case '1':
        System.out.println("Enter the augend:");
        num1 = input.nextDouble();
        System.out.println("Enter the addend:");
        num2 = input.nextDouble();
        System.out.println(calcu.addition(num1,num2));
        break;


      case '2':
        System.out.println("Enter the subtrahend:");
        num1 = input.nextDouble();
        System.out.println("Enter the minuend:");
        num2 = input.nextDouble();
        System.out.println(calcu.subtraction(num1,num2));
        break;


      case '3':
        System.out.println("Enter the multiplicand:");
        num1 = input.nextDouble();
        System.out.println("Enter the multiplier:");
        num2 = input.nextDouble();
        System.out.println(calcu.multiplication(num1,num2));
        break;


      case '4':
        System.out.println("Enter the dividend:");
        num1 = input.nextDouble();
        System.out.println("Enter the divisor:");
        num2 = input.nextDouble();
        System.out.println(calcu.division(num1,num2));
        break;
        
      case '5':
        System.out.println("Enter First Number:");
        num1 = input.nextDouble();
        System.out.println("Enter Second Number:");
        num2 = input.nextDouble();
        System.out.println(calcu.exponent(num1,num2));
        break;
    
      case '6':
        System.out.println("Enter First Number:");
        num1 = input.nextDouble();
        System.out.println("Enter Second Number:");
        num2 = input.nextDouble();
        System.out.println(calcu.modulo(num1,num2));
        break;
        
      case '7':
        System.exit(0);
        break;
        
      default:
        System.out.println("Invalid operator!");
        break;
        
    }
    break;
    } while (operator != 8);
    input.close();
  }
}