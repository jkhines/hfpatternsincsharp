package com.jkhines.DesignPatterns.CompositePattern;

public class Waitress {
	private MenuNode menu;
	
	public Waitress(MenuNode menu) {
		this.menu = menu;
	}
	
	public void printMenu() {
			menu.print();
	}
}
