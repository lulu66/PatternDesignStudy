using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoccaDecorator : CondimentDecorator
{
	Beverage coffee;

	public MoccaDecorator(Beverage coffee)
	{
		this.coffee = coffee;
	}
	public override float Cost()
	{
		return coffee.Cost() + 0.23f;
	}


	public override string GetDescription()
	{
		description = coffee.GetDescription() + "mocca," + GetAdditionalInfo();
		return description;

	}

	//新的方法/行为
	public string GetAdditionalInfo()
	{
		return "this is middle size coffee, Please enjoy it.";
	}
}
