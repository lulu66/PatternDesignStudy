using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Turkey
{
	public void Gooble();
	public void Walk();

}

public class RedTurkey : Turkey
{
	public void Gooble()
	{
		Debug.Log("Red turkey is goobling...");
	}

	public void Walk()
	{
		Debug.Log("I can walk short distance.");

	}
}
public class TurkeyAdaptor : Duck2
{
	Turkey turkey;
	public TurkeyAdaptor(Turkey turkey)
	{
		this.turkey = turkey;
	}
	public void Fly()
	{
		for(int i=0; i<5; i++)
		{
			turkey.Walk();
		}
	}

	public void Quak()
	{
		turkey.Gooble();
	}
}
