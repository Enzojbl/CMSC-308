package com.polymorphism;

public class Hot20S extends Infinix {
	  // Define a constructor that calls the superclass constructor
	  public Hot20S(String mlbb) {
	    super(mlbb);
	  }
	  
	  // Override the "gaming()" method
	  public void gaming() {
	    System.out.println("Gaming in " + this.mlbb + " is amazing!");
	  }
	}