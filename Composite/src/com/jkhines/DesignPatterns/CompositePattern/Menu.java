package com.jkhines.DesignPatterns.CompositePattern;

import java.util.*;

public class Menu extends MenuNode {
	private String name;
	private String description;
	private ArrayList<MenuNode> children;
	
	public Menu(String name, String description) {
		this.name = name;
		this.description = description;
		children = new ArrayList<MenuNode>();
	}
	
	@Override
	public void add(MenuNode child) {
		children.add(child);
	}
	
	@Override
	public void remove(MenuNode child) {
		children.remove(child);
	}
	
	@Override
	public MenuNode getChild(int i) {
		return children.get(i);
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
	public void print() {
		System.out.println(name);
		System.out.println(description);
		
		for (MenuNode node : children)
			node.print();
	}

	@Override
	public Iterator<MenuNode> iterator() {
		return children.iterator();
	}
}
