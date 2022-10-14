package com.java.enzo;

public class Calculator {
     // operation methods
     public String addition(double num1, double num2)
      {
        double res = num1 + num2;
        String result = String.format("The sum of %s and %s is %s", num1, num2, res);
        return result;
    }
    public String subtraction(double num1, double num2)
      {
        double res = num1 - num2;
        String result = String.format("The difference of %s and %s is %s", num1, num2, res);
        return result;
    }
    public String multiplication(double num1, double num2)
      {
        double res = num1 * num2;
        String result = String.format("The product of %s and %s is %s", num1, num2, res);
        return result;
    }
    public String division(double num1, double num2)
      {
        double res = num1 / num2;
        String result = String.format("The quotient of %s and %s is %s", num1, num2, res);
        return result;
    }
    public String exponent(double num1, double num2)
      {
        double res = Math.pow(num1, num2);
        String result = String.format("The exponent of %s and %s is %s", num1, num2, res);
        return result;
    }
    public String modulo(double num1, double num2)
      {
        double res = num1 % num2;
        String result = String.format("The remainder of %s and %s is %s", num1, num2, res);
        return result;
    }
}
