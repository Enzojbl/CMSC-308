package com.encapsulation;

public class Main {

	public static void main(String[] args) {
		GreekGods god = new GreekGods();
	    
	    // Set the values of the god's instance variables
	    god.setName("Zeus");
	    god.setPosition("Chief God");
	    god.setWeapon("Thunderbolt");
	    
	    // Get the values of the god's instance variables
	    System.out.println("Name: " + god.getName());
	    System.out.println("Position: " + god.getPosition());
	    System.out.println("Weapon: " + god.getWeapon());
	  }
	}