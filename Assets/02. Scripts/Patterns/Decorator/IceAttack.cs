using UnityEngine;

public class IceAttack : AttackDecorator
{
    public IceAttack(IAttack2 attack) : base(attack)
    {
        
    }

    public override void Attack()
    {
        base.Attack();
        Debug.Log("얼음 공격");
    }
}