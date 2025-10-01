using UnityEngine;

public class Gun : MonoBehaviour, IAttack
{
    public int damage { get; set; }

    void Start()
    {
        damage = 10;
    }

    public void Use()
    {
        
    }
}