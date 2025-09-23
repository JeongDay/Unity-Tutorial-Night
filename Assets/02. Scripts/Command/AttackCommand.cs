using UnityEngine;

public class AttackCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("공격하는 기능");
    }

    public void Cancel()
    {
        Debug.Log("취소");
    }
}