using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItem
{
	string name;
	string description;
	bool vegetarian;
	float price;

	public MenuItem(string name, string description, bool vegetarian, float price)
	{
		this.name = name;
		this.description = description;
		this.vegetarian = vegetarian;
		this.price = price;
	}

	public string GetName()
	{
		return name;
	}

	public string GetDescription()
	{
		return description;
	}

	public float GetPrice()
	{
		return price;
	}

	public bool IsVegetarian()
	{
		return vegetarian;
	}
}

public interface Menu
{
	public Iterator CreateIterator();
}
