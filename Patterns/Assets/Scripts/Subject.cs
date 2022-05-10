using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    private List<Observer> _observers = null;

    public void RegisterObserver(Observer observer)
    {
        if (_observers == null)
        {
            _observers = new List<Observer>();
        }
        _observers.Add(observer);
    }
    private void Start()
    {
        ObserverManager.Instance.RegisterSubject(this);
    }
}
