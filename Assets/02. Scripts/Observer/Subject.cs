using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour, ISubject
{
    public List<IObserver> observers { get; set; }
    
    void Awake()
    {
        observers = new List<IObserver>();
    }
    
    public void AddObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers.Remove(o);
    }

    public void LevelUp()
    {
        foreach (var observer in observers)
        {
            observer.Notify();
        }
    }
}