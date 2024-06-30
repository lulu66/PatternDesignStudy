using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Dough
{
	protected string name;
	public string GetName()
	{
		return name;
	}
}

public class NYDough:Dough
{
	public NYDough()
	{
		name = "NewYork dough";
	}
}

public class ChicagoDough:Dough
{
	public ChicagoDough()
	{
		name = "Chicago dough";
	}
}

public abstract class Sauce 
{
	protected string name;
	public string GetName()
	{
		return name;
	}
}


public class NYSauce:Sauce
{
	public NYSauce()
	{
		name = "NewYork sauce.";
	}
}

public class ChicagoSauce:Sauce
{
	public ChicagoSauce()
	{
		name = "Chicago sauce";
	}
}
//pizza原料工厂(抽象工厂)
public interface PizzaIngredientFactory
{
	public Dough CreateDough();
	public Sauce CreateSauce();


}

public class NYPizzaIngredientFactory : PizzaIngredientFactory
{
	public Dough CreateDough()
	{
		return new NYDough();
	}

	public Sauce CreateSauce()
	{
		return new NYSauce();
	}
}

public class ChicagoPizzaiIngredientFactory : PizzaIngredientFactory
{
	public Dough CreateDough()
	{
		return new ChicagoDough();
	}

	public Sauce CreateSauce()
	{
			return new ChicagoSauce();
	}
}
