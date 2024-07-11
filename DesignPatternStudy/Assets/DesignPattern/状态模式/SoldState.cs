using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldState : State
{
	private CandyMachine candyMachine;

	public SoldState(CandyMachine candyMachine)
	{
		this.candyMachine = candyMachine;
	}

	public void Dispense()
	{
		//添加赢糖果游戏
		Debug.Log("OK,this is your candy ,please take it.");
		//这样可以避免顾客付钱了，却没有candy的情况
		candyMachine.ReleaseCandy();
		if (candyMachine.GetCount() > 0)
		{
			candyMachine.SetState(candyMachine.GetNoQuaterState());
		}
		else
		{
			Debug.Log($"candy soldout.");
			candyMachine.SetState(candyMachine.GetSoldoutState());

		}
	}

	public void InjectQuater()
	{
		Debug.Log($"You have turned crank, can not returned your quarter.");
	}

	public void InsertQuater()
	{
		Debug.Log($"You have inserted a quarter,Please waiting for candy sold.");
	}

	public void TurnCrank()
	{
		Debug.Log($"You have turned crank already.");
	}
}
