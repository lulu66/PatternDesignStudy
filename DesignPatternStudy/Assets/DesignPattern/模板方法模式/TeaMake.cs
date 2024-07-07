using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaMake : CoffeeBeverage
{
	public override void AddCondiments()
	{
		Debug.Log("Add Tea bag.");

	}

	public override void Brew()
	{
		Debug.Log("Tea Brew.");

	}

	public override bool IfCustumerWant()
	{
		return false;
	}
}
