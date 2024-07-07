using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Duck2
{

	public void Quak();
	public void Fly();
}

public class RedDuck : Duck2
{
	public void Fly()
	{
		Debug.Log("I can fly long distance.");

	}

	public void Quak()
	{
		Debug.Log("red duck is quaking...");

	}
}
