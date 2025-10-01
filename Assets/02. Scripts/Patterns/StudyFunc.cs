using System;
using System.Collections.Generic;
using UnityEngine;

public class StudyFunc : MonoBehaviour
{
    public List<Func<int, int, int>> funcList = new List<Func<int, int, int>>();
    
    public List<Func<int, int>> funcList2 = new List<Func<int, int>>();
    
    void Start()
    {
        // funcList.Add(AddMethod);
        // funcList.Add(MinusMethod);
        // funcList.Add(MultiplyMethod);

        funcList.Add((a, b) => a + b);
        funcList.Add((a, b) => a - b);
        funcList.Add((a, b) => a * b);

        funcList2.Add(n => n + 10);
        
        foreach (var func in funcList)
        {
            int result = func.Invoke(20, 10);
            Debug.Log(result);
        }
    }

    private int AddMethod(int a, int b)
    {
        int result = a + b;
        
        return result;
    }
    
    private int MinusMethod(int a, int b)
    {
        int result = a - b;
        
        return result;
    }
    
    private int MultiplyMethod(int a, int b)
    {
        int result = a * b;
        
        return result;
    }
    
    // private bool Method(int a, int b)
    // {
    //     bool result = (a + b) % 2 == 0;
    //     
    //     return result;
    // }
}