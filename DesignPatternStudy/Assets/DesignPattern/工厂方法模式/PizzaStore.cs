using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PizzaStore
{

	protected PizzaIngredientFactory pizzaIngredientFactory;
	public void OrderPizza(string type)
	{
		Pizza pizza = CreatePizza(type);
		pizza.Prepare();
		pizza.Bake();
		pizza.Cut();
		pizza.Box();

	}

	public abstract Pizza CreatePizza(string type);
}

public class NYPizzaStore : PizzaStore
{
	public NYPizzaStore()
	{
		pizzaIngredientFactory = new NYPizzaIngredientFactory();
	}
	public override Pizza CreatePizza(string type)
	{
		Pizza pizza = null;
		switch(type)
		{
			case "Cheese":
				pizza = new NYStyleCheesePizza(pizzaIngredientFactory);
				break;
		}
		return pizza;
	}
}

public class ChicagoPizzaStore : PizzaStore
{
	public ChicagoPizzaStore()
	{
		pizzaIngredientFactory = new ChicagoPizzaiIngredientFactory();
	}
	public override Pizza CreatePizza(string type)
	{
		Pizza pizza = null;
		switch (type)
		{
			case "Cheese":
				pizza = new ChicagoStyleCheesePizza(pizzaIngredientFactory);
				break;
		}
		return pizza;
	}
}