package com.jkhines.DesignPatterns.StatePattern;

public class SoldState implements State {
	GumballMachine gumballMachine;
	
	public SoldState(GumballMachine gumballMachine) {
		this.gumballMachine = gumballMachine;
	}

	@Override
	public void dispense() {
		gumballMachine.releaseBall();
		if (gumballMachine.getCount() > 0)
			gumballMachine.setState(gumballMachine.getNoQuarterState());
		else {
			System.out.println("Out of gumballs.  Refilling...");
			gumballMachine.refill(GumballValues.refillSize);
		}
	}

	@Override
	public void ejectQuarter() {
		System.out.println("Sorry, the quarter has already been accepted.");	
	}

	@Override
	public void insertQuarter() {
		System.out.println("Please wait, dispensing gumball.");
	}

	@Override
	public void turnCrank() {
		System.out.println("Crank has already been turned.");
	}
}
