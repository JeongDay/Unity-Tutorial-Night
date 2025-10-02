using UnityEngine;
using UnityEngine.AI;

public class BasicRun : IMovement
{
    public void Move(NavMeshAgent agent, Animator anim, Transform destination)
    {
        anim.SetFloat("Move", 1f);
        agent.speed = 3f;
        agent.SetDestination(destination.position);
    }
}