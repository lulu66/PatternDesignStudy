using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMono : MonoBehaviour
{
    void Start()
    {
        //Ë«±¶Å£ÄÌÄ¦¿¨Éî±º¿§·È
        Beverage coffee = new DarkRoastCoffee();
        Debug.Log($"coffee name : {coffee.GetDescription()}, coffee cost : {coffee.Cost()}");

        coffee = new MilkDecorator(coffee);
        coffee = new MilkDecorator(coffee);
        coffee = new MoccaDecorator(coffee);
        Debug.Log($"coffee name : {coffee.GetDescription()}, coffee cost : {coffee.Cost()}");
    }


}
