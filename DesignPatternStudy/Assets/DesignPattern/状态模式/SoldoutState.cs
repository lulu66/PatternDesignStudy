using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldoutState : State
{
	private CandyMachine candyMachine;

	public SoldoutState(CandyMachine candyMachine)
	{
		this.candyMachine = candyMachine;
	}

	public void Dispense()
	{
		Debug.Log($"candy is soldout.");
	}

	public void InjectQuater()
	{
		Debug.Log($"you didn't insert a quarter.");
	}

	public void InsertQuater()
	{
		Debug.Log($"candy is soldout, you can not insert a quarter.");
	}

	public void TurnCrank()
	{
		Debug.Log($"candy dispensed.");
	}
}
