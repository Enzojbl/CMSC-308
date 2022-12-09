package com.inheritance;

public class Infinix extends Android {
	  // Declare instance variable
	  protected int numRams;
	  
	  // Define a constructor that calls the superclass constructor
	  public Infinix(String model, String processor, int year, int numRams) {
	    super(model, processor, year);
	    this.numRams = numRams;
	  }
	  
	  // Define a method that prints the number of Random access memory
	  public void printRams() {
	    System.out.println("Number of RAMs: " + this.numRams);
	  }
	}