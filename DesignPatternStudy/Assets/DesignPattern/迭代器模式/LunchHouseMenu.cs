using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunchHouseMenu:Menu
{
	static int MAX_ITEMS = 6;
	int numberOfItems = 0;
	MenuItem[] menuItems;

	public LunchHouseMenu()
	{
		menuItems = new MenuItem[MAX_ITEMS];

		AddItem("Vegetable soup", "tomato & leaf", true, 2.35f);
		AddItem("Meat soup", "tomato & beaf", true, 5.35f);
		AddItem("Hotdog", "onions,topped whith cheese", false, 3.6f);

	}

	public void AddItem(string name, string description, bool isVegetarian, float price)
	{
		var item = new MenuItem(name, description, isVegetarian, price);

		if (numberOfItems >= MAX_ITEMS)
			return;

		menuItems[numberOfItems++] = item;

	}

	public int GetItemCount()
	{
		return numberOfItems;
	}
	public Iterator CreateIterator()
	{
		var it = new LunchHouseIterator(menuItems);
		return it;
	}
}
