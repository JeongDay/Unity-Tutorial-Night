using UnityEngine;

public abstract class Person : MonoBehaviour
{
    public string personName;
    public int age;

    public virtual void Walk()
    {
        // 걷는 기능
    }
    
    public virtual void Run()
    {
        // 달리는 기능
    }
    
    public virtual void Jump()
    {
        // 점프하는 기능
    }

    public abstract void PersonAction();
}