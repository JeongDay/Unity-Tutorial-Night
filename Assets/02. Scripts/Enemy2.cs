using UnityEngine;

public class Enemy2 : MonoBehaviour // , IDamageable
{
    private EnemyAnimation animation;
    // private EnemySound sound;
    // private EnemyParticle particle;
    private EnemyScore score;
    
    public int health = 100;

    void Start()
    {
        animation = new EnemyAnimation();
        // sound = new EnemySound();
        // particle = new EnemyParticle();
        score = gameObject.AddComponent<EnemyScore>();

        // animation = gameObject.AddComponent<EnemyAnimation>();
        // sound = gameObject.AddComponent<EnemySound>();
        // particle = gameObject.AddComponent<EnemyParticle>();
        // score = gameObject.AddComponent<EnemyScore>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animation.JumpAnim();
        }

        if (Input.GetMouseButtonDown(0))
        {
            score.ScoreUp();
        }
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            // sound.DeathSound();
            // particle.DeathParticle();
        }
    }
}