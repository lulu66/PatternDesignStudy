using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Iterator
{
	public bool HasNext();
	public MenuItem Next();
}


public class LunchHouseIterator : Iterator
{
	private MenuItem[] items;
	private int position = 0;

	public LunchHouseIterator(MenuItem[] items)
	{
		this.items = items;
	}
	public bool HasNext()
	{
		if (position >= items.Length || items[position] == null)
			return false;
		return true;
	}

	public MenuItem Next()
	{
		MenuItem item = items[position];
		position += 1;
		return item;
	}
}

public class BreakFeaseHouseIterator : Iterator
{
	private List<MenuItem> items;
	private int position;

	public BreakFeaseHouseIterator(List<MenuItem> items)
	{
		this.items = items;
	}
	public bool HasNext()
	{
		if (position >= items.Count || items[position] == null)
			return false;
		return true;
	}

	public MenuItem Next()
	{
		MenuItem item = items[position];
		position += 1;
		return item;
	}
}