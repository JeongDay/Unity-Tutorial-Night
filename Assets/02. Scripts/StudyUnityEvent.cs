using UnityEngine;
using UnityEngine.Events;

public class StudyUnityEvent : MonoBehaviour
{
    public delegate void MyDelegate(int number);
    public MyDelegate myDelegate;
    
    public UnityEvent unityEvent;

    void Start()
    {
        unityEvent.AddListener(MethodA); // 델리게이트 기반의 유니티에서 사용할 수 있도록 만든 이벤트
        unityEvent.RemoveListener(MethodA);
        unityEvent.RemoveAllListeners();
        
        unityEvent?.Invoke();

        // myDelegate += MethodA;
        myDelegate += MethodB;

        unityEvent.AddListener(MethodA);
        // unityEvent.AddListener(MethodB(10));
        
        unityEvent.AddListener(() =>
        {
            MethodB(10);
        });

        unityEvent.AddListener(() => MethodB(10));
    }

    private void MethodA()
    {
        
    }

    private void MethodB(int n)
    {
        
    }
}