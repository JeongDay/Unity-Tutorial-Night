using UnityEngine;

public abstract class AttackDecorator : IAttack2
{
    public IAttack2 currentAttack;

    public AttackDecorator(IAttack2 attack)
    {
        currentAttack = attack;
    }
    
    public virtual void Attack()
    {
        currentAttack.Attack();
    }
}