using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandMono : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Light light = new Light();
        Command lightOnCommand = new LightOnCommand(light);
        Command lightOffCommand = new LightOffCommand(light);
        RemoteControl remoteContrl = new RemoteControl();
        remoteContrl.SetCommand(0,lightOnCommand, lightOffCommand);
        remoteContrl.GetCommandInfo();

        remoteContrl.OnButtonPressed(0);
        remoteContrl.OffButtonPressed(0);

        remoteContrl.OnButtonPressed(5);
        remoteContrl.OffButtonPressed(5);

    }

}
