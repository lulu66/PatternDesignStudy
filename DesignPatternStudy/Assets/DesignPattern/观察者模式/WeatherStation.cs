using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherStation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WeatherData weatherData = new WeatherData();
        CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
        StatisticDisplay statisticDisplay = new StatisticDisplay(weatherData);
        weatherData.SetMeasurements(31.2f,25.1f,30.1f);
        weatherData.SetMeasurements(29.0f, 56.5f, 40.1f);
        weatherData.SetMeasurements(13.0f, 80.0f, 70.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
