using UnityEngine;

public class FireAttack : AttackDecorator
{
    public FireAttack(IAttack2 attack) : base(attack)
    {
        
    }

    public override void Attack()
    {
        base.Attack();
        Debug.Log("화염 공격");
    }
}