using System;
using UnityEngine;

public class DataClass : EventArgs
{
    public string dataName;
    public int dataValue;

    public DataClass(string dataName, int dataValue)
    {
        this.dataName = dataName;
        this.dataValue = dataValue;
    }
}

public class StudyEventHandler : MonoBehaviour
{
    public event EventHandler<DataClass> handler;
    
    void OnEnable()
    {
        handler += StartEvent;
    }

    void OnDisable()
    {
        handler -= StartEvent;
    }

    void Start()
    {
        DataClass data1 = new DataClass("Data1", 10);
        DataClass data2 = new DataClass("Data2", 20);
        
        handler?.Invoke(this, data1);
        handler?.Invoke(this, data2);
    }

    private void StartEvent(object o, DataClass e)
    {
        // var data = (DataClass)e;
        Debug.Log($"게임 시작 : {e.dataName}, {e.dataValue}");
    }
}