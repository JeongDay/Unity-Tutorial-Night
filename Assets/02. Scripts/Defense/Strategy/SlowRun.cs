using UnityEngine;
using UnityEngine.AI;

public class SlowRun : IMovement
{
    public void Move(NavMeshAgent agent, Animator anim, Transform destination)
    {
        anim.SetFloat("Move", 0.66f);
        agent.speed = 2f;
        agent.SetDestination(destination.position);
    }
}