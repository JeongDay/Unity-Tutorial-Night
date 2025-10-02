using UnityEngine;
using UnityEngine.AI;

public class SlowWalk : IMovement
{
    public void Move(NavMeshAgent agent, Animator anim, Transform destination)
    {
        anim.SetFloat("Move", 0f);
        agent.speed = 0.5f;
        agent.SetDestination(destination.position);
    }
}