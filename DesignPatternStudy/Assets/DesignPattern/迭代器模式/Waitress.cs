using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waitress
{
	private Menu breakfeastMenu;
	private Menu lunchMenu;

	public Waitress(Menu breakfeastMenu, Menu lunchMenu)
	{
		this.breakfeastMenu = breakfeastMenu;
		this.lunchMenu = lunchMenu;
	}

	public void PrintMenus()
	{
		var it1 = breakfeastMenu.CreateIterator();
		var it2 = lunchMenu.CreateIterator();
		PrintMenu(it1);
		PrintMenu(it2);
	}

	public void PrintBreakfeastMenu()
	{
		var it = breakfeastMenu.CreateIterator();
		PrintMenu(it);

	}

	public void PrintLunchMenu()
	{
		var it = lunchMenu.CreateIterator();
		PrintMenu(it);

	}

	private void PrintMenu(Iterator it)
	{
		while (it.HasNext())
		{
			var item = it.Next();

			Debug.Log($"{item.GetName()}, {item.GetDescription()}, {item.GetPrice()}, {item.IsVegetarian()}");
		}
	}
}
