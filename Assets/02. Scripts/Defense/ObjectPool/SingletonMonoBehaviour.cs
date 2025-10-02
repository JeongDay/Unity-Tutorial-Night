using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : Component
{
    private static T instance = null;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindFirstObjectByType<T>();
                if (instance == null)
                {
                    var newObj = new GameObject(typeof(T).ToString());
                    instance = newObj.AddComponent<T>();
                }
            }
            return instance;
        }
    }

    protected virtual void Awake()
    {
        if (instance == null)
            instance = this as T;
    }
}