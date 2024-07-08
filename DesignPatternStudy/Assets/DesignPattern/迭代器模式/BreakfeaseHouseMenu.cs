using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakfeaseHouseMenu:Menu
{
	List<MenuItem> menuItems;

	public BreakfeaseHouseMenu()
	{
		menuItems = new List<MenuItem>();

		AddItem("Breakfeast1", "made with fresh fish", false, 4.99f);
		AddItem("Breakfeast2", "made with fresh potato", true, 2.99f);
		AddItem("Breakfeast3", "made with fresh milk", false, 3.99f);

	}

	public void AddItem(string name, string description, bool isVegetarian, float price)
	{
		var item = new MenuItem(name, description,isVegetarian,price);

		menuItems.Add(item);
	}

	public Iterator CreateIterator()
	{
		var it = new BreakFeaseHouseIterator(menuItems);
		return it;
	}
}
