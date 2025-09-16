using UnityEngine;

public class Sword : MonoBehaviour, IAttack
{
    public int damage { get; set; }

    void Start()
    {
        damage = 30;
    }
    
    public void Use()
    {
        
    }
}