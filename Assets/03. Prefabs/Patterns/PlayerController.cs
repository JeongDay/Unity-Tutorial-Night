using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int damage;
    public int health;
    public string name;

    public PlayerData data;
    
    void Start()
    {
        damage = data.playerDamage;
        damage = data.playerHealth;
        
        name = data.detailData.playerName;
    }
}