using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoyMilkDecorator : CondimentDecorator
{
	Beverage coffee;

	public SoyMilkDecorator(Beverage coffee)
	{
		this.coffee = coffee;
	}
	public override float Cost()
	{
		return coffee.Cost() + 2.1f;
	}

	public override string GetDescription()
	{
		description = coffee.GetDescription() + "soy milk";
		return description;
	}
}
