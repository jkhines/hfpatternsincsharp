package com.jkhines.DesignPatterns.StatePattern;

public class App {
	public static void main(String[] args) {
		GumballMachine gumballMachine = new GumballMachine(5);

		// 1
		gumballMachine.insertQuarter();
		gumballMachine.turnCrank();
		
		// 2
		gumballMachine.insertQuarter();
		gumballMachine.turnCrank();
		
		// 3
		gumballMachine.insertQuarter();
		gumballMachine.turnCrank();
		
		// 4
		gumballMachine.insertQuarter();
		gumballMachine.turnCrank();
		
		// 5
		gumballMachine.insertQuarter();
		gumballMachine.turnCrank();
		
		// 6
		gumballMachine.insertQuarter();
		gumballMachine.turnCrank();
	}
}
