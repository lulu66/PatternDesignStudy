using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CoffeeBeverage
{
	public void PrepareRecip()
	{
		BoilWater();
		Brew();
		PourInCup();
		if(IfCustumerWant())
		{
			AddCondiments();
		}
	}

	public void BoilWater()
	{

	}

	public abstract void Brew();
	public abstract void AddCondiments();

	public void PourInCup()
	{

	}

	public virtual bool IfCustumerWant()
	{
		return true;
	}
}
