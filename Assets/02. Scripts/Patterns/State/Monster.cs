using UnityEngine;

public class Monster : MonoBehaviour
{
    public IMonsterState monsterState;

    public void SetState(IMonsterState newState)
    {
        if (monsterState != newState)
        {
            monsterState.StateEnd(); // 기존 상태 종료 이벤트
            
            monsterState = newState; // 상태 변경

            monsterState.StateStart(); // 새로운 상태 시작 이벤트
        }
    }
    
    void Update()
    {
        monsterState.StateAction();
    }
}