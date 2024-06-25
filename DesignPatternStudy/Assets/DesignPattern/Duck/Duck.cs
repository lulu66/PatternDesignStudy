using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Duck
{
	public abstract void Swin();     //”Œ”æ
	public abstract void Display(); //Õ‚π€√Ë ˆ

	public void PerformQuack()
	{
		quackBehavior.Quack();
	}

	public void PerformFly()
	{
		flyBehavior.Fly();
	}

	public void SetQuackBehavior(QuackBehavior qb)
	{
		quackBehavior = qb;
	}

	public void SetFlyBehavior(FlyBehavior fb)
	{
		flyBehavior = fb;
	}
	protected QuackBehavior quackBehavior;
	protected FlyBehavior flyBehavior;
}

