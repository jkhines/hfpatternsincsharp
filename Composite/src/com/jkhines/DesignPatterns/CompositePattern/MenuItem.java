package com.jkhines.DesignPatterns.CompositePattern;

public class MenuItem extends MenuNode {
	private String name;
	private String description;
	private boolean isVegetarian;
	private double price;
	
	public MenuItem(String name, String description, boolean isVegetarian, double price) {
		this.name = name;
		this.description = description;
		this.isVegetarian = isVegetarian;
		this.price = price;
	}

	@Override
	public String getName() {
		return name;
	}

	@Override
	public String getDescription() {
		return description;
	}

	@Override
	public boolean isVegetarian() {
		return isVegetarian;
	}

	@Override
	public double getPrice() {
		return price;
	}
	
	@Override
	public void print() {
		System.out.println(getName());
		System.out.println(getDescription());
		System.out.println(isVegetarian());
		System.out.println(getPrice() + "\n");
	}
}
