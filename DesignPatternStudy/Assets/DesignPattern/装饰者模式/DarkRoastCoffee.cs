using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//…Ó±∫øß∑»
public class DarkRoastCoffee : Beverage
{
	public DarkRoastCoffee()
	{
		description = "DarkRoast coffee.";
	}
	public override float Cost()
	{
		return 2.5f;
	}
}
