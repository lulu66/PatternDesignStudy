using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaStoreMono : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PizzaStore pizzaStore = new NYPizzaStore();
        pizzaStore.OrderPizza("Cheese");

        pizzaStore = new ChicagoPizzaStore();
        pizzaStore.OrderPizza("Cheese");

    }

}
