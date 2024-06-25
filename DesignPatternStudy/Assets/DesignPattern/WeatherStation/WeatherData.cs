using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//有推和拉两种方式，这里实现拉的方式
public class WeatherData : Subject
{

	private List<Observer> observers;
	private float temprature;
	private float humidity;
	private float pressure;
	private bool changed;
	public WeatherData()
	{
		observers = new List<Observer>();
	}
	public void NotifyObservers()
	{
		if(changed)
		{
			for (int i = 0; i < observers.Count; i++)
			{
				observers[i].Update(this);
			}
		}
		changed = false;
	}

	public void RegisterObserver(Observer o)
	{
		observers.Add(o);
	}

	public void RemoveObserver(Observer o)
	{
		if(!observers.Contains(o))
		{
			observers.Remove(o);
		}
	}

	public void MeasurementChanged()
	{
		SetChanged();
		NotifyObservers();
	}

	public void SetMeasurements(float temp, float humid, float press)
	{
		temprature = temp;
		humidity = humid;
		pressure = press;
		MeasurementChanged();
	}

	public void SetChanged()
	{
		changed = true;
	}

	public float GetTemprature()
	{
		return temprature;
	}

	public float GetHumidity()
	{
		return humidity;
	}

	public float GetPressure()
	{
		return pressure;
	}
}
