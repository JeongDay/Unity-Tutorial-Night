using UnityEngine;

public class PlayerSKill : MonoBehaviour, IObserver
{
    public Subject subject;

    void OnEnable()
    {
        subject.AddObserver(this);
    }
    
    void OnDisable()
    {
        subject.RemoveObserver(this);
    }
    
    public void Notify()
    {
        Debug.Log("스킬 포인트 증가");
    }
}

public class PlayerStat : MonoBehaviour, IObserver
{
    public Subject subject;
    
    void OnEnable()
    {
        subject.AddObserver(this);
    }
    
    void OnDisable()
    {
        subject.RemoveObserver(this);
    }
    
    public void Notify()
    {
        Debug.Log("스탯 포인트 증가");
    }
}