using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public StudyClass studyClass;
    
    public int myHp;

    void Start()
    {
        studyClass = new StudyClass();
        
        // studyClass.hp = 100; // 직접 수정
        // studyClass.SetHp(100); // 함수를 통한 수정
        // studyClass.Hp = 100; // 프로퍼티를 활용한 수정
    }

    void Update()
    {
        studyClass = new StudyClass();

        // myHp = studyClass.GetHp(); // 함수를 통한 접근
        myHp = studyClass.Hp; // 프로퍼티를 활용한 접근
    }
}