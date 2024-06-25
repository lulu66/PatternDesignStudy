using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMono : MonoBehaviour
{
    void Start()
    {
        Duck duck = new ModelDuck();
        duck.Swin();
        duck.Display();
        duck.PerformFly();
        duck.PerformQuack();
        duck.SetFlyBehavior(new FlyNoWay());
        duck.PerformFly();
    }

    void Update()
    {
        
    }
}
