using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pizza
{
	protected string name;
	protected Dough dough;//√ÊÕ≈
	protected Sauce sauce;//Ω¥
	protected PizzaIngredientFactory pizzaIngredientFactory;

	protected List<string> toppings = new List<string>();

	public abstract void Prepare();
	public virtual void Bake()
	{
		Debug.Log("Baking for 25 mimutes at 180.");

	}

	public virtual void Cut()
	{
		Debug.Log("Cutting pizza into 8 pieces.");

	}

	public virtual void Box()
	{
		Debug.Log("Place pizza in official PizzaStore box.");

	}

	public string GetName()
	{
		return name;
	}
}


public class NYStyleCheesePizza : Pizza
{
	public NYStyleCheesePizza(PizzaIngredientFactory pizzaIngredientFactory)
	{
		name = "  NY Cheese Pizza";
		this.pizzaIngredientFactory = pizzaIngredientFactory;
	}

	public override void Prepare()
	{
		dough = pizzaIngredientFactory.CreateDough();
		Debug.Log($"Adding dough: {dough.GetName()}");
		sauce = pizzaIngredientFactory.CreateSauce();
		Debug.Log($"Adding sauce: {sauce.GetName()}");
		toppings.Add("New York Style topping 1.");
		toppings.Add("New York Style topping 2.");
		toppings.Add("New York Style topping 3.");
		Debug.Log($"Adding toppings....");
		foreach (var topping in toppings)
		{
			Debug.Log($"{topping}");
		}
	}
	public override void Bake()
	{
		Debug.Log("Baking for 15 mimutes at 200.");
	}
}

public class ChicagoStyleCheesePizza : Pizza
{
	public ChicagoStyleCheesePizza(PizzaIngredientFactory pizzaIngredientFactory)
	{
		name = "Chicago Cheese Pizza";
		this.pizzaIngredientFactory = pizzaIngredientFactory;

	}
	public override void Prepare()
	{
		dough = pizzaIngredientFactory.CreateDough();
		Debug.Log($"Adding dough: {dough.GetName()}");
		sauce = pizzaIngredientFactory.CreateSauce();
		Debug.Log($"Adding sauce: {sauce.GetName()}");
		toppings.Add("Chicago Style topping 1.");
		toppings.Add("Chicago Style topping 2.");
		toppings.Add("Chicago Style topping 3.");
		Debug.Log($"Adding toppings....");
		foreach (var topping in toppings)
		{
			Debug.Log($"{topping}");
		}
	}
	public override void Cut()
	{
		Debug.Log("cut into squre shape and 6 pieces.");

	}
}
