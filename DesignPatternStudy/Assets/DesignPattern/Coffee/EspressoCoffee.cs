using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspressoCoffee : Beverage
{
	public EspressoCoffee()
	{
		description = "Espresso coffee.";
	}
	public override float Cost()
	{
		return 5.4f;
	}
}
