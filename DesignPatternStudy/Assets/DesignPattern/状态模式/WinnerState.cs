using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerState : State
{
	private CandyMachine candyMachine;

	public WinnerState(CandyMachine candyMachine)
	{
		this.candyMachine = candyMachine;
	}
	public void Dispense()
	{
		candyMachine.ReleaseCandy();

		if (candyMachine.GetCount()>0)
		{
			candyMachine.ReleaseCandy();

			if (candyMachine.GetCount()>0)
			{
				candyMachine.SetState(candyMachine.GetNoQuaterState());
			}
			else
			{
				candyMachine.SetState(candyMachine.GetSoldoutState());
				Debug.Log("candy soldout, I am sorry.");

			}
		}
		else
		{
			candyMachine.SetState(candyMachine.GetSoldoutState());
			Debug.Log("candy soldout, I am sorry.");
		}
	}

	public void InjectQuater()
	{
		Debug.Log($"quater can not be turned back now, because we we have gived you candy.");
	}

	public void InsertQuater()
	{
		Debug.Log($"you have inserted a quarter.");
	}

	public void TurnCrank()
	{
		Debug.Log($"you have turned crank.");
	}
}
