using UnityEngine;

public class MonsterTrace : MonoBehaviour, IMonsterState
{
    public void StateStart()
    {
        Debug.Log("Trace 시작");
    }

    public void StateAction()
    {
        Debug.Log("추격하는 기능");
    }

    public void StateEnd()
    {
        Debug.Log("Trace 종료");
    }
}