using UnityEngine;

public class Man : Guest
{
    protected override void Init()
    {
        guestName = "Man";
        capacity = 100f;
    }
}