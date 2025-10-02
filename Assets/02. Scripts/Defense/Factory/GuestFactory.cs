using UnityEngine;

public class GuestFactory : Factory
{
    protected override Guest CraeteGuest(int index, Transform destTf)
    {
        string prefabName = PoolManager.Instance.guestPrefabs[index].name;
        GameObject guestObj = PoolManager.Instance.GetPoolObject(prefabName);

        Guest guest = guestObj.GetComponent<Guest>();
        guest.SetDest(destTf);

        return guest;
    }
}