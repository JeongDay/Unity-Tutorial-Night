using System;
using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Coroutine runningCoroutine;
    
    void Start()
    {
        runningCoroutine = StartCoroutine(RunningCoroutine());
        Invoke("Stop", 1.5f);
    }

    IEnumerator RunningCoroutine()
    {
        Debug.Log("실행 1");
        yield return new WaitForSeconds(1.0f);
        
        Debug.Log("실행 2");
        yield return new WaitForSeconds(1.0f);
        
        Debug.Log("실행 3");
        yield return new WaitForSeconds(1.0f);
    }

    private void Stop()
    {
        StopAllCoroutines();
        Debug.Log("강제 종료");
    }
}