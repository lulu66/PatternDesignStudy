using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Duck
{
	public abstract void Swin();     //游泳
	public abstract void Display(); //外观描述

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
	//封装动态变化的行为
	protected QuackBehavior quackBehavior;
	protected FlyBehavior flyBehavior;
}

