package com.jkhines.DesignPatterns.StatePattern;

public class GumballMachine {
	private State hasQuarterState;
	private State noQuarterState;
	private State soldState;
	private State winnerState;
	
	private State currentState;
	private int count = 0;
	
	public GumballMachine(int count) {
		hasQuarterState = new HasQuarterState(this);
		noQuarterState = new NoQuarterState(this);
		soldState = new SoldState(this);
		winnerState = new WinnerState(this);
		
		initializeCount(count);
	}
	
	private void initializeCount(int count) {
		this.count = count;
		if (this.count > 0)
			currentState = getNoQuarterState();
		else
			refill(GumballValues.refillSize);
	}
	
	public void insertQuarter() {
		currentState.insertQuarter();
	}
	
	public void ejectQuarter() {
		currentState.ejectQuarter();
	}
	
	public void turnCrank() {
		currentState.turnCrank();
		currentState.dispense();
	}
	
	public void setState(State state) {
		currentState = state;
	}
	
	public void releaseBall()
	{
		System.out.println("A gumball comes rolling out of the slot...");
		if (count != 0)
			count--;
	}
	
	public void refill(int count) {
		System.out.println("Refilling gumballs to " + count);
		initializeCount(count);
	}
	
	public int getCount() {
		return count;
	}

	void setHasQuarterState(State hasQuarterState) {
		this.hasQuarterState = hasQuarterState;
	}

	public State getHasQuarterState() {
		return hasQuarterState;
	}

	public State getNoQuarterState() {
		return noQuarterState;
	}

	public State getSoldState() {
		return soldState;
	}

	public State getWinnerState() {
		return winnerState;
	}

}
