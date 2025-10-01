using UnityEngine;

public class StudySound : MonoBehaviour
{
    void OnEnable()
    {
        TimeDelegate.timerStop += CongratulationSound; // 이벤트 등록
        TimeDelegate.timerEnd += BombSound;
    }

    void OnDisable()
    {
        TimeDelegate.timerStop -= CongratulationSound; // 이벤트 등록 해제
        TimeDelegate.timerEnd -= BombSound;
    }

    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Return))
        // {
        //     TimeDelegate.timerStop?.Invoke(); // 외부 클래스에서 델리게이트 실행
        // }
    }
    
    public void CongratulationSound()
    {
        Debug.Log("빵빠레");
    }
    
    public void BombSound()
    {
        Debug.Log("펑");
    }
}