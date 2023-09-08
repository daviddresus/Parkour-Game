using System.Collections;
using UnityEngine;

public class Player_jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount = 35;
    public float gravityScale = 10;
    public float fallingGravityScale = 40;

    public GameObject Player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            Player.GetComponent<Animator>().Play("90_rotation");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Player.GetComponent<Animator>().Play("Idle");
        }

        if (rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        }

        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
        }
    }
}
