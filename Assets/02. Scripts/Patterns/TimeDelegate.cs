using System.Collections;
using UnityEngine;

public class TimeDelegate : MonoBehaviour
{
    public delegate void TimerStart();
    public static TimerStart timerStart;
    
    public delegate void TimerStop();
    public static event TimerStop timerStop;
    
    public delegate void TimerEnd();
    public static TimerEnd timerEnd;

    public float timer = 5f;
    public bool isTimer;

    void OnEnable()
    {
        timerStart += Init; // Start 이벤트 등록
    }

    void OnDisable()
    {
        timerStart -= Init; // Start 이벤트 해제
    }
    
    void Start()
    {
        timerStart?.Invoke(); // 게임이 시작할 때 델리게이트 실행
        
        StartCoroutine(TimerRoutine());
    }

    private void Init()
    {
        Debug.Log("처음 시작할 때 들어가는 셋팅");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // 폭탄 해제 완료
        {
            isTimer = false;
            Debug.Log("폭탄 해제 완료");
            timerStop?.Invoke();
        }
    }
    
    IEnumerator TimerRoutine()
    {
        while (isTimer)
        {
            Debug.Log(timer);
            yield return new WaitForSeconds(1f);
            timer--;

            if (timer <= 0f) // 시간 종료로 게임 종료
            {
                isTimer = false;
                Debug.Log("시간 종료");
                timerEnd?.Invoke();
            }
        }
    }

    public void OnTimerStop()
    {
        timerStop?.Invoke();
    }
}