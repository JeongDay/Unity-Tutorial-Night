using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolQueue : MonoBehaviour
{
    public Queue<GameObject> objQueue = new Queue<GameObject>();
    
    public GameObject objPrefab;
    public Transform parent;

    void Start()
    {
        CreateObject();
    }

    private void CreateObject()
    {
        for (int i = 0; i < 100; i++)
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
        obj.SetActive(true);
        
        return obj;
    }
}