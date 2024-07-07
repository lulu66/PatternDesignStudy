using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface QuackBehavior
{
	public void Quack();
}

public class QuackNoVoice : QuackBehavior
{
	public void Quack()
	{
		Debug.Log($"Quack but no voice.");
	}
}

public class QuackGagaVoice : QuackBehavior
{
	public void Quack()
	{
		Debug.Log($"Quack with gaga voice.");
	}
}

public class QuackZhizhiVoice : QuackBehavior
{
	public void Quack()
	{
		Debug.Log($"Quack with zhizhi voice.");
	}
}

