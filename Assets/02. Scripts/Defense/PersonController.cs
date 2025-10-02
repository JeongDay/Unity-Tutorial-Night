using UnityEngine;
using UnityEngine.AI;

public class PersonController : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator anim;

    private Transform destination;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        destination = GameObject.Find("Destination Pos").transform;

        int ranIdx = Random.Range(0, 4);
        anim.SetFloat("Move", ranIdx * 0.33f);

        if (ranIdx != 0)
            agent.speed = ranIdx;
        
        agent.SetDestination(destination.position);
    }
}