using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface FlyBehavior
{
	public void Fly();
}

public class FlyWithRock : FlyBehavior
{
	public void Fly()
	{
		Debug.Log($"Fly with Rockit.");
	}
}

public class FlyWithWings : FlyBehavior
{
	public void Fly()
	{
		Debug.Log($"Fly with wings.");
	}
}

public class FlyNoWay : FlyBehavior
{
	public void Fly()
	{
		Debug.Log("Fly no way.");
	}
}
