package com.proglang;

public abstract class GreekGodss {

	protected String name;
	protected int age;
	  
	 
	  public abstract void makeKnown();
	  
	  
	  public void talk() {
	    System.out.println(this.name + " is talking.");
	  }
	}