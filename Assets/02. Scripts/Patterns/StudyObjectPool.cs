using System.Collections.Generic;
using UnityEngine;

public class StudyObjectPool : MonoBehaviour
{
    public Queue<GameObject> objQueue = new Queue<GameObject>();
    
    public GameObject objPrefab;
    public Transform parent;

    void Start()
    {
        CreateObject(150);
    }

    private void CreateObject(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject obj = Instantiate(objPrefab, parent);
            EnqueueObject(obj);
        }
    }

    public void EnqueueObject(GameObject newObj)
    {
        Rigidbody rb = newObj.GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        
        objQueue.Enqueue(newObj);
        newObj.SetActive(false);
    }

    public GameObject DequeueObject()
    {
        GameObject obj = objQueue.Dequeue();

        if (objQueue.Count < 10)
        {
            CreateObject(50); // 50개 추가 생성
        }
        
        obj.SetActive(true);
        
        return obj;
    }
}