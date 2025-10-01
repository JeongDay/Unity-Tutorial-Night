using UnityEngine;

public class ExternalClass : MonoBehaviour
{
    void Awake()
    {
        StudyAction.myAction += MethodA;
    }

    private void MethodA()
    {
        
    }
}