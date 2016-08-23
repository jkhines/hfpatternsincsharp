package com.jkhines.DesignPatterns.CompositePattern;

public class App {
	public static void main(String[] args) {
		MenuNode rootNode = new Menu("All Menus", "All Meals");
		
		Menu breakfastMenu  = new Menu("Pancake House", "Breakfast");
		breakfastMenu.add(new MenuItem("Item1", "The first item on the menu", false, 1.99));
		breakfastMenu.add(new MenuItem("Item2", "The second item on the mneu", false, 1.99));
		breakfastMenu.add(new MenuItem("Item3", "The third item on the muen", false, 1.99));
		breakfastMenu.add(new MenuItem("Item4", "The last item on the mune", false, 1.99));

		Menu lunchMenu = new Menu("Diner Menu", "Lunch");
		lunchMenu.add(new MenuItem("Value1", "The first hash on the menu", false, 1.99));
		lunchMenu.add(new MenuItem("Value2", "The second hash on the mneu", false, 1.99));
		lunchMenu.add(new MenuItem("Value3", "The third hash on the muen", false, 1.99));
		lunchMenu.add(new MenuItem("Value4", "The last hash on the mune", false, 1.99));

		Menu dinnerMenu = new Menu("Cafe Menu", "Dinner");		
		dinnerMenu.add(new MenuItem("Food1", "The first food on the menu", false, 1.99));
		dinnerMenu.add(new MenuItem("Food2", "The second food on tlhe mneu", false, 1.99));
		dinnerMenu.add(new MenuItem("Food3", "The third food on the muen", false, 1.99));
		dinnerMenu.add(new MenuItem("Food4", "The last food on the mune", false, 1.99));

		Menu dessertMenu = new Menu("Patisserie Menu", "Dessert");		
		dessertMenu.add(new MenuItem("Dessert1", "The first pastry on the menu", false, 1.99));
		dessertMenu.add(new MenuItem("Dessert2", "The second pastry on tlhe mneu", false, 1.99));
		dessertMenu.add(new MenuItem("Dessert3", "The third pastry on the muen", false, 1.99));
		dessertMenu.add(new MenuItem("Dessert4", "The last pastry on the mune", false, 1.99));

		lunchMenu.add(dessertMenu);
		rootNode.add(breakfastMenu);
		rootNode.add(lunchMenu);
		rootNode.add(dinnerMenu);
		
		Waitress nancy = new Waitress(rootNode);
		nancy.printMenu();
	}

}
