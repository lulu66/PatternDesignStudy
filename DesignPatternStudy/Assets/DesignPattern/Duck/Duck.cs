using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Duck
{
	public abstract void Swin();     //��Ӿ
	public abstract void Display(); //�������

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
	//��װ��̬�仯����Ϊ
	protected QuackBehavior quackBehavior;
	protected FlyBehavior flyBehavior;
}

