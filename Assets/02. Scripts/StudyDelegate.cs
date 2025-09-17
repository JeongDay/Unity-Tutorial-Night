using UnityEngine;

public class StudyDelegate : MonoBehaviour
{
    public delegate void MyDelegate(int a = 20);
    public MyDelegate myDelegate;

    public int number2;
    public int number3;
    
    void Start()
    {
        myDelegate += MethodA;
        myDelegate += MethodB;
        // myDelegate = MethodC;
        
        myDelegate?.Invoke(10); // 매개변수가 있는 델리게이트 실행
        myDelegate?.Invoke(); // argument 값을 넣지 않아도 실행할 수 있는 Default Parameter 값
    }
    
    private void MethodA(int x)
    {
        Debug.Log("Method A");
    }

    private void MethodB(int m)
    {
        Debug.Log("Method B");
    }

    private void MethodC() // 매개변수가 없는 함수 C
    {
        Debug.Log("Method C");
    }
}