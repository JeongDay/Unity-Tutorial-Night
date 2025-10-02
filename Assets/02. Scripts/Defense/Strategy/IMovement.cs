using UnityEngine;
using UnityEngine.AI;

public interface IMovement
{
    void Move(NavMeshAgent agent, Animator anim, Transform destination);
}