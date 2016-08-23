package com.jkhines.DesignPatterns.StatePattern;

public class WinnerState implements State {
	GumballMachine gumballMachine;
	
	public WinnerState(GumballMachine gumballMachine) {
		this.gumballMachine = gumballMachine;
	}

	@Override
	public void dispense() {
		System.out.println("CONGRATULATIONS!  You're a WINNER!");
		gumballMachine.releaseBall();
		if (gumballMachine.getCount() == 0) {
			System.out.println("SORRY!  We're out of gumballs.  Please redeem this coupon for a free gumball at the snack counter.");
			gumballMachine.refill(GumballValues.refillSize);
		} else {
			gumballMachine.releaseBall();
			if (gumballMachine.getCount() > 0)
				gumballMachine.setState(gumballMachine.getNoQuarterState());
			else {
				System.out.println("We are now out of gumballs.  Thanks for playing!");
				gumballMachine.refill(GumballValues.refillSize);				
			}
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
