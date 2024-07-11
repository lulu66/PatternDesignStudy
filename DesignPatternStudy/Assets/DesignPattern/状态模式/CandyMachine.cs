using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyMachine
{
	private int candyCount = 0;
	private State state;

	private State noQuarterState;
	private State hasQuarterState;
	private State soldState;
	private State soldoutState;
	private State winnerState;


	public CandyMachine(int candyCount)
	{
		this.candyCount = candyCount;

		noQuarterState = new NoQuaterState(this);

		hasQuarterState = new HasQuaterState(this);

		soldState = new SoldState(this);

		winnerState = new WinnerState(this);

		if(this.candyCount > 0)
		{
			state = noQuarterState;
		}
		else
		{
			state = soldoutState;
		}
	}

	public void InsertQuarter()
	{
		state.InsertQuater();
	}

	public void InjectQuarter()
	{
		state.InjectQuater();
	}

	public void TurnCrunck()
	{
		state.TurnCrank();
		state.Dispense();
	}

	public void ReleaseCandy()
	{
		Debug.Log($"Release a candy.");
		if(candyCount != 0)
		{
			candyCount = candyCount - 1;
		}
	}

	public int GetCount()
	{
		return candyCount;
	}

	public void ReFill(int count)
	{
		candyCount = count;
		state = noQuarterState;
	}
	public void SetState(State state)
	{
		this.state = state;
	}

	public State GetCurrentState()
	{
		return state;
	}
	public State GetNoQuaterState()
	{
		return noQuarterState;
	}

	public State GetHasQuaterState()
	{
		return hasQuarterState;
	}

	public State GetSoldState()
	{
		return soldState;
	}

	public State GetSoldoutState()
	{
		return soldoutState;
	}

	public State GetWinnerState()
	{
		return winnerState;
	}
}
