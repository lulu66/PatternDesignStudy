using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMono : MonoBehaviour
{
    void Start()
    {
        //体现针对接口编程
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
