using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Factory guestFactory;
    
    public Transform destinationTf;

    void Awake()
    {
        guestFactory = GetComponent<GuestFactory>();
    }
    
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            
            int ranIdx = Random.Range(0, 4);
            
            Guest guestObj = guestFactory.SpawnGuest(ranIdx, destinationTf);
            
            guestObj.transform.SetParent(transform);
        }
    }
}