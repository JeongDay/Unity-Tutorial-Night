using System;
using System.Collections;
using UnityEngine;

public class StudyClass : MonoBehaviour
{
    private int hp = 10; // 원본 데이터
    public int Hp // 프로퍼티 = 접근 데이터
    {
        get => hp;
        private set
        {
            if (value > 0)
            {
                Debug.Log($"현재 Hp가 {value}로 변경되었습니다.");
                hp = value;
            }
        }
    }
}