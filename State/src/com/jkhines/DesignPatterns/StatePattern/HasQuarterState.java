package com.jkhines.DesignPatterns.StatePattern;

import java.util.*;

public class HasQuarterState implements State {
	GumballMachine gumballMachine;
	Random random = new Random(System.currentTimeMillis());
	
	public HasQuarterState(GumballMachine gumballMachine) {
		this.gumballMachine = gumballMachine;
	}

	@Override
	public void dispense() {
		System.out.println("No gumball dispensed.");
	}

	@Override
	public void ejectQuarter() {
		System.out.println("Quarter returned.");
		gumballMachine.setState(gumballMachine.getNoQuarterState());		
	}

	@Override
	public void insertQuarter() {
		System.out.println("You can't insert another quarter.");
	}

	@Override
	public void turnCrank() {
		System.out.println("You turned the crank...");
		int winner = random.nextInt(10);

		if ((winner == 1) && (gumballMachine.getCount() > 1))
			gumballMachine.setState(gumballMachine.getWinnerState());
		else
			gumballMachine.setState(gumballMachine.getSoldState());		
	}
}
