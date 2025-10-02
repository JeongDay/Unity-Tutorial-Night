using UnityEngine;

public abstract class Factory : MonoBehaviour
{
    protected abstract Guest CraeteGuest(int index, Transform destTf);

    public Guest SpawnGuest(int index, Transform destTf)
    {
        Guest guest = CraeteGuest(index, destTf);

        return guest;
    }
}