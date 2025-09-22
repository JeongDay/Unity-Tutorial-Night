using UnityEngine;

public class MonsterIdle : MonoBehaviour, IMonsterState
{
    public void StateStart()
    {
        Debug.Log("Idle 시작");
    }

    public void StateAction()
    {
        Debug.Log("가만히 있는 기능");
    }

    public void StateEnd()
    {
        Debug.Log("Idle 종료");
    }
}