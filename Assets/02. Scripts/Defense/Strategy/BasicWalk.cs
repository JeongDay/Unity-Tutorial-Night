using UnityEngine;
using UnityEngine.AI;

public class BasicWalk : IMovement
{
    public void Move(NavMeshAgent agent, Animator anim, Transform destination)
    {
        anim.SetFloat("Move", 0.33f);
        agent.speed = 1f;
        agent.SetDestination(destination.position);
    }
}