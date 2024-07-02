using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocolateBoiler
{
	private ChocolateBoiler()
	{

	}

	private static ChocolateBoiler chocolateBoiler;

	//��Ե��߳�
	public static ChocolateBoiler GetInstance()
	{
		if(chocolateBoiler == null)
		{
			chocolateBoiler = new ChocolateBoiler();
		}
		return chocolateBoiler;
	}

}


public class ChocolateLockerBoiler
{
	private ChocolateLockerBoiler()
	{

	}

	private static ChocolateLockerBoiler chocolateBoiler;

	private static readonly object locker = new object();
	//��Զ��̣߳�˫������
	public static ChocolateLockerBoiler GetInstance()
	{
		if(chocolateBoiler == null)
		{
			lock (locker)
			{
				if (chocolateBoiler == null)
				{
					chocolateBoiler = new ChocolateLockerBoiler();
				}
			}
		}

		return chocolateBoiler;
	}

}
