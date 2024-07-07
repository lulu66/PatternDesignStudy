using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Command
{
	public void Execute();
	public void Undo();
}

public class NoCommand : Command
{
	public void Execute()
	{
		Debug.Log("No Command.");
	}

	public void Undo()
	{
		Debug.Log("No Command.");
	}
}
public class LightOnCommand : Command
{
	private Light light;
	public LightOnCommand(Light light)
	{
		this.light = light;
	}
	public void Execute()
	{
		light.On();
	}

	public void Undo()
	{
		light.Off();
	}
}

public class LightOffCommand : Command
{
	private Light light;

	public LightOffCommand(Light light)
	{
		this.light = light;
	}

	public void Execute()
	{
		light.Off();
	}

	public void Undo()
	{
		light.On();
	}
}
