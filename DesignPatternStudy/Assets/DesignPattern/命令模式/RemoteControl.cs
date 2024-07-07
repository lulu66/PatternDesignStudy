using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
public class RemoteControl
{
	Command[] onCommands;
	Command[] offCommands;

	public RemoteControl()
	{
		onCommands = new Command[7];
		offCommands = new Command[7];
		Command noCommand = new NoCommand();
		for(int i=0; i<7; i++)
		{
			onCommands[i] = new NoCommand();
			offCommands[i] = new NoCommand();
		}
	}

	public void SetCommand(int slot, Command onCommand, Command offcommand)
	{
		onCommands[slot] = onCommand;
		offCommands[slot] = offcommand;
	}

	public void OnButtonPressed(int slot)
	{
		onCommands[slot].Execute();
	}

	public void OffButtonPressed(int slot)
	{
		offCommands[slot].Execute();
	}

	public void GetCommandInfo()
	{
		string info = "command info as below:";

		for (int i = 0; i < 7; i++)
		{
			info += ($"slot {i} : {onCommands[i].GetType().Name} ; {offCommands[i].GetType().Name}");
		}
		Debug.Log(info);
	}
}
