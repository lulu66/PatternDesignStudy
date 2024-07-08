using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IteratorMono : MonoBehaviour
{
    void Start()
    {
        Menu breakfeastMenu = new BreakfeaseHouseMenu();
        Menu lunchMenu = new LunchHouseMenu();
        Waitress waitress = new Waitress(breakfeastMenu, lunchMenu);
        waitress.PrintMenus();
    }

}
