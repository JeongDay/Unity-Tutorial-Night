using UnityEngine;

public interface IDamageable
{
    void TakeDamage(int damage);
}

// public class Player : MonoBehaviour
// {
//     public IDamageable target;
//
//     public void Attack()
//     {
//         target.TakeDamage(10);
//     }
// }

public class Enemy : MonoBehaviour, IDamageable
{
    public int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}