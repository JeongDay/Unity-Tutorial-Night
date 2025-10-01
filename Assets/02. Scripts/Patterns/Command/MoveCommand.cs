using UnityEngine;

public class MoveCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("움직이는 기능");
    }

    public void Cancel()
    {
        Debug.Log("취소");
    }
}