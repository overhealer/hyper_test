using UnityEngine;
using UnityEngine.AI;

public class Obstalce : MonoBehaviour
{
    public GameObject losePanel;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("Fall");
            other.gameObject.GetComponent<NavMeshAgent>().isStopped = true;
            other.gameObject.GetComponent<PlayerStraifung>().isStunned = true;
            losePanel.SetActive(true);
        }
    }
}
