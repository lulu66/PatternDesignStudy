using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasQuaterState : State
{
	private CandyMachine candyMachine;

	public HasQuaterState(CandyMachine candyMachine)
	{
		this.candyMachine = candyMachine;
	}
	public void Dispense()
	{
		Debug.Log($"candy dispensed.");
	}

	public void InjectQuater()
	{
		Debug.Log($"Quarter has been returned.");
		candyMachine.SetState(candyMachine.GetNoQuaterState());
	}

	public void InsertQuater()
	{
		Debug.Log($"You have insert a quarter.");
	}

	public void TurnCrank()
	{
		Debug.Log($"You turned, Please wait.");
		var num = Random.Range(0,10);
		if(num == 1)
		{
			candyMachine.SetState(candyMachine.GetWinnerState());
		}
		else
		{
			candyMachine.SetState(candyMachine.GetSoldState());
		}
	}
}
