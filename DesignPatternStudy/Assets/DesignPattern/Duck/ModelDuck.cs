using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelDuck : Duck
{
	public ModelDuck()
	{
		quackBehavior = new QuackGagaVoice();
		flyBehavior = new FlyWithRock();
	}
	public override void Display()
	{
		Debug.Log($"I have green head, yellow mouth.");

	}

	public override void Swin()
	{
		Debug.Log($"I can swin in the water.");

	}


}
