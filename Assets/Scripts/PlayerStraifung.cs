using UnityEngine;

public class PlayerStraifung : MonoBehaviour
{
    public bool isStunned = false;
    private GameObject player;
    public Joystick joystick;
    public float movespeed = 10f;

    private void Start()
    {
        player = this.gameObject;
    }

    private void Update()
    {
        if(!isStunned)
        {
            player.transform.Translate(Vector3.right * joystick.delta.x * movespeed * Time.deltaTime);
        }
    }
}
