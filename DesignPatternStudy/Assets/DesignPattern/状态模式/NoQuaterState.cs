using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoQuaterState : State
{
	CandyMachine candyMachine;

	public NoQuaterState(CandyMachine candyMachine)
	{
		this.candyMachine = candyMachine;
	}
	public void Dispense()
	{
		Debug.Log($"You turned, but there is no quarter.");
	}

	public void InjectQuater()
	{
		Debug.Log($"You don't have insert a quarter.");
	}

	public void InsertQuater()
	{
		Debug.Log($"You interted a quarter.");
		candyMachine.SetState(candyMachine.GetHasQuaterState());
	}

	public void TurnCrank()
	{
		Debug.Log($"Please insert a quarter first.");
	}
}
