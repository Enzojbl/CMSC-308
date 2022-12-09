package com.polymorphism;

public class Zero5G extends Infinix {
	  // Define a constructor that calls the superclass constructor
	  public Zero5G(String mlbb) {
	    super(mlbb);
	  }
	  
	  // Override the "gaming()" method
	  public void gaming() {
	    System.out.println("Gaming in " + this.mlbb + " is awesome!");
	  }
	}