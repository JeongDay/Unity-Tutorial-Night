using UnityEngine;

public class SkillCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("스킬 기능");
    }

    public void Cancel()
    {
        Debug.Log("취소");
    }
}