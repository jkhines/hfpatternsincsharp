package com.jkhines.DesignPatterns.CompositePattern;

import java.util.Iterator;

public class MenuNode implements Iterable<MenuNode>{
	public void add(MenuNode node) {
		throw new UnsupportedOperationException();
	}

	public void remove(MenuNode node) {
		throw new UnsupportedOperationException();
	}

	public MenuNode getChild(int i) {
		throw new UnsupportedOperationException();
	}

	public String getName() {
		throw new UnsupportedOperationException();
	}

	public String getDescription() {
		throw new UnsupportedOperationException();
	}

	public boolean isVegetarian() {
		throw new UnsupportedOperationException();
	}

	public double getPrice() {
		throw new UnsupportedOperationException();
	}
	
	public void print() {
		throw new UnsupportedOperationException();
	}

	@Override
	public Iterator<MenuNode> iterator() {
		throw new UnsupportedOperationException();
	}
}
