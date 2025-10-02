using UnityEngine;
using UnityEngine.AI;

public abstract class Guest : MonoBehaviour
{
    private IMovement currMovement;
    
    private NavMeshAgent agent;
    private Animator anim;

    private Transform destination;

    public string guestName;
    public float capacity;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

        Init();
    }

    protected abstract void Init();

    public void SetDest(Transform destTf)
    {
        destination = destTf;

        int ranIdx = Random.Range(0, 4);
        switch (ranIdx)
        {
            case 0:
                currMovement = new SlowWalk();
                break;
            case 1:
                currMovement = new BasicWalk();
                break;
            case 2:
                currMovement = new SlowRun();
                break;
            case 3:
                currMovement = new BasicRun();
                break;
        }

        currMovement.Move(agent, anim, destination);
    }

    public void ReturnPool()
    {
        PoolManager.Instance.ReleasePoolObject(guestName, this.gameObject);
    }
}