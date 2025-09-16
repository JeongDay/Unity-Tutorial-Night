using UnityEngine;

public class Student : Person
{
    public override void Walk()
    {
        // 가방을 갖고 걷는 기능
    }
    
    // Run()하는 기능
    
    public override void Jump()
    {
        base.Jump();
        // 힘껏
        Debug.Log("힘껏 점프");
    }

    public override void PersonAction()
    {
        // base.PersonAction(); // X
        
        // 공부하는 기능
    }
}