using UnityEngine;

public class MonsterPatrol : MonoBehaviour, IMonsterState
{
    public void StateStart()
    {
        Debug.Log("Patrol 시작");
    }

    public void StateAction()
    {
        Debug.Log("정찰하는 기능");
    }

    public void StateEnd()
    {
        Debug.Log("Patrol 종료");
    }
}