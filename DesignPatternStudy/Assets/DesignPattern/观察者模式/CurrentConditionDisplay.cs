using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentConditionDisplay : Observer, DisplayElement
{
	private float temprature;
	private float humidity;

	private Subject weatherData;
	public CurrentConditionDisplay(Subject weatherData)
	{
		this.weatherData = weatherData;
		this.weatherData.RegisterObserver(this);
	}

	public void Display()
	{
		Debug.Log($"temprature:{temprature}, humidity:{humidity}");
	}

	public void Update(Subject weatherData)
	{
		if(weatherData is WeatherData)
		{
			WeatherData data = (WeatherData)weatherData;
			this.temprature = data.GetTemprature();
			this.humidity = data.GetHumidity();
			Display();

		}
	}
}
