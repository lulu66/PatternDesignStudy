using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkFoamDecocator : CondimentDecorator
{
	Beverage coffee;
	public MilkFoamDecocator(Beverage coffee)
	{
		this.coffee = coffee;
	}
	public override float Cost()
	{
		return coffee.Cost() + 1.2f;
	}

	public override string GetDescription()
	{
		description = coffee.GetDescription() + "milk foam,";
		return description;

	}
}
