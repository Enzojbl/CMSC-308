package com.polymorphism;

public class Note12 extends Infinix {
	  // Define a constructor that calls the superclass constructor
	  public Note12(String mlbb) {
	    super(mlbb);
	  }
	  
	  // Override the "gaming()" method
	  public void gaming() {
	    System.out.println("Gaming in " + this.mlbb + " is smooth!");
	  }
	}