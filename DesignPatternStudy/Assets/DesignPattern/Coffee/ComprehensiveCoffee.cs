using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ۺϿ���
public class ComprehensiveCoffee : Beverage
{
	public ComprehensiveCoffee()
	{
		description = "Comprehensive coffee.";
	}
	public override float Cost()
	{
		return 1.0f;
	}
}
