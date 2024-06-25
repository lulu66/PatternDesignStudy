using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Subject
{
	public void RegisterObserver(Observer o);
	public void RemoveObserver(Observer o);

	public void NotifyObservers();
}
