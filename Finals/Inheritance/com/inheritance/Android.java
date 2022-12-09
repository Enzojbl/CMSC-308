package com.inheritance;

public class Android {
	protected String model;
	  protected String processor;
	  protected int year;
	  
	  // Define a constructor
	  public Android(String model, String processor, int year) {
	    this.model = model;
	    this.processor = processor;
	    this.year = year;
	  }
	  
	  // Define a method that prints the android's information
	  public void printInfo() {
	    System.out.println("Model: " + this.model);
	    System.out.println("Processor: " + this.processor);
	    System.out.println("Year: " + this.year);
	  }
	}