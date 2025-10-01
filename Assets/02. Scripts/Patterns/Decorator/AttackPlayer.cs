using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public IAttack2 currentAttack;
    public int index;
    
    void Start()
    {
        currentAttack = new BasicAttack();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentAttack = new FireAttack(currentAttack);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentAttack = new IceAttack(currentAttack);
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            currentAttack.Attack();
        }
    }

}