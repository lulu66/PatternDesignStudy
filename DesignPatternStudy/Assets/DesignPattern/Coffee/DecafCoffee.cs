using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�Ϳ����򿧷�
public class DecafCoffee : Beverage
{
	public DecafCoffee()
	{
		description = "Decaf coffee.";
	}
	public override float Cost()
	{
		return 3.4f;
	}
}
