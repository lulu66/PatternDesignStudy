using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyMono : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CandyMachine candyMachine = new CandyMachine(2);
        candyMachine.InsertQuarter();
        candyMachine.TurnCrunck();
        candyMachine.InsertQuarter();
        candyMachine.TurnCrunck();
        candyMachine.InjectQuarter();
        candyMachine.InsertQuarter();
        candyMachine.TurnCrunck();
    }

}
