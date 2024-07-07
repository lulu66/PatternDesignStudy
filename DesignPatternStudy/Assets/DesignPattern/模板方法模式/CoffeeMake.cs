using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMake : CoffeeBeverage
{
	public override void AddCondiments()
	{
		Debug.Log("Add Suggar.");
	}

	public override void Brew()
	{
		Debug.Log("Brew Coffee.");

	}
}
