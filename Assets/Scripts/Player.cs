using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public Transform target;
    public float playerSpeed;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = playerSpeed;
    }

    private void FixedUpdate()
    {
        agent.destination = target.position;
    }
}
