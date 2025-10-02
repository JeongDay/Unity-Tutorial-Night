using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class PoolManager : SingletonMonoBehaviour<PoolManager>
{
    public Dictionary<string, ObjectPool<GameObject>> pools = new Dictionary<string, ObjectPool<GameObject>>();

    public GameObject[] guestPrefabs;
    public Transform spawnTf;

    private int poolSize = 100;

    void Awake()
    {
        base.Awake();
        
        foreach (GameObject prefab in guestPrefabs)
        {
            ObjectPool<GameObject> newPool = new ObjectPool<GameObject>(() => CreateObject(prefab), GetObject, ReleaseObject, maxSize: poolSize);

            pools.Add(prefab.name, newPool);
        }
    }

    private GameObject CreateObject(GameObject prefab)
    {
        GameObject obj = Instantiate(prefab, spawnTf.position, Quaternion.identity);
        obj.SetActive(false);

        return obj;
    }

    private void GetObject(GameObject obj)
    {
        obj.SetActive(true);
    }

    private void ReleaseObject(GameObject obj)
    {
        obj.SetActive(false);
    }

    public GameObject GetPoolObject(string prefabName)
    {
        foreach (var pool in pools)
        {
            if (pool.Key == prefabName)
            {
                return pool.Value.Get();
            }
        }

        Debug.Log("Can not GetPoolObject");
        return null;
    }

    public void ReleasePoolObject(string prefabName, GameObject obj)
    {
        foreach (var pool in pools)
        {
            if (pool.Key == prefabName)
            {
                pool.Value.Release(obj);

                return;
            }
        }
        
        Debug.Log("Can not ReleasePoolObject");
    }
    
}