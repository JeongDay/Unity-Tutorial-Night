using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudyLambda : MonoBehaviour
{
    public Button[] buttons;

    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int j = i;
            buttons[i].onClick.AddListener(() => SetButton(j));
        }
    }

    private void SetButton(int index)
    {
        switch (index)
        {
            case 0:
                Debug.Log("Hello");
                break;
            case 1:
                Debug.Log("World");
                break;
            case 2:
                Debug.Log("Unity");
                break;
            default:
                Debug.Log("Index : " + index);
                break;
        }
    }
}