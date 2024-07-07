using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatisticDisplay : Observer, DisplayElement
{
	private float temprature;
	private float minTemprature;
	private float maxTemprature;
	private Subject weatherData;
	public StatisticDisplay(Subject weatherData)
	{
		this.weatherData = weatherData;
		this.weatherData.RegisterObserver(this);
	}
	public void Display()
	{
		Debug.Log($"temprature:{temprature}");

	}

	public void Update(Subject weatherData)
	{
		if(weatherData is WeatherData)
		{
			WeatherData data = (WeatherData)weatherData;
			this.temprature = data.GetTemprature();
			Display();

		}
	}
}
