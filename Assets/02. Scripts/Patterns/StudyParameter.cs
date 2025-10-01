using System.Collections.Generic;
using UnityEngine;

public class StudyParameter : MonoBehaviour
{
    public enum ParameterType { Normal, Ref, Out }
    public ParameterType parameterType;

    private int number;

    public int resultNumber = 0;


    public GameObject[] monsters;
    public GameObject[] npcs;
    public GameObject[] bullets;
    
    void OnEnable()
    {
        number = 0;

        Debug.Log($"호출 전 number : {number}");

        switch (parameterType)
        {
            case ParameterType.Normal:
                
                NormalParameter(number);
                
                break;
            case ParameterType.Ref:
                
                RefParameter(ref number);
                
                break;
            case ParameterType.Out:

                bool isRedWin;
                int redScore;
                int blueScore;

                OutParameter(out isRedWin, out redScore, out blueScore);
                
                // 점수 정산과 End 화면 생성
                
                break;
        }
        
        Debug.Log($"호출 후 number : {number}");
    }

    void Start()
    {
        SetActiveObject(false, bullets[0], npcs[3], monsters[5]);
        
        SetActiveObject(true, bullets[0], npcs[3], monsters[5]);   
    }

    #region MyRegion
    private void NormalParameter(int n)
    {
        n = 100;
        Debug.Log("매개변수 n에게 100 할당");
    }
    
    private void RefParameter(ref int n)
    {
        n = 100;
        Debug.Log("매개변수 n에게 100 할당");
    }
    
    // 승자와 블루팀, 레드팀 점수를 알 수 있는 함수
    private void OutParameter(out bool isWinner, out int blueScore, out int redScore)
    {
        int redTeam = 100;
        int blueTeam = 80;

        bool isRedWin = redTeam > blueTeam ? true : false;

        isWinner = isRedWin;
        redScore = redTeam;
        blueScore = blueTeam;
    }

    public void ArrayParameter(int[] nums)
    {
        // 배열을 활용한 기능
    }
    
    public void ListParameter(List<int> nums)
    {
        // 리스트를 활용한 기능
    }
    
    #endregion

    private void ParamsGameObjectOff(GameObject obj1, params GameObject[] objs)
    {
        foreach (var obj in objs)
        {
            obj.SetActive(false);
        }
    }

    public void SetActiveObject(bool isActive, params GameObject[] objs)
    {
        foreach (var obj in objs)
            obj.SetActive(isActive);
    }
    
    
    
    
}