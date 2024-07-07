using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ÒûÁÏÀà
public abstract class Beverage
{
	protected string description;
	public virtual string GetDescription()
	{
		return description;
	}

	public abstract float Cost();
}
