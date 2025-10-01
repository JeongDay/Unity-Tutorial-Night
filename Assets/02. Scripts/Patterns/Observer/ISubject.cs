using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    List<IObserver> observers { get; set; }

    void AddObserver(IObserver o);
    void RemoveObserver(IObserver o);
}