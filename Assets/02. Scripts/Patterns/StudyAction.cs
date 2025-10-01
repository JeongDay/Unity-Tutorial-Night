using System;
using UnityEngine;

public class StudyAction : MonoBehaviour
{
    public static event Action myAction;
    public static event Action<string> myAction2;

    void Start()
    {
        myAction += () => Debug.Log("Hello");

        myAction2 += str => Debug.Log(str);
        myAction2?.Invoke("Hello Unity");
    }
}