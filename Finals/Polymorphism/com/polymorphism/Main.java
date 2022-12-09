package com.polymorphism;

public class Main {

	public static void main(String[] args) {
		// Create an array of Infinix models
	    Infinix[] models = {
	      new Note12("G96"),
	      new Zero5G("D1080"),
	      new Hot20S("20S")
	    };
	    
	    // Call the "gaming()" method on each object in the array
	    for (Infinix phone : models) {
	      phone.gaming();
	    }
	  }
	}