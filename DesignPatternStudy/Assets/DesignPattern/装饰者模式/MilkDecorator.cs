using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkDecorator : CondimentDecorator
{
	Beverage coffee;
	public MilkDecorator(Beverage coffee)
	{
		this.coffee = coffee;
	}
	public override float Cost()
	{
		return coffee.Cost() + 0.99f;
	}

	public override string GetDescription()
	{
		description = coffee.GetDescription() + "milk,";
		return description;

	}
}
