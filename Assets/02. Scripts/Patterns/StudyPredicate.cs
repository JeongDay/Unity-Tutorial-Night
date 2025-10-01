using System;
using UnityEngine;

public class StudyPredicate : MonoBehaviour
{
    public Predicate<int> myPredicate;

    public int level;

    void Start()
    {
        // Predicate 활용
        myPredicate = n => n <= 10;
        Debug.Log($"초보자 사냥터 진입 : {myPredicate(level)}");
        
        // 삼항 연산자 활용
        bool result2 = level <= 10 ? true : false;
        Debug.Log($"초보자 사냥터 진입 : {result2}");
        
        // 조건문 활용
        if (level <= 10)
        {
            bool result = true;
            Debug.Log($"초보자 사냥터 진입 : {result}");
        }
        else if (level > 10)
        {
            bool result = false;
            Debug.Log($"초보자 사냥터 진입 : {result}");
        }
    }
}