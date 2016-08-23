package com.jkhines.DesignPatterns.StatePattern;

public interface State {
	public void dispense();
	public void ejectQuarter();
	public void insertQuarter();
	public void turnCrank();
}
